using Fathy.Common.Startup;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Dashboard.Delete.Repositories;

namespace Portfolio.Dashboard.Delete.Controllers;

// TODO: Authorize DeleteDashboardController.
// [Authorize(Roles = Roles.Admin)]
public class DeleteDashboardController : ApiControllerBase
{
    private readonly IDeleteDashboardRepository _deleteDashboardRepository;

    public DeleteDashboardController(IDeleteDashboardRepository deleteDashboardRepository)
    {
        _deleteDashboardRepository = deleteDashboardRepository;
    }
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Certification([FromQuery] int certificationId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.CertificationAsync(certificationId));
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Education([FromQuery] int educationId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.EducationAsync(educationId));
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Experience([FromQuery] int experienceId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.ExperienceAsync(experienceId));
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Image([FromQuery] int imageId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.ImageAsync(imageId));
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Language([FromQuery] int languageId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.LanguageAsync(languageId));
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Project([FromQuery] int projectId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.ProjectAsync(projectId));
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Skill([FromQuery] int skillId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.SkillAsync(skillId));
    
    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> TrustSource([FromQuery] int trustSourceId) =>
        ResponseToIActionResult(await _deleteDashboardRepository.TrustSourceAsync(trustSourceId));

    [HttpDelete]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Video() => ResponseToIActionResult(await _deleteDashboardRepository.VideoAsync());
}