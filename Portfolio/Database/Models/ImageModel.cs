using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class ImageModel
{
    [Key] public int Id { get; init; }
    [EmailAddress] public string ProfileModelEmail { get; set; } = null!;
    
    public string Url { get; set; } = null!;
    public string Name { get; set; } = null!;
}