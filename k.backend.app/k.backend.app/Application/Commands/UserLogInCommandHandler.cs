using k.backend.app.data.EntityFramework;
using k.backend.app.model.Model;
using k.backend.core.Auth.Jwt.Abstact;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace k.backend.app.service.Application.Commands
{
    public class UserLogInCommandHandler : IRequestHandler<UserLogInCommand, UserLoginOutputModel>
    {
        private readonly IConfiguration _configuration;
        private readonly CampaignContext _campaignContext;
        private readonly ITokenService _tokenService;

        /// <summary>
        /// Unit of work kullanılmalı.
        /// </summary>
        public UserLogInCommandHandler(IConfiguration configuration, CampaignContext campaignContext, ITokenService tokenService)
        {
            _configuration = configuration;
            _campaignContext = campaignContext;
            _tokenService = tokenService;
        }

        public async Task<UserLoginOutputModel> Handle(UserLogInCommand request, CancellationToken cancellationToken)
        {
            var user = await _campaignContext.Users.Where(x => x.UserName == request.UserName && x.Password == request.Password).FirstOrDefaultAsync();

            if (user != null)
            {
                return new UserLoginOutputModel
                {
                    IsSuccess = true,
                    Message = "User logged in successfully.",
                    Token = _tokenService.BuildToken(_configuration["Jwt:Key"].ToString(), _configuration["Jwt:Issuer"].ToString(), user.UserName, "Admin")
                };
            }
            else
            {
                return new UserLoginOutputModel
                {
                    IsSuccess = false,
                    Message = "Something went wrong."
                };
            }
        }
    }
}