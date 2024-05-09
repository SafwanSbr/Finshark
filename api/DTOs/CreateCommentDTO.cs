using System.ComponentModel.DataAnnotations;

namespace api.DTOs
{
    public class CreateCommentDTO
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be atleast 5 characters")]
        [MaxLength(280, ErrorMessage = "Title can't be more then 280 characters")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Content must be atleast 5 characters")]
        public string Content { get; set; } = string.Empty;
    }
}
