using AutoMapper;
using Portfolio.Dashboard.DTOs;
using Portfolio.Dashboard.Models;
using Portfolio.DTOs;

namespace Portfolio.Utilities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Skill, SkillDto>()
            .ForMember(
                skillDto => skillDto.Type,
                memberOptions => memberOptions.MapFrom(skill => skill.Type.ToString())
            );
        CreateMap<Language, LanguageDto>();
        CreateMap<Location, LocationDto>();
        CreateMap<TrustedBy, TrustedByDto>();
        CreateMap<Feedback, FeedbackDto>()
            .ForMember(
                feedbackDto => feedbackDto.Feeling,
                memberOptions => memberOptions.MapFrom(feedback => feedback.Feeling.ToString())
            );
        
        CreateMap<School, SchoolDto>();
        
        CreateMap<Education, EducationDto>();
        
        CreateMap<Job, AboutJobDto>();
        CreateMap<Job, JobDto>()
            .ForMember(
                jobDto => jobDto.Type,
                memberOptions => memberOptions.MapFrom(job => job.Type.ToString())
            );
        
        CreateMap<Company, CompanyDto>();
        CreateMap<Company, HomeCompanyDto>();
        
        CreateMap<Certification, CertificationDto>();
        CreateMap<Certification, AboutCertificationDto>();

        CreateMap<Experience, ExperienceDto>();
        CreateMap<Experience, HomeExperienceDto>();
        CreateMap<Experience, AboutExperienceDto>();

        CreateMap<Project, ProjectDto>()
            .ForMember(
                projectDto => projectDto.Type,
                memberOptions => memberOptions.MapFrom(project => project.Type.ToString())
            );
        CreateMap<Project, HomeProjectDto>()
            .ForMember(
                projectHomeDto => projectHomeDto.Type,
                memberOptions => memberOptions.MapFrom(project => project.Type.ToString())
            );
        
        CreateMap<Resume, ResumeResumeDto>();
        CreateMap<Resume, AboutResumeDto>()
            .ForMember(
                resumeAboutDto => resumeAboutDto.ProjectsCount,
                memberOptions => memberOptions.MapFrom(resume => resume.Projects.Count)
            );
        CreateMap<Resume, HomeResumeDto>()
            .ForMember(
                resumeHomeDto => resumeHomeDto.Experience,
                memberOptions => memberOptions
                    .MapFrom(resume => new HomeExperienceDto
                    {
                        Company = new HomeCompanyDto
                        {
                            Name = resume.Experiences.FirstOrDefault(experience => experience.IsMain())!.Company.Name,
                            Url = resume.Experiences.FirstOrDefault(experience => experience.IsMain())!.Company.Url
                        }
                    })
            )
            .ForMember(
                resumeHomeDto => resumeHomeDto.LastProjects,
                memberOptions => memberOptions
                    .MapFrom(resume => resume.Projects.Where(project => project.IsLastProject()).ToList())
            );

        CreateMap<Mustafa, HomeMustafaDto>();
        CreateMap<Mustafa, AboutMustafaDto>()
            .ForMember(
                mustafaAboutDto => mustafaAboutDto.FeedbacksCount,
                memberOptions => memberOptions.MapFrom(mustafa => mustafa.Feedbacks.Count)
            );
        CreateMap<Mustafa, ResumeMustafaDto>()
            .ForMember(
                mustafaResumeDto => mustafaResumeDto.Feedbacks,
                memberOptions => memberOptions
                    .MapFrom(mustafa => mustafa.Feedbacks.Where(feedback => feedback.IsWorkmate()).ToList())
            );
    }
}