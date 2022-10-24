using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Experience
{
    [Key] public int Id { get; init; }
    
    public Job Job { get; set; } = null!;
    public Company Company { get; set; } = null!;
    
    public bool Main { get; set; }
    public bool IsMain() => Main;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}