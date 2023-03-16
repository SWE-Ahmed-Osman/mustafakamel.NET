using Fathy.Common.Startup;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Dashboard.Update.DTOs;
using Portfolio.Dashboard.Update.Repositories;

namespace Portfolio.Dashboard.Update.Controllers;

// TODO: Authorize UpdateDashboardController.
// [Authorize(Roles = Roles.Admin)]
public class UpdateDashboardController : ApiControllerBase
{
    private readonly IUpdateDashboardRepository _updateDashboardRepository;
    
    public UpdateDashboardController(IUpdateDashboardRepository updateDashboardRepository)
    {
        _updateDashboardRepository = updateDashboardRepository;
    }
    
    [HttpPut]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Education([FromBody] UpdateEducationDto updateEducationDto) =>
        ResponseToIActionResult(await _updateDashboardRepository.EducationAsync(updateEducationDto));
    
    [HttpPut]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Experience([FromBody] UpdateExperienceDto updateExperienceDto) =>
        ResponseToIActionResult(await _updateDashboardRepository.ExperienceAsync(updateExperienceDto));

    [HttpPut]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Feedback(
        [FromQuery] int feedbackId, [FromQuery] bool view, [FromQuery] bool workmate) =>
        ResponseToIActionResult(await _updateDashboardRepository.FeedbackAsync(feedbackId, view, workmate));
    
    [HttpPut]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Profile([FromBody] UpdateProfileDto updateProfileDto) =>
        ResponseToIActionResult(await _updateDashboardRepository.ProfileAsync(updateProfileDto));
    
    [HttpPut]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Project([FromBody] UpdateProjectDto updateProjectDto) =>
        ResponseToIActionResult(await _updateDashboardRepository.ProjectAsync(updateProjectDto));
    
    [HttpPut]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Resume([FromBody] UpdateResumeDto updateResumeDto) =>
        ResponseToIActionResult(await _updateDashboardRepository.ResumeAsync(updateResumeDto));

    [HttpPut]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Skill([FromBody] UpdateSkillDto updateSkillDto) =>
        ResponseToIActionResult(await _updateDashboardRepository.SkillAsync(updateSkillDto));
}