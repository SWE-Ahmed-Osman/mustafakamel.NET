using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Mustafa
{
    [Key] public int Id { get; init; }
    
    [EmailAddress] public string Email { get; set; } = null!;
    
    public string ImageUrl { get; set; } = null!;
    public string VideoUrl { get; set; } = null!;
    public string ResumeUrl { get; set; } = null!;
    
    public string BehanceUrl { get; set; } = null!;
    public string DribbbleUrl { get; set; } = null!;
    public string LinkedInUrl { get; set; } = null!;
    public string MediumUrl { get; set; } = null!;
    public string InstagramUrl { get; set; } = null!;
    public string TwitterUrl { get; set; } = null!;
    public string FacebookUrl { get; set; } = null!;

    public int YearsOfExperience { get; set; }

    public List<Resume> Resumes { get; } = new();
    public List<Feedback> Feedbacks { get; } = new();
    public List<TrustedBy> TrustedBy { get; } = new();
    public List<Certification> Certifications { get; } = new();
}