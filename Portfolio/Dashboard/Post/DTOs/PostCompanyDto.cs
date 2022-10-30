using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostCompanyDto
{
    [Required] public string Url { get; init; } = null!;
    [Required, StringLength(50)] public string Name { get; init; } = null!;
    [Required, StringLength(50)] public string Location { get; init; } = null!;
}