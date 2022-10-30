using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class TrustSourceModel
{
    [Key] public int Id { get; init; }
    [EmailAddress] public string ProfileModelEmail { get; set; } = null!;
    
    public string Url { get; set; } = null!;

    public string ImageName { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}