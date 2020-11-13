using AutoMapper;
using Involved.Cv.Contracts.Cv;
using Involved.Cv.Infrastructure.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Involved.Cv.Service.Cv
{
    public class GetDetailRequest : IRequest<GetDetailResponse>
    {
        public int Id { get; set; }
    }

    public class GetDetailResponse
    {
        public DetailCvDto DetailCv { get; set; }

    }

    public class GetDetailRequestHandler : IRequestHandler<GetDetailRequest, GetDetailResponse>
    {
        private readonly IMapper _mapper;

        private readonly IInvolvedCvContext _context;

        public GetDetailRequestHandler(IInvolvedCvContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<GetDetailResponse> Handle(GetDetailRequest request, CancellationToken cancellationToken)
        {
            var data = _context.Employees
                .Include(language => language.EmployeeProgrammingLanguages)
                .ThenInclude(language => language.ProgrammingLanguage)
                .Include(skillLevel => skillLevel.SkillLevel)
                .Include(projects => projects.EmployeeProjects)
                .ThenInclude(projects => projects.Project)
                .Include(education => education.EmployeeEducations)
                .ThenInclude(education => education.Education)
                .FirstOrDefault(person => person.Id == request.Id);

            var model = _mapper.Map<DetailCvDto>(data);
            model.SkillOverviews = data.EmployeeProgrammingLanguages.Select(skill => new Contracts.ProgramLanguageDto { Name = skill.ProgrammingLanguage.Name, Skill = skill.ProgrammingLanguage.Skill }).ToList();
            model.Projects = data.EmployeeProjects.Select(skill => new ProjectsDto { Description = skill.Project.Description, Name = skill.Project.Name }).ToList();
            model.Educations = data.EmployeeEducations.Select(skill => new EducationsDto { Name = skill.Education.Name, Description = skill.Education.Description, Level = skill.Education.Level }).ToList();

            return new GetDetailResponse { DetailCv = model };
        }


    }
}
