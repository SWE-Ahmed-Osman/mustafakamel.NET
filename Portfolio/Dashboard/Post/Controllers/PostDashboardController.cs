using Fathy.Common.Startup;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Dashboard.Get.DTOs;
using Portfolio.Dashboard.Post.DTOs;
using Portfolio.Dashboard.Post.Repositories;

namespace Portfolio.Dashboard.Post.Controllers;

// TODO: Authorize PostDashboardController.
// [Authorize(Roles = Roles.Admin)]
public class PostDashboardController : ApiControllerBase
{
    private readonly IPostDashboardRepository _postDashboardRepository;
    
    public PostDashboardController(IPostDashboardRepository postDashboardRepository)
    {
        _postDashboardRepository = postDashboardRepository;
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetCertificationDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Certification([FromForm] PostCertificationDto postCertificationDto) =>
        ResponseToIActionResult(await _postDashboardRepository.CertificationAsync(postCertificationDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetCompanyDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Company([FromBody] PostCompanyDto postCompanyDto) =>
        ResponseToIActionResult(await _postDashboardRepository.CompanyAsync(postCompanyDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetEducationDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Education([FromBody] PostEducationDto postEducationDto) =>
        ResponseToIActionResult(await _postDashboardRepository.EducationAsync(postEducationDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetExperienceDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Experience([FromBody] PostExperienceDto postExperienceDto) =>
        ResponseToIActionResult(await _postDashboardRepository.ExperienceAsync(postExperienceDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetImageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Image([FromForm] PostImageDto postImageDto) =>
        ResponseToIActionResult(await _postDashboardRepository.ImageAsync(postImageDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetLanguageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Language([FromBody] PostLanguageDto postLanguageDto) =>
        ResponseToIActionResult(await _postDashboardRepository.LanguageAsync(postLanguageDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetProjectDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Project([FromForm] PostProjectDto postProjectDto) =>
        ResponseToIActionResult(await _postDashboardRepository.ProjectAsync(postProjectDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetResumeDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Resume([FromForm] PostResumeDto postResumeDto) =>
        ResponseToIActionResult(await _postDashboardRepository.ResumeAsync(postResumeDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetSchoolDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> School([FromBody] PostSchoolDto postSchoolDto) =>
        ResponseToIActionResult(await _postDashboardRepository.SchoolAsync(postSchoolDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetSkillDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Skill([FromBody] PostSkillDto postSkillDto) =>
        ResponseToIActionResult(await _postDashboardRepository.SkillAsync(postSkillDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetTrustSourceDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> TrustSource([FromForm] PostTrustSourceDto postTrustSourceDto) =>
        ResponseToIActionResult(await _postDashboardRepository.TrustSourceAsync(postTrustSourceDto));
    
    [HttpPost]
    [ProducesResponseType(typeof(Response<GetProfileDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Video([FromForm] IFormFile videoFile) =>
        ResponseToIActionResult(await _postDashboardRepository.VideoAsync(videoFile));
}