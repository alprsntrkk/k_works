using k.backend.app.data.EntityFramework;
using k.backend.app.domain.Aggregates;
using k.backend.app.model.Model;
using Microsoft.EntityFrameworkCore;

namespace k.backend.app.service.Application.Queries
{
    public class CampaignCodeQuery : ICampaignCodeQuery
    {
        private readonly CampaignContext _context;

        public CampaignCodeQuery(CampaignContext context)
        {
            _context = context;
        }

        public async Task<CampaignCodeListOutputModel> GetAll()
        {
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