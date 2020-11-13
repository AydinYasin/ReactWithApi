using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Involved.Cv.Contracts;
using Involved.Cv.Contracts.Employee;
using Involved.Cv.Domain;
using Involved.Cv.Service.Employee;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Involved.Cv.Host.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("employeesOverview")]
        public async Task<List<EmployeeOverviewDto>> GetEmployeesOverview(CancellationToken cancellationToken)
        {
            var request = new GetEmployeeRequest();

            var response = await _mediator.Send(request, cancellationToken);

            return response.EmployeeOverview;
        }
    }
}