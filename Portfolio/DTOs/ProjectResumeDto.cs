using Portfolio.Dashboard.Get.DTOs;

namespace Portfolio.DTOs;

public class ProjectResumeDto
{
    public List<GetProjectDto> SpecificProjects { get; set; } = null!;
}