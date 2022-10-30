using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostProjectDto
{
    [Required] public int ResumeModelId { get; init; }
    
    [Required] public int Type { get; init; }
    [Required] public int Category { get; init; }
    [Required] public bool ForSale { get; init; }
    [Required] public double Price { get; init; }
    [Required] public bool LastProject { get; init; }
    [Required] public string Description { get; init; } = null!;
    [Required, StringLength(100)] public string Name { get; init; } = null!;
    
    [Required] public string BehanceUrl { get; init; } = null!;
    [Required] public string DribbbleUrl { get; init; } = null!;

    [Required] public IFormFile DarkImageFile { get; init; } = null!;
    [Required] public IFormFile LightImageFile { get; init; } = null!;
    
    [Required] public IFormFile DarkPdfFile { get; init; } = null!;
    [Required] public IFormFile LightPdfFile { get; init; } = null!;

    [Required] public DateTime StartDate { get; init; }
    [Required] public DateTime? EndDate { get; init; }
}