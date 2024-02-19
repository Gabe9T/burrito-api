using System.ComponentModel.DataAnnotations;

namespace BurritoApi.Models
{
    public class Burrito
    {
        public int BurritoId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Protein { get; set; }
        public string Review { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public Double Rating { get; set; }

    }
}