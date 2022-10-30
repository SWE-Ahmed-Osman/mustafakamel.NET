using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostCertificationDto
{
    [Required, EmailAddress] public string ProfileModelEmail { get; set; } = null!;
    
    [Required] public IFormFile File { get; init; } = null!;
    [Required, StringLength(100)] public string Name { get; init; } = null!;
    [Required, StringLength(50)] public string Issuer { get; init; } = null!;
}