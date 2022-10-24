using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Language
{
    [Key] public int Id { get; init; }
    
    [StringLength(30)] public string Name { get; set; } = null!;
}