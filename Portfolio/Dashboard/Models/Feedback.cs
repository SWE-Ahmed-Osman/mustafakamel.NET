using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Feedback
{
    [Key] public int Id { get; init; }
    
    [StringLength(61)] public string Name { get; set; } = null!;
    [StringLength(50)] public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public Feeling? Feeling { get; set; }
    public string? ImageUrl { get; set; }
    
    public bool Workmate { get; set; }
    public bool IsWorkmate() => Workmate;
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