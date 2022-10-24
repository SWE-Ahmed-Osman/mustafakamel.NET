using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Certification
{
    [Key] public int Id { get; init; }
    
    public string Url { get; set; } = null!;
    public string Name { get; set; } = null!;
    [StringLength(30)] public string Issuer { get; set; } = null!;
}