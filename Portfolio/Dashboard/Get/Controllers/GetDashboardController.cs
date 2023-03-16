using Fathy.Common.Startup;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Dashboard.Get.DTOs;
using Portfolio.Dashboard.Get.Repositories;

namespace Portfolio.Dashboard.Get.Controllers;

// TODO: Authorize GetDashboardController.
// [Authorize(Roles = Roles.Admin)]
public class GetDashboardController : ApiControllerBase
{
    private readonly IGetDashboardRepository _getDashboardRepository;
    
    public GetDashboardController(IGetDashboardRepository getDashboardRepository)
    {
        _getDashboardRepository = getDashboardRepository;
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(Response<DashboardPageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Index() =>
        ResponseToIActionResult(await _getDashboardRepository.IndexAsync());
}