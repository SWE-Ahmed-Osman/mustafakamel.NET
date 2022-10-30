using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Database.Models;

namespace Portfolio.Database;

public class PortfolioContext : IdentityDbContext, IPortfolioContext
{
    public DbSet<CertificationModel> Certification => Set<CertificationModel>();
    public DbSet<CompanyModel> Company => Set<CompanyModel>();
    public DbSet<EducationModel> Education => Set<EducationModel>();
    public DbSet<ExperienceModel> Experience => Set<ExperienceModel>();
    public DbSet<FeedbackModel> Feedback => Set<FeedbackModel>();
    public DbSet<ImageModel> Image => Set<ImageModel>();
    public DbSet<LanguageModel> Language => Set<LanguageModel>();
    public DbSet<ProfileModel> Profile => Set<ProfileModel>();
    public DbSet<ProjectModel> Project => Set<ProjectModel>();
    public DbSet<ProjectRequestModel> ProjectRequest => Set<ProjectRequestModel>();
    public DbSet<ResumeModel> Resume => Set<ResumeModel>();
    public DbSet<SchoolModel> School => Set<SchoolModel>();
    public DbSet<SkillModel> Skill => Set<SkillModel>();
    public DbSet<TrustSourceModel> TrustSource => Set<TrustSourceModel>();

    public PortfolioContext(DbContextOptions option) : base(option)
    {
    }
}