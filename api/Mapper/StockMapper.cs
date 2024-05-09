using api.DTOs;
using api.Models;

namespace api.Mapper
{
    public static class StockMapper
    {
        public static StockDTO toStockDTO(this Stock stock)
        {
            return new StockDTO
            {
                Symbol = stock.Symbol,
                CompanyName = stock.CompanyName,
                Industry = stock.Industry,
                MarketCap = stock.MarketCap,
                Purchase = stock.Purchase,
                LastDiv = stock.LastDiv,
                Comments = stock.Comments.Select(s => s.toCommentDTO()).ToList()
            };
        }

        public static Stock toStock(this CreateStockRequestDTO createStockRequestDTO)
        {
            return new Stock
            {
                Symbol = createStockRequestDTO.Symbol,
                CompanyName = createStockRequestDTO.CompanyName,
                Industry = createStockRequestDTO.Industry,
                MarketCap = createStockRequestDTO.MarketCap,
                Purchase = createStockRequestDTO.Purchase,
                LastDiv = createStockRequestDTO.LastDiv
            };
        }

        public static Stock toStock(this UpdateStockRequestDTO updateStockRequestDTO)
        {
            return new Stock
            {
                Symbol = updateStockRequestDTO.Symbol,
                CompanyName = updateStockRequestDTO.CompanyName,
                Industry = updateStockRequestDTO.Industry,
                MarketCap = updateStockRequestDTO.MarketCap,
                Purchase = updateStockRequestDTO.Purchase,
                LastDiv = updateStockRequestDTO.LastDiv
            };
        }
    }
}
