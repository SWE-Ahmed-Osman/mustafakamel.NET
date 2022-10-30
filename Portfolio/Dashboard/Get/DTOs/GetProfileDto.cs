namespace Portfolio.Dashboard.Get.DTOs;

public class GetProfileDto
{
    public string Email { get; init; } = null!;
    
    public string VideoUrl { get; init; } = null!;
    
    public string BehanceUrl { get; init; } = null!;
    public string DribbbleUrl { get; init; } = null!;
    public string LinkedInUrl { get; init; } = null!;
    public string MediumUrl { get; init; } = null!;
    public string InstagramUrl { get; init; } = null!;
    public string TwitterUrl { get; init; } = null!;
    public string FacebookUrl { get; init; } = null!;

    public int YearsOfExperience { get; init; }

    public List<GetImageDto> Images { get; init; } = null!;
    public List<GetResumeDto> Resumes { get; init; } = null!;
    public List<GetFeedbackDto> Feedbacks { get; init; } = null!;
    public List<GetTrustSourceDto> TrustSources { get; init; } = null!;
    public List<GetCertificationDto> Certifications { get; init; } = null!;
    public List<GetProjectRequestDto> ProjectRequests { get; init; } = null!;
}