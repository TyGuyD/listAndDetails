namespace Game.Models;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public string Generation { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Developer { get; set; } = string.Empty;
    public string Platform { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
