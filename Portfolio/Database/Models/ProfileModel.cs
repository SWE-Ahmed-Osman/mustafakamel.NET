using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class ProfileModel
{
    [Key, EmailAddress] public string Email { get; set; } = null!;

    public string VideoName { get; set; } = null!;
    public string VideoUrl { get; set; } = null!;
    
    public string BehanceUrl { get; set; } = null!;
    public string DribbbleUrl { get; set; } = null!;
    public string LinkedInUrl { get; set; } = null!;
    public string MediumUrl { get; set; } = null!;
    public string InstagramUrl { get; set; } = null!;
    public string TwitterUrl { get; set; } = null!;
    public string FacebookUrl { get; set; } = null!;

    public int YearsOfExperience { get; set; }

    public List<ImageModel> Images { get; set; } = null!;
    public List<ResumeModel> Resumes { get; } = new();
    public List<FeedbackModel> Feedbacks { get; } = new();
    public List<TrustSourceModel> TrustSources { get; } = new();
    public List<CertificationModel> Certifications { get; } = new();
    public List<ProjectRequestModel> ProjectRequests { get; } = new();
}