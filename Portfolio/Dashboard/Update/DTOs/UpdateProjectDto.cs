using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Update.DTOs;

public class UpdateProjectDto
{
    [Required] public int Id { get; init; }
    
    [Required] public int Type { get; init; }
    [Required] public int Category { get; init; }
    [Required] public bool ForSale { get; init; }
    [Required] public double Price { get; init; }
    [Required] public string Description { get; init; } = null!;
    [Required, StringLength(100)] public string Name { get; init; } = null!;
    
    [Required] public string BehanceUrl { get; init; } = null!;
    [Required] public string DribbbleUrl { get; init; } = null!;

    [Required] public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}