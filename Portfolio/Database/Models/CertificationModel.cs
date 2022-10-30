using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class CertificationModel
{
    [Key] public int Id { get; init; }
    [EmailAddress] public string ProfileModelEmail { get; set; } = null!;

    public string Url { get; set; } = null!;
    public string FileName { get; set; } = null!;
    
    [StringLength(100)] public string Name { get; set; } = null!;
    [StringLength(50)] public string Issuer { get; set; } = null!;
}