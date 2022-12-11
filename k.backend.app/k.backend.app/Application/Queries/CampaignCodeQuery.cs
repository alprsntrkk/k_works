using k.backend.app.data.EntityFramework;
using k.backend.app.domain.Aggregates;
using k.backend.app.model.Model;
using k.backend.core.Auth.Jwt.Abstact;
using Microsoft.EntityFrameworkCore;

namespace k.backend.app.service.Application.Queries
{
    public class CampaignCodeQuery : ICampaignCodeQuery
    {
        private readonly CampaignContext _context;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CampaignCodeQuery(CampaignContext context,ITokenService tokenService,IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _tokenService = tokenService;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<CampaignCodeListOutputModel> GetAll()
        {
            //Middleware'a taşınabilir
            var token = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();
            if (!_tokenService.IsTokenValid(_configuration["Jwt:Key"].ToString(), _configuration["Jwt:Issuer"].ToString(), token))
            {
                return null;
            }

            var outputModel = new CampaignCodeListOutputModel();
            outputModel.Models = await _context.CampaignCodes.Select(x => new CampaignCodeDataModel
            {
                Id = x.Id,
                Code = x.Code
            }).ToListAsync();
            return outputModel;
        }
    }
}