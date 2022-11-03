using AutoMapper;
using Fathy.Common.Startup;
using Microsoft.EntityFrameworkCore;
using Portfolio.Dashboard.Update.DTOs;
using Portfolio.Database;
using Portfolio.Database.Models;

namespace Portfolio.Dashboard.Update.Repositories;

public class UpdateDashboardRepository : IUpdateDashboardRepository
{
    private readonly IMapper _mapper;
    private readonly IPortfolioContext _portfolioContext;

    public UpdateDashboardRepository(IMapper mapper, IPortfolioContext portfolioContext)
    {
        _mapper = mapper;
        _portfolioContext = portfolioContext;
    }

    public async Task<Response> EducationAsync(UpdateEducationDto updateEducationDto)
    {
        _portfolioContext.Education.Update(_mapper.Map<EducationModel>(updateEducationDto));
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }
    
    public async Task<Response> ExperienceAsync(UpdateExperienceDto updateExperienceDto)
    {
        _portfolioContext.Experience.Update(_mapper.Map<ExperienceModel>(updateExperienceDto));
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> FeedbackAsync(int feedbackId, bool view, bool workmate)
    {
        var feedback = await _portfolioContext.Feedback.SingleOrDefaultAsync(feedback => feedback.Id == feedbackId);
        
        feedback!.View = view;
        feedback.Workmate = workmate;

        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }
    
    public async Task<Response> ProfileAsync(UpdateProfileDto updateProfileDto)
    {
        var profile = await _portfolioContext.Profile.SingleOrDefaultAsync(profile => profile.Email == updateProfileDto.Email);

        profile!.BehanceUrl = updateProfileDto.BehanceUrl;
        profile.DribbbleUrl = updateProfileDto.DribbbleUrl;
        profile.LinkedInUrl = updateProfileDto.LinkedInUrl;
        profile.MediumUrl = updateProfileDto.MediumUrl;
        profile.InstagramUrl = updateProfileDto.InstagramUrl;
        profile.TwitterUrl = updateProfileDto.TwitterUrl;
        profile.FacebookUrl = updateProfileDto.FacebookUrl;
        profile.YearsOfExperience = updateProfileDto.YearsOfExperience;

        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> ProjectAsync(UpdateProjectDto updateProjectDto)
    {
        var project = await _portfolioContext.Project.SingleOrDefaultAsync(project => project.Id == updateProjectDto.Id);

        project!.Type = (ProjectType)updateProjectDto.Type;
        project.Category = (ProjectCategory)updateProjectDto.Category;
        project.ForSale = updateProjectDto.ForSale;
        project.Price = updateProjectDto.Price;
        project.Description = updateProjectDto.Description;
        project.Name = updateProjectDto.Name;
        project.BehanceUrl = updateProjectDto.BehanceUrl;
        project.DribbbleUrl = updateProjectDto.DribbbleUrl;
        project.StartDate = updateProjectDto.StartDate;
        project.EndDate = updateProjectDto.EndDate;

        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }
    
    public async Task<Response> ResumeAsync(UpdateResumeDto updateResumeDto)
    {
        var resume = await _portfolioContext.Resume.SingleOrDefaultAsync(resume => resume.Id == updateResumeDto.Id);

        resume!.About = updateResumeDto.About;
        resume.Location = updateResumeDto.Location;
        resume.Name = updateResumeDto.Name;
        resume.Title = updateResumeDto.Title;
        resume.TitleUrl = updateResumeDto.TitleUrl;
        
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }
    
    public async Task<Response> SkillAsync(UpdateSkillDto updateSkillDto)
    {
        _portfolioContext.Skill.Update(_mapper.Map<SkillModel>(updateSkillDto));
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }
}