using k.backend.app.data.EntityFramework;
using k.backend.app.domain.Aggregates;
using k.backend.app.model.Model;
using k.backend.app.service.Application.Queries;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Polly;

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
            for (int i = 0; i < campaignCodeCount; i++)
            {
                CampaignCode code = new CampaignCode();
                await AddCodeWithRetryPolicy(code);
            }

            return new GenerateCampaignCodeOutputModel
            {
                CodeCount = campaignCodeCount,
                Message = "Codes successfully generated."
            };
        }

        /// <summary>
        /// Code aynı üretilir ise 10 kez daha aynı koddan üretmeye çalışır.
        /// </summary>
        /// <param name="campaignCode"></param>
        public async Task AddCodeWithRetryPolicy(CampaignCode campaignCode)
        {
            var policy = Policy.Handle<DbUpdateException>().RetryAsync(10, async (exception, retryCount) =>
            {
                SqlException? innerException = exception.InnerException?.InnerException as SqlException;
                if (innerException != null && (innerException.Number == 2627 || innerException.Number == 2601))
                {
                    //Dp duplicate update key exception alır ise tekrar code yarat.
                    campaignCode.GenerateCode();
                    await _campaignContext.AddAsync(campaignCode);
                    await _campaignContext.SaveChangesAsync();
                }
                else
                {
                    throw exception;
                }
            });

            await policy.ExecuteAsync(async () =>
            {
                await _campaignContext.AddAsync(campaignCode);
                await _campaignContext.SaveChangesAsync();
            });
        }
    }
}