using k.backend.app.domain.Aggregates;
using k.backend.app.model.Model;

namespace k.backend.app.service.Application.Queries
{
    public interface ICampaignCodeQuery
    {
        Task<CampaignCodeListOutputModel> GetAll();
    }
}