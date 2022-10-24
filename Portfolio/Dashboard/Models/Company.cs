using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Company
{
    [Key] public int Id { get; init; }
    
    public string Url { get; set; } = null!;
    public Location Location { get; set; } = null!;
    [StringLength(30)] public string Name { get; set; } = null!;
}