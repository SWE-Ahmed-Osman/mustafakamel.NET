using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class SchoolModel
{
    [Key] public int Id { get; init; }
    
    public string Url { get; set; } = null!;
    [StringLength(50)] public string Name { get; set; } = null!;
    [StringLength(50)] public string Location { get; set; } = null!;
}