using Fathy.Common.Startup;
using Portfolio.Dashboard.Get.DTOs;
using Portfolio.Dashboard.Post.DTOs;

namespace Portfolio.Dashboard.Post.Repositories;

public interface IPostDashboardRepository
{
    Task<Response<GetCertificationDto>> CertificationAsync(PostCertificationDto postCertificationDto);
    Task<Response<GetCompanyDto>> CompanyAsync(PostCompanyDto postCompanyDto);
    Task<Response<GetEducationDto>> EducationAsync(PostEducationDto postEducationDto);
    Task<Response<GetExperienceDto>> ExperienceAsync(PostExperienceDto postExperienceDto);
    Task<Response<GetImageDto>> ImageAsync(PostImageDto postImageDto);
    Task<Response<GetLanguageDto>> LanguageAsync(PostLanguageDto postLanguageDto);
    Task<Response<GetProjectDto>> ProjectAsync(PostProjectDto postProjectDto);
    Task<Response<GetResumeDto>> ResumeAsync(PostResumeDto postResumeDto);
    Task<Response<GetSchoolDto>> SchoolAsync(PostSchoolDto postSchoolDto);
    Task<Response<GetSkillDto>> SkillAsync(PostSkillDto postSkillDto);
    Task<Response<GetTrustSourceDto>> TrustSourceAsync(PostTrustSourceDto postTrustSourceDto);
    Task<Response<GetProfileDto>> VideoAsync(IFormFile videoFile);
}