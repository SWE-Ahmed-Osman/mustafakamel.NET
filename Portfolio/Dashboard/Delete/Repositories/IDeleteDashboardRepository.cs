using Fathy.Common.Startup;

namespace Portfolio.Dashboard.Delete.Repositories;

public interface IDeleteDashboardRepository
{
    Task<Response> CertificationAsync(int certificationId);
    Task<Response> EducationAsync(int educationId);
    Task<Response> ExperienceAsync(int experienceId);
    Task<Response> ImageAsync(int imageId);
    Task<Response> LanguageAsync(int languageId);
    Task<Response> ProjectAsync(int projectId);
    Task<Response> SkillAsync(int skillId);
    Task<Response> TrustSourceAsync(int trustSourceId);
    Task<Response> VideoAsync();
}