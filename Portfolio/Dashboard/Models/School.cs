using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class School
{
    [Key] public int Id { get; init; }
    
    public string Url { get; set; } = null!;
    public Location Location { get; set; } = null!;
    [StringLength(50)] public string Name { get; set; } = null!;
}