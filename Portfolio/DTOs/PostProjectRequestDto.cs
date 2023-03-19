using System.ComponentModel.DataAnnotations;

namespace Portfolio.DTOs;

public class PostProjectRequestDto
{
    [Required, EmailAddress] public string ProfileModelEmail { get; init; } = null!;
    
    [Required, EmailAddress] public string Email { get; init; } = null!;
    [Required, StringLength(50)] public string Name { get; init; } = null!;
    
    [Required] public int Category { get; init; }
    [Required] public int Type { get; init; }
    [Required] public string Description { get; init; } = null!;
    
    [Required] public int Budget { get; init; }
    [Required] public int Timeline { get; init; }
    
    [Required] public IFormFile PdfFile { get; init; } = null!;
}