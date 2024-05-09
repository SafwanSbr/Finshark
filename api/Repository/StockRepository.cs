using api.Data;
using api.DTOs;
using api.Helpers;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly DataContext _context;
        public StockRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Stock> CreateStockAsync(Stock stock)
        {
            await _context.Stocks.AddAsync(stock);
            await _context.SaveChangesAsync();

            return stock;
        }

        public async Task<Stock?> DeleteStockAsync(int id)
        {
            var stock = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);

            if(stock == null) { return null; }

            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();
            return stock;
        }

        public async Task<List<Stock>> GetAllAsync(QueryObject query)
        {
            var stockList = _context.Stocks.Include(c => c.Comments).AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.CompanyName)) //Filtering
            {
                stockList = stockList.Where(s => s.CompanyName.Contains(query.CompanyName));
            }

            if (!string.IsNullOrWhiteSpace(query.Symbol))
            {
                stockList = stockList.Where(s => s.Symbol.Contains(query.Symbol));
            }

            if (!string.IsNullOrWhiteSpace(query.SortBy))
            {
                if (query.SortBy.Equals("Symbol", StringComparison.OrdinalIgnoreCase))
                {
                    stockList = query.IsDecsending ? stockList.OrderByDescending(s => s.Symbol) : stockList.OrderBy(s => s.Symbol);
                }
            }

            var skipNumber = (query.PageNumber - 1) * query.PageSize;

            return await stockList.Skip(skipNumber).Take(query.PageSize).ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(int id)
        {
            return await _context.Stocks.Include(c => c.Comments).FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> IsStockExists(int id)
        {
            return _context.Stocks.AnyAsync(c => c.Id == id);
        }

        public async Task<Stock?> UpdateStockAsync(int id, UpdateStockRequestDTO updateStockRequestDTO)
        {
            var existingStock = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);

            if (existingStock == null)
            {
                return null;
            }

            existingStock.Symbol = updateStockRequestDTO.Symbol;
            existingStock.CompanyName = updateStockRequestDTO.CompanyName;
            existingStock.Purchase = updateStockRequestDTO.Purchase;
            existingStock.LastDiv = updateStockRequestDTO.LastDiv;
            existingStock.Industry = updateStockRequestDTO.Industry;
            existingStock.MarketCap = updateStockRequestDTO.MarketCap;

            await _context.SaveChangesAsync();

            return existingStock;
        }
    }
}
