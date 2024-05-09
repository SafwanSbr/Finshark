﻿using api.Models;

namespace api.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllComments();
        Task<Comment?> GetCommentById(int id);
        Task<Comment> CreateComment(Comment comment);
        Task<Comment?> UpdateComment(int id, Comment comment);
        Task<Comment?> DeleteComment(int id);
    }
}
