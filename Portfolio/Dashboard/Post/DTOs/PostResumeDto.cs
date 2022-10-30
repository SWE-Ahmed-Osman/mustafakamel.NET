using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostResumeDto
{
    [Required] public int Id { get; init; }
    
    [Required] public IFormFile ResumeFile { get; init; } = null!;
}