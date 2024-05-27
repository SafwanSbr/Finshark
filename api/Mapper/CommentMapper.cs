using api.DTOs;
using api.Models;

namespace api.Mapper
{
    public static class CommentMapper
    {
        public static CommentDTO toCommentDTO(this Comment comment)
        {
            return new CommentDTO
            {
                Title = comment.Title,
                Content = comment.Content,
                CreatedOn = comment.CreatedOn,
                StockId = comment.StockId,
                CreatedBy = (comment.AppUser != null)? comment.AppUser.UserName : ""
            };
        }

        public static Comment toComment(this CommentDTO commentDTO)
        {
            return new Comment
            {
                Title = commentDTO.Title,
                Content = commentDTO.Content,
                CreatedOn = commentDTO.CreatedOn,
                StockId = commentDTO.StockId
            };
        }

        public static Comment toComment(this CreateCommentDTO createCommentDTO, int stockId)
        {
            return new Comment
            {
                Title = createCommentDTO.Title,
                Content = createCommentDTO.Content,
                StockId = stockId
            };
        }

        public static Comment toComment(this UpdateCommentDTO updateCommentDTO)
        {
            return new Comment
            {
                Title = updateCommentDTO.Title,
                Content = updateCommentDTO.Content
            };
        }
    }
}
