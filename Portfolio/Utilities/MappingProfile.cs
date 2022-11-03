using AutoMapper;
using Portfolio.Dashboard.Get.DTOs;
using Portfolio.Dashboard.Post.DTOs;
using Portfolio.Dashboard.Update.DTOs;
using Portfolio.Database.Models;
using Portfolio.DTOs;

namespace Portfolio.Utilities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PostImageDto, ImageModel>();
        CreateMap<ImageModel, GetImageDto>();
        
        CreateMap<PostSkillDto, SkillModel>();
        CreateMap<SkillModel, GetSkillDto>();
        
        CreateMap<PostLanguageDto, LanguageModel>();
        CreateMap<LanguageModel, GetLanguageDto>();
        
        CreateMap<PostTrustSourceDto, TrustSourceModel>();
        CreateMap<TrustSourceModel, GetTrustSourceDto>();
        
        CreateMap<FeedbackModel, GetFeedbackDto>();
        CreateMap<FeedbackModel, HomeFeedbackDto>();
        CreateMap<PostFeedbackDto, FeedbackModel>();
        
        CreateMap<PostProjectRequestDto, ProjectRequestModel>();
        CreateMap<ProjectRequestModel, GetProjectRequestDto>();
        
        CreateMap<PostProjectDto, ProjectModel>();
        CreateMap<ProjectModel, HomeProjectDto>();
        CreateMap<ProjectModel, GetProjectDto>();

        CreateMap<SchoolModel, GetSchoolDto>();
        CreateMap<PostSchoolDto, SchoolModel>();

        CreateMap<EducationModel, GetEducationDto>();
        CreateMap<PostEducationDto, EducationModel>();
        CreateMap<UpdateEducationDto, EducationModel>();
        
        CreateMap<PostCompanyDto, CompanyModel>();
        CreateMap<CompanyModel, HomeCompanyDto>();
        CreateMap<CompanyModel, GetCompanyDto>();

        CreateMap<UpdateExperienceDto, ExperienceModel>();
        CreateMap<PostExperienceDto, ExperienceModel>();
        CreateMap<ExperienceModel, HomeExperienceDto>();
        CreateMap<ExperienceModel, GetExperienceDto>();
        
        CreateMap<PostCertificationDto, CertificationModel>();
        CreateMap<CertificationModel, AboutCertificationDto>();
        CreateMap<CertificationModel, GetCertificationDto>();

        CreateMap<UpdateResumeDto, ResumeModel>();
        CreateMap<ResumeModel, ResumeResumeDto>();
        CreateMap<ResumeModel, GetResumeDto>();
        CreateMap<ResumeModel, AboutResumeDto>()
            .ForMember(
                aboutResumeDto => aboutResumeDto.ProjectsCount,
                memberOptions => memberOptions.MapFrom(resume => resume.Projects.Count)
            );
        CreateMap<ResumeModel, HomeResumeDto>()
            .ForMember(
                homeResumeDto => homeResumeDto.Experience,
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
                homeResumeDto => homeResumeDto.LastProjects,
                memberOptions => memberOptions
                    .MapFrom(resume => resume.Projects.Where(project => project.LastProject).ToList())
            );

        CreateMap<UpdateProfileDto, ProfileModel>();
        CreateMap<ProfileModel, GetProfileDto>();
        CreateMap<ProfileModel, HomeProfileDto>()
            .ForMember(
                resumeProfileDto => resumeProfileDto.Feedbacks,
                memberOptions => memberOptions
                    .MapFrom(profile =>
                        profile.Feedbacks.Where(feedback => feedback.View).ToList())
            );
        CreateMap<ProfileModel, ProjectProfileDto>();
        CreateMap<ProfileModel, AboutProfileDto>()
            .ForMember(
                aboutProfileDto => aboutProfileDto.FeedbacksCount,
                memberOptions => memberOptions.MapFrom(profile => profile.Feedbacks.Count)
            );
        CreateMap<ProfileModel, ResumeProfileDto>()
            .ForMember(
                resumeProfileDto => resumeProfileDto.Feedbacks,
                memberOptions => memberOptions
                    .MapFrom(profile =>
                        profile.Feedbacks.Where(feedback => feedback.Workmate && feedback.View).ToList())
            );
    }
}