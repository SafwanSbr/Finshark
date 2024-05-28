using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CompanyTenK
    {
        [Key]
        public int Id { get; set; } // Assuming a primary key

        [Required]
        public string Symbol { get; set; }

        [Required]
        public DateTime FillingDate { get; set; }

        [Required]
        public DateTime AcceptedDate { get; set; }

        [Required]
        public string Cik { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Link { get; set; }

        [Required]
        public string FinalLink { get; set; }
    }
}
