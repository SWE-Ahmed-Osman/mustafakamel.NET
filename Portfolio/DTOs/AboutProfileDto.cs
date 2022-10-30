using Portfolio.Dashboard.Get.DTOs;

namespace Portfolio.DTOs;

public class AboutProfileDto
{
    public string Email { get; init; } = null!;
    
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
    
    public List<GetImageDto> Images { get; init; } = null!;
    public List<GetTrustSourceDto> TrustSources { get; init; } = null!;
    public List<AboutCertificationDto> Certifications { get; init; } = null!;
}