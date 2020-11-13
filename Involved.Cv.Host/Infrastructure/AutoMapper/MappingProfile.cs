using AutoMapper;
using Involved.Cv.Contracts;
using Involved.Cv.Contracts.Cv;
using Involved.Cv.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Involved.Cv.Host.Infrastructure.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Project, ProjectsDto>();
            CreateMap<Education, EducationsDto>();
            CreateMap<ProgrammingLanguage, ProgramLanguageDto>();
            CreateMap<Employee, DetailCvDto>()
                .ForMember(dto => dto.Skill, opt => opt.MapFrom(src => src.SkillLevel.Name));
        }
    }
}
