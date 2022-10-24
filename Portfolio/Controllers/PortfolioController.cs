using Microsoft.AspNetCore.Mvc;
using Portfolio.DTOs;
using Portfolio.Repositories;
using Portfolio.Utilities;

namespace Portfolio.Controllers;

public class PortfolioController : ApiControllerBase
{
    private readonly IPortfolioRepository _portfolioRepository;
    
    public PortfolioController(IPortfolioRepository portfolioRepository)
    {
        _portfolioRepository = portfolioRepository;
    }
    
    [HttpGet("{language?}")]
    [ProducesResponseType(typeof(Response<HomePageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Home([FromRoute] string? language)
    {
        return ResponseToIActionResult(await _portfolioRepository.HomeAsync(language ?? string.Empty));
    }
    
    [HttpGet("{language?}")]
    [ProducesResponseType(typeof(Response<AboutPageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> About([FromRoute] string? language)
    {
        return ResponseToIActionResult(await _portfolioRepository.AboutAsync(language ?? string.Empty));
    }
    
    [HttpGet("{language?}")]
    [ProducesResponseType(typeof(Response<ResumePageDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(IEnumerable<Error>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Resume([FromRoute] string? language)
    {
        return ResponseToIActionResult(await _portfolioRepository.ResumeAsync(language ?? string.Empty));
    }
}