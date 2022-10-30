using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Update.DTOs;

public class UpdateProfileDto
{
    [Required, EmailAddress] public string Email { get; init; } = null!;
    
    [Required] public string BehanceUrl { get; init; } = null!;
    [Required] public string DribbbleUrl { get; init; } = null!;
    [Required] public string LinkedInUrl { get; init; } = null!;
    [Required] public string MediumUrl { get; init; } = null!;
    [Required] public string InstagramUrl { get; init; } = null!;
    [Required] public string TwitterUrl { get; init; } = null!;
    [Required] public string FacebookUrl { get; init; } = null!;

    [Required] public int YearsOfExperience { get; init; }
}