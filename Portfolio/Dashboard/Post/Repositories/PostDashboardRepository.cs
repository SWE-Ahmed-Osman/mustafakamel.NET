using AutoMapper;
using Fathy.Common.Startup;
using Fathy.Common.Storage;
using Microsoft.EntityFrameworkCore;
using Portfolio.Dashboard.Get.DTOs;
using Portfolio.Dashboard.Post.DTOs;
using Portfolio.Database;
using Portfolio.Database.Models;

namespace Portfolio.Dashboard.Post.Repositories;

public class PostDashboardRepository : IPostDashboardRepository
{
    private readonly IMapper _mapper;
    private readonly IBlobRepository _blobRepository;
    private readonly IPortfolioContext _portfolioContext;

    public PostDashboardRepository(IMapper mapper, IBlobRepository blobRepository, IPortfolioContext portfolioContext)
    {
        _mapper = mapper;
        _blobRepository = blobRepository;
        _portfolioContext = portfolioContext;
    }
    
    public async Task<Response<GetCertificationDto>> CertificationAsync(PostCertificationDto postCertificationDto)
    {
        var certification = _mapper.Map<CertificationModel>(postCertificationDto);

        var fileName = Guid.NewGuid().ToString();
        
        try
        {
            certification.Url = await _blobRepository.UploadBlobAsync(fileName, postCertificationDto.File);
            certification.FileName = fileName;
        }
        catch (Exception e)
        {
            certification.Url = e.Message;
            certification.FileName = fileName;
        }

        await _portfolioContext.Certification.AddAsync(certification);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetCertificationDto>()
            : ResponseFactory.Ok(_mapper.Map<GetCertificationDto>(certification));
    }
    
    public async Task<Response<GetCompanyDto>> CompanyAsync(PostCompanyDto postCompanyDto)
    {
        var company = _mapper.Map<CompanyModel>(postCompanyDto);
        await _portfolioContext.Company.AddAsync(company);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetCompanyDto>()
            : ResponseFactory.Ok(_mapper.Map<GetCompanyDto>(company));
    }
    
    public async Task<Response<GetEducationDto>> EducationAsync(PostEducationDto postEducationDto)
    {
        var education = _mapper.Map<EducationModel>(postEducationDto);
        await _portfolioContext.Education.AddAsync(education);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetEducationDto>()
            : ResponseFactory.Ok(_mapper.Map<GetEducationDto>(education));
    }
    
    public async Task<Response<GetExperienceDto>> ExperienceAsync(PostExperienceDto postExperienceDto)
    {
        var experience = _mapper.Map<ExperienceModel>(postExperienceDto);
        await _portfolioContext.Experience.AddAsync(experience);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetExperienceDto>()
            : ResponseFactory.Ok(_mapper.Map<GetExperienceDto>(experience));
    }
    
    public async Task<Response<GetImageDto>> ImageAsync(PostImageDto postImageDto)
    {
        var image = _mapper.Map<ImageModel>(postImageDto);

        var imageName = Guid.NewGuid().ToString();
        
        try
        {
            image.Url = await _blobRepository.UploadBlobAsync(imageName, postImageDto.ImageFile);
            image.Name = imageName;
        }
        catch (Exception e)
        {
            image.Url = e.Message;
            image.Name = imageName;
        }

        await _portfolioContext.Image.AddAsync(image);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetImageDto>()
            : ResponseFactory.Ok(_mapper.Map<GetImageDto>(image));
    }
    
    public async Task<Response<GetLanguageDto>> LanguageAsync(PostLanguageDto postLanguageDto)
    {
        var language = _mapper.Map<LanguageModel>(postLanguageDto);
        await _portfolioContext.Language.AddAsync(language);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetLanguageDto>()
            : ResponseFactory.Ok(_mapper.Map<GetLanguageDto>(language));
    }
    
    public async Task<Response<GetProjectDto>> ProjectAsync(PostProjectDto postProjectDto)
    {
        var project = _mapper.Map<ProjectModel>(postProjectDto);

        var darkImageName = Guid.NewGuid().ToString();
        var lightImageName = Guid.NewGuid().ToString();
        var darkPdfName = Guid.NewGuid().ToString();
        var lightPdfName = Guid.NewGuid().ToString();

        try
        {
            project.DarkImageUrl = await _blobRepository.UploadBlobAsync(darkImageName, postProjectDto.DarkImageFile);
            project.DarkImageName = darkImageName;
            
            project.LightImageUrl = await _blobRepository.UploadBlobAsync(lightImageName, postProjectDto.LightImageFile);
            project.LightImageName = lightImageName;
            
            project.DarkPdfUrl = await _blobRepository.UploadBlobAsync(darkPdfName, postProjectDto.DarkPdfFile);
            project.DarkPdfName = darkPdfName;
            
            project.LightPdfUrl = await _blobRepository.UploadBlobAsync(lightPdfName, postProjectDto.LightPdfFile);
            project.LightPdfName = lightPdfName;
        }
        catch (Exception e)
        {
            project.DarkImageUrl = e.Message;
            project.DarkImageName = darkImageName;
            
            project.LightImageUrl = e.Message;
            project.LightImageName = lightImageName;
            
            project.DarkPdfUrl = e.Message;
            project.DarkPdfName = darkPdfName;
            
            project.LightPdfUrl = e.Message;
            project.LightPdfName = lightPdfName;
        }

        await _portfolioContext.Project.AddAsync(project);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetProjectDto>()
            : ResponseFactory.Ok(_mapper.Map<GetProjectDto>(project));
    }
    
    public async Task<Response<GetResumeDto>> ResumeAsync(PostResumeDto postResumeDto)
    {
        var resume = await _portfolioContext.Resume.SingleOrDefaultAsync(resume => resume.Id == postResumeDto.Id);

        var resumeName = Guid.NewGuid().ToString();

        try
        {
            resume!.ResumeUrl = await _blobRepository.UploadBlobAsync(resumeName, postResumeDto.ResumeFile);
            resume.ResumeName = resumeName;
        }
        catch (Exception e)
        {
            resume!.ResumeUrl = e.Message;
            resume.ResumeName = resumeName;
        }

        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetResumeDto>()
            : ResponseFactory.Ok(_mapper.Map<GetResumeDto>(resume));
    }
    
    public async Task<Response<GetSchoolDto>> SchoolAsync(PostSchoolDto postSchoolDto)
    {
        var school = _mapper.Map<SchoolModel>(postSchoolDto);
        await _portfolioContext.School.AddAsync(school);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetSchoolDto>()
            : ResponseFactory.Ok(_mapper.Map<GetSchoolDto>(school));
    }
    
    public async Task<Response<GetSkillDto>> SkillAsync(PostSkillDto postSkillDto)
    {
        var skill = _mapper.Map<SkillModel>(postSkillDto);
        await _portfolioContext.Skill.AddAsync(skill);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetSkillDto>()
            : ResponseFactory.Ok(_mapper.Map<GetSkillDto>(skill));
    }

    public async Task<Response<GetTrustSourceDto>> TrustSourceAsync(PostTrustSourceDto postTrustSourceDto)
    {
        var trustSource = _mapper.Map<TrustSourceModel>(postTrustSourceDto);

        var imageName = Guid.NewGuid().ToString();

        try
        {
            trustSource.ImageUrl = await _blobRepository.UploadBlobAsync(imageName, postTrustSourceDto.ImageFile);
            trustSource.ImageName = imageName;

        }
        catch (Exception e)
        {
            trustSource.ImageUrl = e.Message;
            trustSource.ImageName = imageName;
        }

        await _portfolioContext.TrustSource.AddAsync(trustSource);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetTrustSourceDto>()
            : ResponseFactory.Ok(_mapper.Map<GetTrustSourceDto>(trustSource));
    }
    
    public async Task<Response<GetProfileDto>> VideoAsync(IFormFile videoFile)
    {
        var profile = await _portfolioContext.Profile.FindAsync();

        var videoName = Guid.NewGuid().ToString();
        
        try
        {
            profile!.VideoUrl = await _blobRepository.UploadBlobAsync(videoName, videoFile);
            profile.VideoName = videoName;
        }
        catch (Exception e)
        {
            profile!.VideoUrl  = e.Message;
            profile.VideoName = videoName;
        }
        
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<GetProfileDto>()
            : ResponseFactory.Ok(_mapper.Map<GetProfileDto>(profile));
    }
}