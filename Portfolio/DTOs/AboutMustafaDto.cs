using Portfolio.Dashboard.DTOs;

namespace Portfolio.DTOs;

public class AboutMustafaDto
{
    public string BehanceUrl { get; init; } = null!;
    public string DribbbleUrl { get; init; } = null!;
    public string LinkedInUrl { get; init; } = null!;
    public string MediumUrl { get; init; } = null!;
    public string InstagramUrl { get; init; } = null!;
    public string TwitterUrl { get; init; } = null!;
    public string FacebookUrl { get; init; } = null!;
    
    public int YearsOfExperience { get; init; }
    public int FeedbacksCount { get; init; }
    public AboutResumeDto Resume { get; set; } = null!;
    
    public List<TrustedByDto> TrustedBy { get; } = new();
    public List<AboutCertificationDto> Certifications { get; } = new();
}