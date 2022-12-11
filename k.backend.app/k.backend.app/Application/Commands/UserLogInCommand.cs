using k.backend.app.model.Model;
using MediatR;

namespace k.backend.app.service.Application.Commands
{
    public class UserLogInCommand : IRequest<UserLoginOutputModel>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}