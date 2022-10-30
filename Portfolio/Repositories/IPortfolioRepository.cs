using Fathy.Common.Startup;
using Portfolio.DTOs;

namespace Portfolio.Repositories;

public interface IPortfolioRepository
{
    Task<Response<AboutPageDto>> AboutAsync(int resumeId);
    Task<Response> AddFeedbackAsync(PostFeedbackDto postFeedbackDto);
    Task<Response> AddProjectRequestAsync(PostProjectRequestDto postProjectRequestDto);
    Task<Response<HomePageDto>> HomeAsync(int resumeId);
    Task<Response<ProjectPageDto>> ProjectAsync(int resumeId, int category, int type);
    Task<Response<ResumePageDto>> ResumeAsync(int resumeId);
    
}