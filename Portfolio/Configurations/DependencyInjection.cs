using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Portfolio.Admin.Repositories;
using Portfolio.CurrentUser.Repositories;
using Portfolio.Dashboard.Models;
using Portfolio.Database;
using Portfolio.Email.Repositories;
using Portfolio.JWTGenerator.Repositories;
using Portfolio.JWTGenerator.Utilities;
using Portfolio.Repositories;
using Portfolio.User.Repositories;
using Portfolio.Utilities;

namespace Portfolio.Configurations;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddCorsService();
        services.AddInfrastructure();
        services.AddDatabaseService();
        services.AddSwaggerGenService();
        services.AddHttpContextAccessor();
        services.AddEndpointsApiExplorer();
        services.AddAuthenticationService();
        services.AddAutoMapper(typeof(MappingProfile));
    }

    private static void AddDatabaseService(this IServiceCollection services)
    {
        services.AddDbContext<IPortfolioContext, PortfolioContext>(optionsAction =>
                optionsAction.UseSqlServer(ConfigProvider.ConnectionStringSqlServer))
            .AddIdentity<IdentityUser, IdentityRole>(identityOptions =>
            {
                identityOptions.SignIn.RequireConfirmedAccount = true;
                identityOptions.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<PortfolioContext>().AddDefaultTokenProviders();
    }

    private static void AddAuthenticationService(this IServiceCollection services)
    {
        services.AddAuthentication(configureOptions =>
        {
            configureOptions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            configureOptions.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
            configureOptions.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
            configureOptions.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
            configureOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            configureOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(configureOptions =>
        {
            configureOptions.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = JwtParameters.ValidIssuer,
                ValidateAudience = true,
                ValidAudience = JwtParameters.ValidAudience,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = JwtParameters.IssuerSigningKey
            };
        });
    }

    private static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ICurrentUserRepository, CurrentUserRepository>();
        services.AddSingleton<IEmailRepository, EmailRepository>(_ => new EmailRepository(new SmtpClient
        {
            Host = ConfigProvider.SmtpClientGmailHost, Port = ConfigProvider.SmtpClientGmailPort,
            EnableSsl = ConfigProvider.SmtpClientGmailEnableSsl, Credentials = new NetworkCredential(
                ConfigProvider.SmtpClientGmailCredentialsUserName,
                ConfigProvider.SmtpClientGmailCredentialsPassword)
        }));
        services.AddScoped<IJwtGeneratorRepository, JwtGeneratorRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IAdminRepository, AdminRepository>();
        services.AddTransient<IPortfolioRepository, PortfolioRepository>();
    }

    private static void AddCorsService(this IServiceCollection services)
    {
        services.AddCors(corsOptions => corsOptions.AddDefaultPolicy(
            policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
    }

    private static void AddSwaggerGenService(this IServiceCollection services)
    {
        services.AddSwaggerGen(swaggerGenOption =>
        {
            swaggerGenOption.OperationFilter<SwaggerOperationFilter>();
            
            swaggerGenOption.SwaggerDoc(ConfigProvider.OpenApiInfoVersion, new OpenApiInfo
            {
                Title = ConfigProvider.OpenApiInfoTitle,
                Version = ConfigProvider.OpenApiInfoVersion,
                Description = ConfigProvider.OpenApiInfoDescription
            });
            
            swaggerGenOption.AddSecurityDefinition(ConfigProvider.OpenApiSecuritySchemeScheme, new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Name = ConfigProvider.OpenApiSecuritySchemeName,
                Scheme = ConfigProvider.OpenApiSecuritySchemeScheme,
                Description = ConfigProvider.OpenApiSecuritySchemeDescription,
                BearerFormat = ConfigProvider.OpenApiSecuritySchemeBearerFormat
            });
            
            swaggerGenOption.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Id = ConfigProvider.OpenApiSecuritySchemeScheme,
                            Type = ReferenceType.SecurityScheme
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });
    }
    
    public static void CreateDbIfNotExists(this IHost host)
    {
        var portfolioContext = host.Services.CreateScope().ServiceProvider.GetRequiredService<IPortfolioContext>();
        portfolioContext.Database.EnsureCreated();
        portfolioContext.InitializeDb();
    }

    private static void InitializeDb(this IPortfolioContext portfolioContext)
    {
        if (portfolioContext.Mustafa.Any()) return;

        var mustafa = new Mustafa
        {
            Email = "mkamel733@gmail.com",
            ImageUrl = "#",
            VideoUrl = "#",
            ResumeUrl = "#",
            BehanceUrl = "#",
            DribbbleUrl = "#",
            LinkedInUrl = "#",
            MediumUrl = "#",
            InstagramUrl = "#",
            TwitterUrl = "#",
            FacebookUrl = "#",
            YearsOfExperience = 3
        };
        
        mustafa.Resumes.AddRange(new []
        {
            new Resume
            {
                Name = "مصطفى كامل",
                Title = "تجربة",
                TitleUrl = "#",
                ResumeUrl = "#",
                Location = new Location
                {
                    City = "أسيوط",
                    Country = "مصر"
                },
                About = "تجربة"
            },
            new Resume
            {
                Name = "Mustafa Kamel",
                Title = "Test",
                TitleUrl = "#",
                ResumeUrl = "#",
                Location = new Location
                {
                    City = "Assiut",
                    Country = "Egypt"
                },
                About = "Test"
            }
        });

        mustafa.Resumes.Last().Skills.AddRange(new []
        {
            new Skill
            {
                Name = "Test 1"
            },
            new Skill
            {
                Name = "Test 2"
            },
            new Skill
            {
                Name = "Test 3"
            }
        });
        
        mustafa.Resumes.Last().Projects.AddRange(new []
        {
            new Project
            {
                Name = "Test 1",
                Type = ProjectType.Dashboard,
                ImageUrl = "#",
                ForSale = true,
                LastProject = true
            },
            new Project
            {
                Name = "Test 2",
                Type = ProjectType.UiDesign,
                ImageUrl = "#",
                ForSale = false,
                LastProject = true
            },
            new Project
            {
                Name = "Test 3",
                Type = ProjectType.CaseStudy,
                ImageUrl = "#",
                ForSale = true,
                LastProject = false
            }
        });
        
        mustafa.Resumes.Last().Languages.AddRange(new []
        {
            new Language
            {
                Name = "Arabic"
            },
            new Language
            {
                Name = "English"
            }
        });
        
        mustafa.Resumes.Last().Educations.AddRange(new []
        {
            new Education
            {
                Grade = 3.1,
                Degree = "Test 1",
                StartDate = DateTime.Now,
                School = new School
                {
                    Name = "Assiut University",
                    Location = new Location
                    {
                        City = "Assiut",
                        Country = "Egypt"
                    },
                    Url = "#"
                }
            },
            new Education
            {
                Grade = 3.2,
                Degree = "Test 2",
                StartDate = DateTime.UtcNow,
                School = new School
                {
                    Name = "Cairo University",
                    Location = new Location
                    {
                        City = "Cairo",
                        Country = "Egypt"
                    },
                    Url = "#"
                }
            }
        });
        
        mustafa.Resumes.Last().Experiences.AddRange(new []
        {
            new Experience
            {
                Job = new Job
                {
                    Title = "Test 1",
                    Type = EmploymentType.FullTime
                },
                Company = new Company
                {
                    Name = "Test 1",
                    Location = new Location
                    {
                        City = "Assiut",
                        Country = "Egypt"
                    },
                    Url = "#"
                },
                Main = true,
                StartDate = DateTime.UtcNow
            },
            new Experience
            {
                Job = new Job
                {
                    Title = "Test 2",
                    Type = EmploymentType.PartTime
                },
                Company = new Company
                {
                    Name = "Test 2",
                    Location = new Location
                    {
                        City = "Cairo",
                        Country = "Egypt"
                    },
                    Url = "#"
                },
                Main = false,
                StartDate = DateTime.UtcNow
            }
        });
        
        mustafa.Certifications.AddRange(new []
        {
            new Certification
            {
                Url = "#",
                Name = "Test 1",
                Issuer = "Test 1"
            },
            new Certification
            {
                Url = "#",
                Name = "Test 2",
                Issuer = "Test 2"
            }
        });
        
        mustafa.Feedbacks.AddRange(new []
        {
            new Feedback
            {
                Description = "Test 1",
                Name = "Test 1",
                Title = "Test 1"
            },
            new Feedback
            {
                Description = "Test 2",
                Name = "Test 2",
                Title = "Test 2"
            }
        });

        mustafa.TrustedBy.AddRange(new []
        {
            new TrustedBy
            {
                Url = "#",
                ImageUrl = "#"
            },
            new TrustedBy
            {
                Url = "#",
                ImageUrl = "#"
            }
        });
        
        portfolioContext.Mustafa.Add(mustafa);
        portfolioContext.SaveChanges();
    }
}