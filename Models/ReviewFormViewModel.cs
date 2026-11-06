namespace Game.Models
{
    public class ReviewFormViewModel
    {
        public int GameId { get; set; }
        public string ReviewerName { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}