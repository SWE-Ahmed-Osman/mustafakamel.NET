using Fathy.Common.Startup;
using Microsoft.AspNetCore.Mvc;
using Portfolio.DTOs;
using Portfolio.Repositories;

namespace Portfolio.Controllers;

public class PortfolioController : ApiControllerBase
{
    private readonly IPortfolioRepository _portfolioRepository;
    
    public PortfolioController(IPortfolioRepository portfolioRepository)
    {
        _portfolioRepository = portfolioRepository;
    }
    
    [HttpGet("{language}")]
    [ProducesResponseType(typeof(Response<AboutPageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> About([FromRoute] string language) =>
        ResponseToIActionResult(await _portfolioRepository.AboutAsync(language));

    [HttpPost]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddFeedback([FromForm] PostFeedbackDto postFeedbackDto) =>
        ResponseToIActionResult(await _portfolioRepository.AddFeedbackAsync(postFeedbackDto));

    [HttpPost]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddProjectRequest([FromForm] PostProjectRequestDto postProjectRequestDto) =>
        ResponseToIActionResult(await _portfolioRepository.AddProjectRequestAsync(postProjectRequestDto));

    [HttpGet("{language}")]
    [ProducesResponseType(typeof(Response<HomePageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Home([FromRoute] string language) =>
        ResponseToIActionResult(await _portfolioRepository.HomeAsync(language));

    [HttpGet("{language}/{category:int:min(0):max(1)}")]
    [ProducesResponseType(typeof(Response<ProjectPageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Project([FromRoute] string language,
        [FromRoute] int category, [FromQuery] int? type) =>
        ResponseToIActionResult(await _portfolioRepository.ProjectAsync(language, category, type));

    [HttpGet("{language}")]
    [ProducesResponseType(typeof(Response<ResumePageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Resume([FromRoute] string language) =>
        ResponseToIActionResult(await _portfolioRepository.ResumeAsync(language));
}