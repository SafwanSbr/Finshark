using api.DTOs;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id); // Can be Null
        Task<Stock?> GetBySymbolAsync(string symbol);
        Task<Stock> CreateStockAsync(Stock stock);
        Task<Stock?> UpdateStockAsync(int id, UpdateStockRequestDTO updateStockRequestDTO);
        Task<Stock?> DeleteStockAsync(int id);

        Task<bool> IsStockExists(int id);
    }
}
