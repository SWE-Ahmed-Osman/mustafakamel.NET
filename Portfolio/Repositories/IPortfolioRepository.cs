using Fathy.Common.Startup;
using Portfolio.DTOs;

namespace Portfolio.Repositories;

public interface IPortfolioRepository
{
    Task<Response<AboutPageDto>> AboutAsync(string language);
    Task<Response> AddFeedbackAsync(PostFeedbackDto postFeedbackDto);
    Task<Response> AddProjectRequestAsync(PostProjectRequestDto postProjectRequestDto);
    Task<Response<HomePageDto>> HomeAsync(string language);
    Task<Response<ProjectPageDto>> ProjectAsync(string language, int category, int? type);
    Task<Response<ResumePageDto>> ResumeAsync(string language);
}