using Fathy.Common.Startup;
using Portfolio.Dashboard.Update.DTOs;

namespace Portfolio.Dashboard.Update.Repositories;

public interface IUpdateDashboardRepository
{
    Task<Response> EducationAsync(UpdateEducationDto updateEducationDto);
    Task<Response> ExperienceAsync(UpdateExperienceDto updateExperienceDto);
    Task<Response> FeedbackAsync(int feedbackId, bool view, bool workmate);
    Task<Response> ProfileAsync(UpdateProfileDto updateProfileDto);
    Task<Response> ProjectAsync(UpdateProjectDto updateProjectDto);
    Task<Response> ResumeAsync(UpdateResumeDto updateResumeDto);
    Task<Response> SkillAsync(UpdateSkillDto updateSkillDto);
}