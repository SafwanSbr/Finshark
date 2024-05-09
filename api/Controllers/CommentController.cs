using api.Data;
using api.DTOs;
using api.Interfaces;
using api.Mapper;
using Microsoft.AspNetCore.Http;
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
        public CommentController(ICommentRepository commentRepo, IStockRepository stockRepo, DataContext context)
        {
            _stockRepo = stockRepo;
            _commentRepo = commentRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var commentList = await _commentRepo.GetAllComments();
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

        

        [HttpPost("{stockId:int}")] //Data validation using URL
        public async Task<IActionResult> Create([FromRoute] int stockId, CreateCommentDTO commentDTO)
        {

            if(!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            if (!await _stockRepo.IsStockExists(stockId))
            {
                return BadRequest("Stock does not exist");
            }

            var commentModel = commentDTO.toComment(stockId);
            
            await _commentRepo.CreateComment(commentModel);
            return CreatedAtAction(nameof(GetById), new { id = commentModel }, commentModel.toCommentDTO());
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

