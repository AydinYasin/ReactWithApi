using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Involved.Cv.Contracts;
using Involved.Cv.Contracts.Employee;
using Involved.Cv.Infrastructure.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Involved.Cv.Service.Employee
{
    public class GetEmployeeRequest : IRequest<GetEmployeeResponse>
    {
    }

    public class GetEmployeeResponse
    {
        public List<EmployeeOverviewDto> EmployeeOverview { get; set; }
    }


    public class GetEmployeesOverviewRequestHandler : IRequestHandler<GetEmployeeRequest, GetEmployeeResponse>
    {
        private readonly IInvolvedCvContext _context;

        public GetEmployeesOverviewRequestHandler(IInvolvedCvContext context)
        {
            _context = context;
        }

        public async Task<GetEmployeeResponse> Handle(GetEmployeeRequest request, CancellationToken cancellationToken)
        {
            //Get employee
            var data = _context.Employees
                //Include ProgrammingLanguage
                .Include(language => language.EmployeeProgrammingLanguages)
                .ThenInclude(language => language.ProgrammingLanguage)
                //Include skillLevel
                .Include(skillLevel => skillLevel.SkillLevel)
                //Map to employeeOverview object
                .Select(_ => new EmployeeOverviewDto {
                    FirstName = _.FirstName,
                    LastName = _.LastName,
                    Email = _.Email,
                    BirthDate = _.BirthDate,
                    Description = _.Description,
                    Township = _.Township,
                    Skill = _.SkillLevel.Name,
                    SkillOverviews = _.EmployeeProgrammingLanguages.Select(_ => new ProgramLanguageDto { Name = _.ProgrammingLanguage.Name, Skill = _.ProgrammingLanguage.Skill }).ToList()
                })
                .ToList();

            return new GetEmployeeResponse{ EmployeeOverview = data };
        }
    }
}