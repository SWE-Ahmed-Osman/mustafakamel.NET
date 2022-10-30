using AutoMapper;
using Fathy.Common.Startup;
using Microsoft.EntityFrameworkCore;
using Portfolio.Dashboard.Get.DTOs;
using Portfolio.Database;

namespace Portfolio.Dashboard.Get.Repositories;

public class GetDashboardRepository : IGetDashboardRepository
{
    private readonly IMapper _mapper;
    private readonly IPortfolioContext _portfolioContext;

    public GetDashboardRepository(IMapper mapper, IPortfolioContext portfolioContext)
    {
        _mapper = mapper;
        _portfolioContext = portfolioContext;
    }
    
    public async Task<Response<DashboardPageDto>> IndexAsync()
    {
        var profile = await _portfolioContext.Profile
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Skills)
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Projects)
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Languages)
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Educations)
            .ThenInclude(education => education.School)
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Company)
            .Include(profile => profile.Feedbacks)
            .Include(profile => profile.TrustSources)
            .Include(profile => profile.Certifications)
            .Include(profile => profile.ProjectRequests)
            .FirstAsync();

        var dashboardPageDto = new DashboardPageDto
        {
            Profile = _mapper.Map<GetProfileDto>(profile)
        };
        
        return ResponseFactory.Ok(dashboardPageDto);
    }
}