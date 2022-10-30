using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class ProjectRequestModel
{
    [Key] public int Id { get; init; }
    [EmailAddress] public string ProfileModelEmail { get; set; } = null!;
    
    [EmailAddress] public string Email { get; set; } = null!;
    [StringLength(50)] public string Name { get; set; } = null!;
    
    public ProjectType Type { get; set; }
    public ProjectCategory Category { get; set; }
    public string Description { get; set; } = null!;
    
    public BudgetType Budget { get; set; }
    public TimelineType Timeline { get; set; }

    public string PdfName { get; set; } = null!;
    public string PdfUrl { get; set; } = null!;
}

public enum BudgetType
{
    LessThan1000,
    From1000To2000,
    From2100To3000,
    From3100To4000,
    MoreThan4000
}

public enum TimelineType
{
    OneMonth,
    From2To3Months,
    From4To5Months,
    From6To7Months,
    MoreThan7Months
}