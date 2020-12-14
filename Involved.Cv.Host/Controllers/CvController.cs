using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Involved.Cv.Contracts;
using Involved.Cv.Contracts.Cv;
using Involved.Cv.Contracts.Employee;
using Involved.Cv.Domain;
using Involved.Cv.Service.Cv;
using Involved.Cv.Service.Employee;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Involved.Cv.Host.Controllers
{
    [Authorize]
    public class CvController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CvController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        [Route("All")]
        public async Task<AllCvOverviewDto> GetAll(CancellationToken cancellationToken)
        {
            var request = new GetAllCvRequest();

            var response = await _mediator.Send(request, cancellationToken);

            return response.AllCvOverview;
        }

        [HttpGet]
        [Route("Detail")]
        public async Task<DetailCvDto> GetDetail(int id ,CancellationToken cancellationToken)
        {
            var request = new GetDetailRequest {Id = id };

            var response = await _mediator.Send(request, cancellationToken);

            return response.DetailCv;
        }
    }
}