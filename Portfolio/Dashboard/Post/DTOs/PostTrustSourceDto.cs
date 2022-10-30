using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostTrustSourceDto
{
    [Required, EmailAddress] public string ProfileModelEmail { get; set; } = null!;
    
    [Required] public string Url { get; init; } = null!;
    [Required] public IFormFile ImageFile { get; init; } = null!;
}