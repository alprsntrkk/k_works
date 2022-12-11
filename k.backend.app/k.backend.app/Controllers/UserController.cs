using k.backend.app.model.Model;
using k.backend.app.service.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace k.backend.app.service.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Produces(typeof(UserLoginOutputModel))]
        public async Task<IActionResult> LogIn([FromBody] UserLogInInputModel inputModel)
        {
            var command = new UserLogInCommand
            {
                UserName = inputModel.Username,
                Password = inputModel.Password
            };
            var outputModel = await _mediator.Send(command);
            return Ok(outputModel);
        }
    }
}