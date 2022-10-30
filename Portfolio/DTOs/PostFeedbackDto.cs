using System.ComponentModel.DataAnnotations;

namespace Portfolio.DTOs;

public class PostFeedbackDto
{
    [Required, EmailAddress] public string ProfileModelEmail { get; init; } = null!;
    
    [Required] public string Description { get; init; } = null!;
    [Required, StringLength(50)] public string Name { get; init; } = null!;
    [Required, StringLength(100)] public string Title { get; init; } = null!;
    
    public int? Feeling { get; init; }
    public IFormFile? ImageFile { get; init; }
}