using Portfolio.Dashboard.Get.DTOs;

namespace Portfolio.DTOs;

public class HomeProfileDto
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

    public HomeResumeDto Resume { get; set; } = null!;
    
    public List<HomeFeedbackDto> Feedbacks { get; init; } = null!;
    public List<GetTrustSourceDto> TrustSources { get; init; } = null!;
}