using System.ComponentModel.DataAnnotations;

namespace listAndDetails.ViewModels
{
    public class ReviewFormViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Please select a game.")]
        public int GameId { get; set; }

        [Required]
        [StringLength(50)]
        public string ReviewerName { get; set; } = string.Empty;

        [Range(1.0, 10.0, ErrorMessage = "Rating must be between 1 and 10.")]
        public double Rating { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; } = string.Empty;
    }
}