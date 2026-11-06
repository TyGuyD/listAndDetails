using System.ComponentModel.DataAnnotations;

namespace Game.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int GameId { get; set; }

        [Required]
        [StringLength(50)]
        public string ReviewerName { get; set; } = string.Empty; 

        [Range(1, 5)]
        public double Rating { get; set; }

        [StringLength(500)]
        public string Comment { get; set; } = string.Empty; 

        public Game Game { get; set; } = null!;
    }
}