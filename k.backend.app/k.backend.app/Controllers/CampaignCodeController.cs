using k.backend.app.model.Model;
using k.backend.app.service.Application.Commands;
using k.backend.app.service.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace k.backend.app.service.Controllers
{
    public class CampaignCodeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ICampaignCodeQuery _campaignCodeQuery;

        public CampaignCodeController(IMediator mediator, ICampaignCodeQuery campaignCodeQuery)
        {
            _mediator = mediator;
            _campaignCodeQuery = campaignCodeQuery;
        }

        [HttpPost]
        [Produces(typeof(GenerateCampaignCodeOutputModel))]
        public async Task<IActionResult> GenerateCampaignCodes([FromBody] int codeCount)
        {
            var command = new GenerateCampaignCodeCommand
            {
                CodeCount = codeCount
            };
            var outputModel = await _mediator.Send(command);
            return Ok(outputModel);
        }

        [HttpGet]
        [Produces(typeof(CampaignCodeListOutputModel))]
        public async Task<IActionResult> GetCodes()
        {
            var outputModel = await _campaignCodeQuery.GetAll();
            return Ok(outputModel);
        }
    }
}