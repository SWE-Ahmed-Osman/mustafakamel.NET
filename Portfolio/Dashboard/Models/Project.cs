using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Project
{
    [Key] public int Id { get; init; }
    
    public string Name { get; set; } = null!;
    public ProjectType Type { get; set; }
    public string ImageUrl { get; set; } = null!;
    public bool ForSale { get; set; }

    public bool LastProject { get; set; }
    public bool IsLastProject() => LastProject;
}

public enum ProjectType
{
    CaseStudy,
    UiDesign,
    UxResearch,
    UxAnalytics,
    MobileApp,
    Website,
    MicroInteraction,
    Dashboard
}