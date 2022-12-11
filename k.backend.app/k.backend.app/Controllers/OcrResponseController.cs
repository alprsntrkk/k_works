using k.backend.app.model.Model;
using k.backend.app.service.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace k.backend.app.service.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OcrResponseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OcrResponseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SaveOcrResult([FromBody] object json)
        {
            var command = new OcrResultAddCommand
            {
                Json = json
            };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}