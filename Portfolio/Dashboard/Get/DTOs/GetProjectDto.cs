namespace Portfolio.Dashboard.Get.DTOs;

public class GetProjectDto
{
    public int Id { get; init; }
    
    public int Type { get; init; }
    public int Category { get; init; }
    public bool ForSale { get; init; }
    public double Price { get; init; }
    public string Description { get; init; } = null!;
    public string Name { get; init; } = null!;
    
    public string BehanceUrl { get; init; } = null!;
    public string DribbbleUrl { get; init; } = null!;

    public string DarkImageUrl { get; init; } = null!;
    public string LightImageUrl { get; init; } = null!;
    
    public string DarkPdfUrl { get; init; } = null!;
    public string LightPdfUrl { get; init; } = null!;

    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}