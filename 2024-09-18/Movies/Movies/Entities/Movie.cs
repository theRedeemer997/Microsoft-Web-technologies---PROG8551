using System.ComponentModel.DataAnnotations;

namespace Movies.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [Range(1830, int.MaxValue, ErrorMessage = "The rating of the movie should be less that 1830")]
        public int? Year { get; set; }


        [Required]
        [Range(1,5, ErrorMessage ="Movie ratings must be between 1 and 5")]
        public int? Rating { get; set; }
    }
}
