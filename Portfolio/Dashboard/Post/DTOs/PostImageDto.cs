using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostImageDto
{
    [Required, EmailAddress] public string ProfileModelEmail { get; init; } = null!;
    
    [Required] public IFormFile ImageFile { get; init; } = null!;
}