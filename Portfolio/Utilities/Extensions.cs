using Portfolio.Database;
using Portfolio.Database.Models;

namespace Portfolio.Utilities;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        var portfolioContext = host.Services.CreateScope().ServiceProvider.GetRequiredService<IPortfolioContext>();
        portfolioContext.Database.EnsureCreated();
        portfolioContext.InitializeDb();
    }

    private static void InitializeDb(this IPortfolioContext portfolioContext)
    {
        if (portfolioContext.Profile.Any()) return;

        portfolioContext.Profile.Add(new ProfileModel
        {
            Email = "mkamel733@gmail.com",
            VideoName = "#",
            VideoUrl = "#",
            BehanceUrl = "#",
            DribbbleUrl = "#",
            LinkedInUrl = "#",
            MediumUrl = "#",
            InstagramUrl = "#",
            TwitterUrl = "#",
            FacebookUrl = "#",
            YearsOfExperience = 3
        });

        portfolioContext.Resume.AddRange(new ResumeModel
        {
            ProfileModelEmail = "mkamel733@gmail.com",
            Name = "مصطفى كامل",
            Title = "تجربة",
            TitleUrl = "#",
            ResumeName = "#",
            ResumeUrl = "#",
            Location = "أسيوط، مصر",
            About = "تجربة"
        }, new ResumeModel
        {
            ProfileModelEmail = "mkamel733@gmail.com",
            Name = "Mustafa Kamel",
            Title = "Test",
            TitleUrl = "#",
            ResumeName = "#",
            ResumeUrl = "#",
            Location = "Assiut, Egypt",
            About = "Test"
        });
        
        // mustafa.Resumes.Last().Skills.AddRange(new []
        // {
        //     new SkillModel
        //     {
        //         Name = "Test 1",
        //         Type = SkillType.Soft
        //     },
        //     new SkillModel
        //     {
        //         Name = "Test 2",
        //         Type = SkillType.Hard
        //     },
        //     new SkillModel
        //     {
        //         Name = "Test 3",
        //         Type = SkillType.KnowledgeBased
        //     }
        // });
        //
        // mustafa.Resumes.Last().Projects.AddRange(new []
        // {
        //     new ProjectModel
        //     {
        //         Name = "Test 1",
        //         Description = "Test 1",
        //         Category = ProjectCategory.UiDesign,
        //         Type = ProjectType.MobileApp,
        //         BehanceUrl = "#",
        //         DribbbleUrl = "#",
        //         LightImageUrl = "#",
        //         DarkImageUrl = "#",
        //         LightPdfUrl = "#",
        //         DarkPdfUrl = "#",
        //         StartDate = DateTime.Now,
        //         ForSale = true,
        //         LastProject = true
        //     },
        //     new ProjectModel
        //     {
        //         Name = "Test 2",
        //         Description = "Test 2",
        //         Category = ProjectCategory.CaseStudy,
        //         Type = ProjectType.UxResearch,
        //         BehanceUrl = "#",
        //         DribbbleUrl = "#",
        //         LightImageUrl = "#",
        //         DarkImageUrl = "#",
        //         LightPdfUrl = "#",
        //         DarkPdfUrl = "#",
        //         StartDate = DateTime.Now,
        //         ForSale = false,
        //         LastProject = false
        //     },
        //     new ProjectModel
        //     {
        //         Name = "Test 3",
        //         Description = "Test 3",
        //         Category = ProjectCategory.UiDesign,
        //         Type = ProjectType.Dashboard,
        //         BehanceUrl = "#",
        //         DribbbleUrl = "#",
        //         LightImageUrl = "#",
        //         DarkImageUrl = "#",
        //         LightPdfUrl = "#",
        //         DarkPdfUrl = "#",
        //         StartDate = DateTime.Now,
        //         ForSale = false,
        //         LastProject = true
        //     }
        // });
        //
        // mustafa.Resumes.Last().Languages.AddRange(new []
        // {
        //     new LanguageModel
        //     {
        //         Name = "Arabic"
        //     },
        //     new LanguageModel
        //     {
        //         Name = "English"
        //     }
        // });
        //
        // mustafa.Resumes.Last().Educations.AddRange(new []
        // {
        //     new EducationModel
        //     {
        //         Grade = 3.1,
        //         Degree = "Test 1",
        //         StartDate = DateTime.Now,
        //         School = new SchoolModel
        //         {
        //             Name = "Assiut University",
        //             Location = "Assiut, Egypt",
        //             Url = "#"
        //         }
        //     },
        //     new EducationModel
        //     {
        //         Grade = 3.2,
        //         Degree = "Test 2",
        //         StartDate = DateTime.UtcNow,
        //         School = new SchoolModel
        //         {
        //             Name = "Cairo University",
        //             Location = "Cairo, Egypt",
        //             Url = "#"
        //         }
        //     }
        // });
        //
        // mustafa.Resumes.Last().Experiences.AddRange(new []
        // {
        //     new ExperienceModel
        //     {
        //         Title = "Test 1",
        //         Type = EmploymentType.FullTime,
        //         Company = new CompanyModel
        //         {
        //             Name = "Test 1",
        //             Location = "Assiut, Egypt",
        //             Url = "#"
        //         },
        //         Main = true,
        //         StartDate = DateTime.UtcNow
        //     },
        //     new ExperienceModel
        //     {
        //         Title = "Test 2",
        //         Type = EmploymentType.PartTime,
        //         Company = new CompanyModel
        //         {
        //             Name = "Test 2",
        //             Location = "Cairo, Egypt",
        //             Url = "#"
        //         },
        //         Main = false,
        //         StartDate = DateTime.UtcNow
        //     }
        // });
        //
        // mustafa.Certifications.AddRange(new []
        // {
        //     new CertificationModel
        //     {
        //         Url = "#",
        //         Name = "Test 1",
        //         Issuer = "Test 1"
        //     },
        //     new CertificationModel
        //     {
        //         Url = "#",
        //         Name = "Test 2",
        //         Issuer = "Test 2"
        //     }
        // });
        //
        // mustafa.Feedbacks.AddRange(new []
        // {
        //     new FeedbackModel
        //     {
        //         Name = "Test 1",
        //         Title = "Test 1",
        //         Workmate = true,
        //         Description = "Test 1"
        //     },
        //     new FeedbackModel
        //     {
        //         Name = "Test 2",
        //         Title = "Test 2",
        //         Workmate = false,
        //         Description = "Test 2"
        //     }
        // });
        //
        // mustafa.TrustSources.AddRange(new []
        // {
        //     new TrustSourceModel
        //     {
        //         Url = "#",
        //         ImageUrl = "#"
        //     },
        //     new TrustSourceModel
        //     {
        //         Url = "#",
        //         ImageUrl = "#"
        //     }
        // });
        //
        // mustafa.ProjectRequests.AddRange(new []
        // {
        //     new ProjectRequestModel
        //     {
        //         Email = "ahmed.fathy.dev@gmail.com",
        //         Name = "Ahmed Fathy",
        //         Description = "Test 1",
        //         Category = ProjectCategory.UiDesign,
        //         Type = ProjectType.Website,
        //         Budget = BudgetType.From2100To3000,
        //         Timeline= TimelineType.From2To3Months,
        //         PdfUrl= "#"
        //     },
        //     new ProjectRequestModel
        //     {
        //         Email = "ahmed.fathy.dev@gmail.com",
        //         Name = "Ahmed Fathy",
        //         Description = "Test 2",
        //         Category = ProjectCategory.UiDesign,
        //         Type = ProjectType.MicroInteraction,
        //         Budget = BudgetType.From3100To4000,
        //         Timeline= TimelineType.From4To5Months,
        //         PdfUrl= "#"
        //     }
        // });
        //
        // portfolioContext.Profile.Add(mustafa);
        portfolioContext.SaveChanges();
    }
}