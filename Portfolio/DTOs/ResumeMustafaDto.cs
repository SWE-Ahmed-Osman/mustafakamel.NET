using Portfolio.Dashboard.DTOs;

namespace Portfolio.DTOs;

public class ResumeMustafaDto
{
    public string Email { get; init; } = null!;
    
    public string BehanceUrl { get; init; } = null!;
    public string DribbbleUrl { get; init; } = null!;
    public string LinkedInUrl { get; init; } = null!;
    public string MediumUrl { get; init; } = null!;
    public string InstagramUrl { get; init; } = null!;
    public string TwitterUrl { get; init; } = null!;
    public string FacebookUrl { get; init; } = null!;

    public ResumeResumeDto Resume { get; set; } = null!;
    
    public List<FeedbackDto> Feedbacks { get; init; } = null!;
    public List<CertificationDto> Certifications { get; init; } = null!;
}