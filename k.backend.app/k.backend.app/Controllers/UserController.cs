using k.backend.app.model.Model;
using k.backend.app.service.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace k.backend.app.service.Controllers
{
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Produces(typeof(UserLoginOutputModel))]
        public async Task<IActionResult> LogIn([FromBody] string userName, string password)
        {
            var command = new UserLogInCommand
            {
                UserName = userName,
                Password = password
            };
            var outputModel = await _mediator.Send(command);
            return Ok(outputModel);
        }
    }
}