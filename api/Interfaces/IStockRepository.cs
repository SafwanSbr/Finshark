﻿using api.DTOs;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
        Task<Stock?> GetByIdAsync(int id); // Can be Null
        Task<Stock> CreateStockAsync(Stock stock);
        Task<Stock?> UpdateStockAsync(int id, UpdateStockRequestDTO updateStockRequestDTO);
        Task<Stock?> DeleteStockAsync(int id);

        Task<bool> IsStockExists(int id);
    }
}
