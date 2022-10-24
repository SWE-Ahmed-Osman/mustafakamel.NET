using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class TrustedBy
{
    [Key] public int Id { get; init; }

    public string Url { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}