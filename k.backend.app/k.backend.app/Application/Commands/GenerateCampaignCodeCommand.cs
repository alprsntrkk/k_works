using MediatR;
using k.backend.app.model.Model;

namespace k.backend.app.service.Application.Commands
{
    public class GenerateCampaignCodeCommand : IRequest<GenerateCampaignCodeOutputModel>
    {
        public int CodeCount { get; set; }
    }
}