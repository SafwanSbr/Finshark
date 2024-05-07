using api.Data;
using api.DTOs;
using api.Mapper;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/stock")]
    public class StockController : ControllerBase
    {
        public readonly DataContext _context;
        public StockController(DataContext context)
        {
            _context = context;
        }

        //Get All Stocks
        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stocks.ToList()
             .Select(s => s.toStockDTO());

            return Ok(stocks);
        }

        //Get a Specific Stock
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) //Get ID from url
        {
            var stock = _context.Stocks.Find(id);
            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock.toStockDTO()); //Return data into StockDTO formate
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDTO stockDto) //Taking Data from Body into this parameter
        {
            var stockModel = stockDto.toStock(); //StockDTO to Stock object
            _context.Stocks.Add(stockModel); //Add into Database
            _context.SaveChanges(); //Update Database
            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel.toStockDTO());// Take to the "GetById" method with data
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateStockRequestDTO updateDto) //Search Data using Id and then Update
        {
            var stockModel = _context.Stocks.FirstOrDefault(x => x.Id == id);

            if (stockModel == null)
            {
                return NotFound();
            }

            stockModel.Symbol = updateDto.Symbol;
            stockModel.CompanyName = updateDto.CompanyName;
            stockModel.Purchase = updateDto.Purchase;
            stockModel.LastDiv = updateDto.LastDiv;
            stockModel.Industry = updateDto.Industry;
            stockModel.MarketCap = updateDto.MarketCap;

            _context.SaveChanges();

            return Ok(stockModel.toStockDTO()); //Show Updated data from bd
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var stockModel = _context.Stocks.FirstOrDefault(x => x.Id == id);

            if (stockModel == null)
            {
                return NotFound();
            }

            _context.Stocks.Remove(stockModel);
            _context.SaveChanges();

            return NoContent(); //Code: 204
        }


    }
}
