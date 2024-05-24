using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly DataContext _dataContext;
        public PortfolioRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Portfolio> CreateAsync(Portfolio portfolio)
        {
            await _dataContext.Portfolios.AddAsync(portfolio);
            await _dataContext.SaveChangesAsync(); 
            return portfolio;
        }

        public async Task<Portfolio> DeletePortfolio(AppUser user, string symbol)
        {
            var existingPortfolio = await _dataContext.Portfolios.FirstOrDefaultAsync(x => x.AppUserID == user.Id && x.Stock.Symbol.ToLower() == symbol.ToLower());
            if (existingPortfolio == null) { return null; }

            _dataContext.Portfolios.Remove(existingPortfolio);
            await _dataContext.SaveChangesAsync();
            return existingPortfolio;
        }

        public async Task<List<Stock>> GetUserPortfolio(AppUser user)
        {
            return await _dataContext.Portfolios
                .Where(u => u.AppUserID == user.Id)
                .Select(stock => new Stock
                {
                    Id = stock.StockId,
                    Symbol = stock.Stock.Symbol,
                    Purchase = stock.Stock.Purchase,
                    LastDiv = stock.Stock.LastDiv,
                    Industry = stock.Stock.Industry,
                    MarketCap = stock.Stock.MarketCap

                }).ToListAsync();
        }
    }
}
