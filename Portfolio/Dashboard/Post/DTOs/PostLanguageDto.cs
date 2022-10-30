using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostLanguageDto
{
    [Required] public int ResumeModelId { get; init; }
    
    [Required, StringLength(30)] public string Name { get; init; } = null!;
}