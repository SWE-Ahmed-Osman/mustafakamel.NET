using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class FeedbackModel
{
    [Key] public int Id { get; init; }
    [EmailAddress] public string ProfileModelEmail { get; set; } = null!;

    public string Description { get; set; } = null!;
    [StringLength(50)] public string Name { get; set; } = null!;
    [StringLength(100)] public string Title { get; set; } = null!;
    
    public Feeling? Feeling { get; set; }
    
    public string? ImageName { get; set; }
    public string? ImageUrl { get; set; }
    
    public bool View { get; set; }
    public bool Workmate { get; set; }
}

public enum Feeling
{
    Happy,
    Serious,
    Diligent,
    Friendly,
    Intelligent,
    NotGood
}