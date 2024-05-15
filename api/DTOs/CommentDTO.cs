﻿namespace api.DTOs
{
    public class CommentDTO
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
        public string CreatedBy { get; set; } = string.Empty;

    }
}
