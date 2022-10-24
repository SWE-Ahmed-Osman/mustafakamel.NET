using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Location
{
    [Key] public int Id { get; init; }
    
    [StringLength(30)] public string City { get; set; } = null!;
    [StringLength(30)] public string Country { get; set; } = null!;
}