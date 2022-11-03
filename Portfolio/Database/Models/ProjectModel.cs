using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class ProjectModel
{
    [Key] public int Id { get; init; }
    public int ResumeModelId { get; set; }

    public double Price { get; set; }
    public bool ForSale { get; set; }
    public bool LastProject { get; set; }
    public ProjectType Type { get; set; }
    public ProjectCategory Category { get; set; }
    public string Description { get; set; } = null!;
    [StringLength(100)] public string Name { get; set; } = null!;
    
    public string BehanceUrl { get; set; } = null!;
    public string DribbbleUrl { get; set; } = null!;

    public string DarkImageName { get; set; } = null!;
    public string DarkImageUrl { get; set; } = null!;
    
    public string LightImageName { get; set; } = null!;
    public string LightImageUrl { get; set; } = null!;
    
    public string DarkPdfName { get; set; } = null!;
    public string DarkPdfUrl { get; set; } = null!;
    
    public string LightPdfName { get; set; } = null!;
    public string LightPdfUrl { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}

public enum ProjectCategory
{
    UiDesign,
    CaseStudy
}

public enum ProjectType
{
    Website,
    Dashboard,
    MobileApp,
    MicroInteraction,
    UxResearch,
    UxAnalytics
}