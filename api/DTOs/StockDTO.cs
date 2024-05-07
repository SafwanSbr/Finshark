﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api.DTOs
{
    public class StockDTO
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
    }
}
