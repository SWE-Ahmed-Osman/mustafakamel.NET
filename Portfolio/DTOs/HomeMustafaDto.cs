using Portfolio.Dashboard.DTOs;

namespace Portfolio.DTOs;

public class HomeMustafaDto
{
    public string VideoUrl { get; init; } = null!;
    
    public string BehanceUrl { get; init; } = null!;
    public string DribbbleUrl { get; init; } = null!;
    public string LinkedInUrl { get; init; } = null!;
    public string MediumUrl { get; init; } = null!;
    public string InstagramUrl { get; init; } = null!;
    public string TwitterUrl { get; init; } = null!;
    public string FacebookUrl { get; init; } = null!;

    public HomeResumeDto Resume { get; set; } = null!;
    
    public List<TrustedByDto> TrustedBy { get; } = new();
    public List<FeedbackDto> Feedbacks { get; } = new();
}