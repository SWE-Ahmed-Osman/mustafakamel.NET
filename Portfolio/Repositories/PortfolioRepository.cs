using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portfolio.Database;
using Portfolio.DTOs;
using Portfolio.Utilities;

namespace Portfolio.Repositories;

public class PortfolioRepository : IPortfolioRepository
{
    private readonly IMapper _mapper;
    private readonly IPortfolioContext _portfolioContext;

    public PortfolioRepository(IMapper mapper, IPortfolioContext portfolioContext)
    {
        _mapper = mapper;
        _portfolioContext = portfolioContext;
    }
    
    public async Task<Response<HomePageDto>> HomeAsync(string language)
    {
        var mustafa = await _portfolioContext.Mustafa
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Location)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Projects)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Company)
            .Include(mustafa => mustafa.Feedbacks)
            .Include(mustafa => mustafa.TrustedBy)
            .SingleOrDefaultAsync(mustafa => mustafa.Id == 1);

        var resume = language.ToLower() switch
        {
            "en" => mustafa!.Resumes.Last(),
            _ => mustafa!.Resumes.First()
        };

        var homePageDto = new HomePageDto
        {
            Mustafa = _mapper.Map<HomeMustafaDto>(mustafa)
        };
        homePageDto.Mustafa.Resume = _mapper.Map<HomeResumeDto>(resume);
        
        return ResponseFactory.Ok(homePageDto);
    }
    
    public async Task<Response<AboutPageDto>> AboutAsync(string language)
    {
        var mustafa = await _portfolioContext.Mustafa
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Location)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Projects)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Company)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Job)
            .Include(mustafa => mustafa.Feedbacks)
            .Include(mustafa => mustafa.TrustedBy)
            .Include(mustafa => mustafa.Certifications)
            .SingleOrDefaultAsync(mustafa => mustafa.Id == 1);

        var resume = language.ToLower() switch
        {
            "en" => mustafa!.Resumes.Last(),
            _ => mustafa!.Resumes.First()
        };

        var aboutPageDto = new AboutPageDto
        {
            Mustafa = _mapper.Map<AboutMustafaDto>(mustafa)
        };
        aboutPageDto.Mustafa.Resume = _mapper.Map<AboutResumeDto>(resume);
        
        return ResponseFactory.Ok(aboutPageDto);
    }
    
    public async Task<Response<ResumePageDto>> ResumeAsync(string language)
    {
        var mustafa = await _portfolioContext.Mustafa
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Skills)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Languages)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Company)
            .ThenInclude(company => company.Location)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Job)
            .Include(mustafa => mustafa.Resumes)
            .ThenInclude(resume => resume.Educations)
            .ThenInclude(education => education.School)
            .ThenInclude(company => company.Location)
            .Include(mustafa => mustafa.Feedbacks)
            .Include(mustafa => mustafa.Certifications)
            .SingleOrDefaultAsync(mustafa => mustafa.Id == 1);

        var resume = language.ToLower() switch
        {
            "en" => mustafa!.Resumes.Last(),
            _ => mustafa!.Resumes.First()
        };

        var resumePageDto = new ResumePageDto()
        {
            Mustafa = _mapper.Map<ResumeMustafaDto>(mustafa)
        };
        resumePageDto.Mustafa.Resume = _mapper.Map<ResumeResumeDto>(resume);
        
        return ResponseFactory.Ok(resumePageDto);
    }
}