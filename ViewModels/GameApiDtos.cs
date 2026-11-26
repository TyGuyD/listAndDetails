using System.ComponentModel.DataAnnotations;

namespace listAndDetails.ViewModels;

public class GameDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public string Generation { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Developer { get; set; } = string.Empty;
    public string? Director { get; set; }
    public string Platform { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<ReviewDto> Reviews { get; set; } = new();
}

public class ReviewDto
{
    public int Id { get; set; }
    public int GameId { get; set; }
    public string ReviewerName { get; set; } = string.Empty;
    public double Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
}

public class CreateGameDto
{
    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required]
    [StringLength(50)]
    public string Generation { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Region { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Developer { get; set; } = string.Empty;

    [StringLength(50)]
    public string? Director { get; set; }

    [Required]
    [StringLength(50)]
    public string Platform { get; set; } = string.Empty;

    [Required]
    [StringLength(500)]
    public string Description { get; set; } = string.Empty;
}