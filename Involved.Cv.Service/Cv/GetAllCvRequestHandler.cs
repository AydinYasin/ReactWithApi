using FluentValidation.Resources;
using Involved.Cv.Contracts;
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
    public class GetAllCvRequest : IRequest<GetAllCvResponse>
    {
        public int Id { get; set; }
    }

    public class GetAllCvResponse
    {
        public AllCvOverviewDto AllCvOverview { get; set; }
        
    }

    public class GetAllCvRequestHandler : IRequestHandler<GetAllCvRequest, GetAllCvResponse>
    {
        private readonly IInvolvedCvContext _context;

        public GetAllCvRequestHandler(IInvolvedCvContext context)
        {
            _context = context;
        }

        public async Task<GetAllCvResponse> Handle(GetAllCvRequest request, CancellationToken cancellationToken)
        {
            var data = _context.Employees
                .Include(language => language.EmployeeProgrammingLanguages)
                .ThenInclude(language => language.ProgrammingLanguage)
                .Select(_ => new CvOverviewDto
                {
                    FirstName = _.FirstName,
                    LastName = _.LastName,
                    BirthDate =_.BirthDate,
                    Township = _.Township,
                    Skill = _.SkillLevel.Name,
                    Email = _.Email,
                    Description =_.Description,
                    SkillOverviews = _.EmployeeProgrammingLanguages.Select(_ => new ProgramLanguageDto { Name = _.ProgrammingLanguage.Name, Skill =_.ProgrammingLanguage.Skill}).ToList(),
                }).ToList();
            //return new GetCvResponse { AllCvOverview = data };
            var response = new AllCvOverviewDto { CvOverviews = data };

            return new GetAllCvResponse { AllCvOverview = response };
        }
    }
}
