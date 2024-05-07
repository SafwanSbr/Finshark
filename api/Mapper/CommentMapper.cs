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
                Id = comment.Id,
                Title = comment.Title,
                Content = comment.Content,
                CreatedOn = comment.CreatedOn
            };
        }

        public static Comment toComment(this CommentDTO commentDTO)
        {
            return new Comment
            {
                Id = commentDTO.Id,
                Title = commentDTO.Title,
                Content = commentDTO.Content,
                CreatedOn = commentDTO.CreatedOn
            };
        }
    }
}
