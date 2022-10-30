using Fathy.Common.Startup;
using Fathy.Common.Storage;
using Microsoft.EntityFrameworkCore;
using Portfolio.Database;
using Portfolio.Database.Models;
using Portfolio.Utilities;

namespace Portfolio.Dashboard.Delete.Repositories;

public class DeleteDashboardRepository : IDeleteDashboardRepository
{
    private readonly IBlobRepository _blobRepository;
    private readonly IPortfolioContext _portfolioContext;

    public DeleteDashboardRepository(IBlobRepository blobRepository, IPortfolioContext portfolioContext)
    {
        _blobRepository = blobRepository;
        _portfolioContext = portfolioContext;
    }
    
    public async Task<Response> CertificationAsync(int certificationId)
    {
        var certification = await _portfolioContext.Certification.SingleOrDefaultAsync(certification =>
                certification.Id == certificationId);

        try
        {
            await _blobRepository.DeleteBlobAsync(certification!.FileName);
        }
        catch (Exception)
        {
            return ResponseFactory.Fail<Response>(ErrorsList.BlobNotFound(certification!.FileName));
        }
        
        _portfolioContext.Certification.Remove(certification);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> EducationAsync(int educationId)
    {
        _portfolioContext.Education.Remove(new EducationModel { Id = educationId });
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> ExperienceAsync(int experienceId)
    {
        _portfolioContext.Experience.Remove(new ExperienceModel { Id = experienceId });
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> ImageAsync(int imageId)
    {
        var image = await _portfolioContext.Image.SingleOrDefaultAsync(image => image.Id == imageId);

        try
        {
            await _blobRepository.DeleteBlobAsync(image!.Name);
        }
        catch (Exception)
        {
            return ResponseFactory.Fail<Response>(ErrorsList.BlobNotFound(image!.Name));
        }
        
        _portfolioContext.Image.Remove(image);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> LanguageAsync(int languageId)
    {
        _portfolioContext.Language.Remove(new LanguageModel { Id = languageId });
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> ProjectAsync(int projectId)
    {
        var project = await _portfolioContext.Project.SingleOrDefaultAsync(project => project.Id == projectId);

        try
        {
            await _blobRepository.DeleteBlobAsync(project!.DarkImageName);
            await _blobRepository.DeleteBlobAsync(project.LightImageName);
            
            await _blobRepository.DeleteBlobAsync(project.DarkPdfName);
            await _blobRepository.DeleteBlobAsync(project.LightPdfName);
        }
        catch (Exception)
        {
            return ResponseFactory.Fail<Response>(new[]
            {
                ErrorsList.BlobNotFound(project!.DarkImageName), ErrorsList.BlobNotFound(project.LightImageName),
                ErrorsList.BlobNotFound(project.DarkPdfName), ErrorsList.BlobNotFound(project.LightPdfName)
            });
        }
        
        _portfolioContext.Project.Remove(project);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> SkillAsync(int skillId)
    {
        _portfolioContext.Skill.Remove(new SkillModel { Id = skillId });
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> TrustSourceAsync(int trustSourceId)
    {
        var trustSource =
            await _portfolioContext.TrustSource.SingleOrDefaultAsync(trustSource => trustSource.Id == trustSourceId);

        try
        {
            await _blobRepository.DeleteBlobAsync(trustSource!.ImageName);
        }
        catch (Exception)
        {
            return ResponseFactory.Fail<Response>(ErrorsList.BlobNotFound(trustSource!.ImageName));
        }
        
        _portfolioContext.TrustSource.Remove(trustSource);
        return await _portfolioContext.SaveChangesAsync() == 0
            ? ResponseFactory.Fail<Response>()
            : ResponseFactory.Ok();
    }

    public async Task<Response> VideoAsync()
    {
        var profile = await _portfolioContext.Profile.FirstAsync();
        profile.VideoUrl = string.Empty;
        var videoName = profile.VideoName;
        profile.VideoName = string.Empty;
        
        try
        {
            await _blobRepository.DeleteBlobAsync(videoName);
            return await _portfolioContext.SaveChangesAsync() == 0
                ? ResponseFactory.Fail<Response>()
                : ResponseFactory.Ok();
        }
        catch (Exception)
        {
            return ResponseFactory.Fail<Response>(ErrorsList.BlobNotFound(videoName));
        }
    }
}