using api.Data;
using api.DTOs;
using api.Extentions;
using api.Helpers;
using api.Interfaces;
using api.Mapper;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ICommentRepository _commentRepo;
        private readonly IStockRepository _stockRepo;
        private readonly IFMPService _fmpService;
        private readonly UserManager<AppUser> _userManager;
        
        public CommentController(IFMPService fmpService, ICommentRepository commentRepo, IStockRepository stockRepo, DataContext context, UserManager<AppUser> userManager)
        {
            _fmpService = fmpService;
            _userManager = userManager;
            _stockRepo = stockRepo;
            _commentRepo = commentRepo;
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll([FromQuery] CommentQueryObject queryObject)
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var commentList = await _commentRepo.GetAllComments(queryObject);
            if(commentList == null)
            {
                return NotFound();
            }

            //Convert to CommentDTO
            var commentDTOList = commentList.Select(s => s.toCommentDTO());

            return Ok(commentList);
        }

        [HttpGet("{id:int}")] //Data validation using URL
        public async Task<IActionResult> GetById([FromRoute] int id)
        {

            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var comment = await _commentRepo.GetCommentById(id);
            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment.toCommentDTO());
        }

        
        //Post a Comment Under a Stock
        [HttpPost("{symbol:alpha}")] //Data validation using URL
        public async Task<IActionResult> Create([FromRoute] string symbol, CreateCommentDTO commentDTO)
        {

            if(!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var stock = await _stockRepo.GetBySymbolAsync(symbol);
            if (stock == null)
            {
                stock = await _fmpService.FindStockBySymbolAsync(symbol);
                if (stock == null) return BadRequest("Stock does not exists");
                else await _stockRepo.CreateStockAsync(stock);
            }
            
            var username = User.GetUsername();
            var existingUser = await _userManager.FindByNameAsync(username);
            var commentModel = commentDTO.toComment(stock.Id);

            commentModel.AppUserId = existingUser.Id;
            

            await _commentRepo.CreateComment(commentModel);
            return CreatedAtAction(nameof(GetById), new { id = commentModel.Id }, commentModel.toCommentDTO());
        }

        [HttpPut]
        [Route("{id:int}")] //Data validation using URL
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentDTO updateCommentDTO)
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var comment = await _commentRepo.UpdateComment(id, updateCommentDTO.toComment());
            if(comment == null)
            {
                return NotFound("No Comment Found");
            }

            return Ok(comment.toCommentDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var commentModel = await _commentRepo.DeleteComment(id);

            if (commentModel == null)
            {
                return NotFound("Comment does not exist");
            }

            return Ok(commentModel);
        }
    }
}

