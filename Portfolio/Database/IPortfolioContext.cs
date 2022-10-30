using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Portfolio.Database.Models;

namespace Portfolio.Database;

public interface IPortfolioContext
{
    DbSet<CertificationModel> Certification { get; }
    DbSet<CompanyModel> Company { get; }
    DbSet<EducationModel> Education { get; }
    DbSet<ExperienceModel> Experience { get; }
    DbSet<FeedbackModel> Feedback { get; }
    DbSet<ImageModel> Image { get; }
    DbSet<LanguageModel> Language { get; }
    DbSet<ProfileModel> Profile { get; }
    DbSet<ProjectModel> Project { get; }
    DbSet<ProjectRequestModel> ProjectRequest { get; }
    DbSet<ResumeModel> Resume { get; }
    DbSet<SchoolModel> School { get; }
    DbSet<SkillModel> Skill { get; }
    DbSet<TrustSourceModel> TrustSource { get; }
    
    int SaveChanges();
    DatabaseFacade Database { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}