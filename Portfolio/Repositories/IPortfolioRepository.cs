using Portfolio.DTOs;
using Portfolio.Utilities;

namespace Portfolio.Repositories;

public interface IPortfolioRepository
{
    Task<Response<HomePageDto>> HomeAsync(string language);
    Task<Response<AboutPageDto>> AboutAsync(string language);
    Task<Response<ResumePageDto>> ResumeAsync(string language);
}