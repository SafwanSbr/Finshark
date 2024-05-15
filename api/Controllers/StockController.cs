using api.Data;
using api.DTOs;
using api.Helpers;
using api.Interfaces;
using api.Mapper;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/stock")]
    public class StockController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IStockRepository _stockRepo;
        public StockController(DataContext context, IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
            _context = context;
        }

        //Get All Stocks
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var stocks = await _stockRepo.GetAllAsync(query);
            var stockDto = stocks.Select(s => s.toStockDTO()).ToList();

            return Ok(stockDto);
        }

        //Get a Specific Stock
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id) //Get ID from url
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var stock = await _stockRepo.GetByIdAsync(id);
            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock.toStockDTO()); //Return data into StockDTO formate
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStockRequestDTO stockDto) //Taking Data from Body into this parameter
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var stockModel = stockDto.toStock(); //StockDTO to Stock object
            await _stockRepo.CreateStockAsync(stockModel);

            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel.toStockDTO());// Take to the "GetById" method with data
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStockRequestDTO updateDto) //Search Data using Id and then Update
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var stockModel = await _stockRepo.UpdateStockAsync(id, updateDto);

            if (stockModel == null)
            {
                return NotFound();
            }

            return Ok(stockModel.toStockDTO()); //Show Updated data from bd
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid) // Came form ControllerBase class
                return BadRequest(ModelState);

            var stockModel = await _stockRepo.DeleteStockAsync(id);

            if (stockModel == null)
            {
                return NotFound();
            }

            return NoContent(); //Code: 204
        }
    }
}
