using AutoMapper;
using Fathy.Common.Startup;
using Fathy.Common.Storage;
using Microsoft.EntityFrameworkCore;
using Portfolio.Dashboard.Get.DTOs;
using Portfolio.Database;
using Portfolio.Database.Models;
using Portfolio.DTOs;

namespace Portfolio.Repositories;

public class PortfolioRepository : IPortfolioRepository
{
    private readonly IMapper _mapper;
    private readonly IBlobRepository _blobRepository;
    private readonly IPortfolioContext _portfolioContext;

    public PortfolioRepository(IMapper mapper, IBlobRepository blobRepository, IPortfolioContext portfolioContext)
    {
        _mapper = mapper;
        _blobRepository = blobRepository;
        _portfolioContext = portfolioContext;
    }
    
    public async Task<Response<AboutPageDto>> AboutAsync(string language)
    {
        var profile = await _portfolioContext.Profile.AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Projects).AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Company).AsNoTracking()
            .Include(profile => profile.Feedbacks).AsNoTracking()
            .Include(profile => profile.TrustSources).AsNoTracking()
            .Include(profile => profile.Certifications).AsNoTracking()
            .FirstAsync();

        var aboutPageDto = new AboutPageDto
        {
            Profile = _mapper.Map<AboutProfileDto>(profile)
        };
        var resumeId = language == "ar" ? 1 : 2;
        aboutPageDto.Profile.Resume =
            _mapper.Map<AboutResumeDto>(profile.Resumes.SingleOrDefault(resume => resume.Id == resumeId));

        return ResponseFactory.Ok(aboutPageDto);
    }
    
    public async Task<Response> AddFeedbackAsync(PostFeedbackDto postFeedbackDto)
    {
        var feedback = _mapper.Map<FeedbackModel>(postFeedbackDto);

        if (postFeedbackDto.ImageFile is not null)
        {
            var imageName = Guid.NewGuid().ToString();
            
            try
            {
                feedback.ImageUrl = await _blobRepository.UploadBlobAsync(imageName, postFeedbackDto.ImageFile);
                feedback.ImageName = imageName;
            }
            catch (Exception e)
            {
                feedback.ImageUrl = e.Message;
                feedback.ImageName = imageName;
            }
        }

        await _portfolioContext.Feedback.AddAsync(feedback);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> AddProjectRequestAsync(PostProjectRequestDto postProjectRequestDto)
    {
        var projectRequest = _mapper.Map<ProjectRequestModel>(postProjectRequestDto);

        var pdfName = Guid.NewGuid().ToString();

        try
        {
            projectRequest.PdfUrl = await _blobRepository.UploadBlobAsync(pdfName, postProjectRequestDto.PdfFile);
            projectRequest.PdfName = pdfName;
        }
        catch (Exception e)
        {
            projectRequest.PdfUrl = e.Message;
            projectRequest.PdfName = pdfName;
        }

        await _portfolioContext.ProjectRequest.AddAsync(projectRequest);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }
    
    public async Task<Response<HomePageDto>> HomeAsync(string language)
    {
        var profile = await _portfolioContext.Profile.AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Projects).AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Company).AsNoTracking()
            .Include(profile => profile.Feedbacks).AsNoTracking()
            .Include(profile => profile.TrustSources).AsNoTracking()
            .FirstAsync();

        var homePageDto = new HomePageDto
        {
            Profile = _mapper.Map<HomeProfileDto>(profile)
        };
        var resumeId = language == "ar" ? 1 : 2;
        homePageDto.Profile.Resume =
            _mapper.Map<HomeResumeDto>(profile.Resumes.SingleOrDefault(resume => resume.Id == resumeId));
        
        return ResponseFactory.Ok(homePageDto);
    }

    public async Task<Response<ProjectPageDto>> ProjectAsync(string language, int category, int? type)
    {
        var profile = await _portfolioContext.Profile.AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Projects).AsNoTracking()
            .FirstAsync();
        
        var resumeId = language == "ar" ? 1 : 2;
        var resume = profile.Resumes.SingleOrDefault(resume => resume.Id == resumeId);
        
        var projectPageDto = new ProjectPageDto
        {
            Profile = _mapper.Map<ProjectProfileDto>(profile)
        };
        projectPageDto.Profile.Resume.SpecificProjects = type is null
            ? resume!.Projects.Where(project => (int)project.Category == category)
                .Select(project => _mapper.Map<GetProjectDto>(project)).ToList()
            : resume!.Projects.Where(project => (int)project.Category == category && (int)project.Type == type)
                .Select(project => _mapper.Map<GetProjectDto>(project)).ToList();

        return ResponseFactory.Ok(projectPageDto);
    }

    public async Task<Response<ResumePageDto>> ResumeAsync(string language)
    {
        var profile = await _portfolioContext.Profile.AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Skills).AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Languages).AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Experiences)
            .ThenInclude(experience => experience.Company).AsNoTracking()
            .Include(profile => profile.Resumes)
            .ThenInclude(resume => resume.Educations)
            .ThenInclude(education => education.School).AsNoTracking()
            .Include(profile => profile.Feedbacks).AsNoTracking()
            .Include(profile => profile.Certifications).AsNoTracking()
            .FirstAsync();

        var resumePageDto = new ResumePageDto
        {
            Profile = _mapper.Map<ResumeProfileDto>(profile)
        };
        var resumeId = language == "ar" ? 1 : 2;
        resumePageDto.Profile.Resume =
            _mapper.Map<ResumeResumeDto>(profile.Resumes.SingleOrDefault(resume => resume.Id == resumeId));

        return ResponseFactory.Ok(resumePageDto);
    }
}