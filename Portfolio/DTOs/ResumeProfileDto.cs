using Portfolio.Dashboard.Get.DTOs;

namespace Portfolio.DTOs;

public class ResumeProfileDto
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
    
    public List<HomeFeedbackDto> Feedbacks { get; init; } = null!;
    public List<GetCertificationDto> Certifications { get; init; } = null!;
}