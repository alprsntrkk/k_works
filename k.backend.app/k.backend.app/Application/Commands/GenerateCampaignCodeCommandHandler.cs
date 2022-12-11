using k.backend.app.data.EntityFramework;
using k.backend.app.domain.Aggregates;
using k.backend.app.model.Model;
using k.backend.app.service.Application.Queries;
using MediatR;

namespace k.backend.app.service.Application.Commands
{
    public class GenerateCampaignCodeCommandHandler : IRequestHandler<GenerateCampaignCodeCommand, GenerateCampaignCodeOutputModel>
    {
        private readonly CampaignContext _campaignContext;

        /// <summary>
        /// Veri tabanı erişimi için entity framework'ü kullanan bir UnitOfWork pattern kullanılmalı.
        /// </summary>
        public GenerateCampaignCodeCommandHandler(CampaignContext campaignContext)
        {
            _campaignContext = campaignContext;
        }

        public async Task<GenerateCampaignCodeOutputModel> Handle(GenerateCampaignCodeCommand request, CancellationToken cancellationToken)
        {
            var campaignCodeCount = request.CodeCount;

            List<CampaignCode> campaignCodes = new List<CampaignCode>();

            for (int i = 0; i < campaignCodeCount; i++)
            {
                CampaignCode code = new CampaignCode();
                campaignCodes.Add(code);
            }

            await _campaignContext.AddRangeAsync(campaignCodes);
            _campaignContext.SaveChanges();

            return new GenerateCampaignCodeOutputModel
            {
                CodeCount = campaignCodeCount,
                Message = "Codes successfully generated."
            };
        }
    }
}