using k.backend.app.data.EntityFramework;
using k.backend.app.domain.Aggregates;
using MediatR;
using Newtonsoft.Json;

namespace k.backend.app.service.Application.Commands
{
    public class OcrResultAddCommandHandler : IRequestHandler<OcrResultAddCommand, string>
    {
        private readonly CampaignContext _campaignContext;

        //UOW ile yapılmalıdır.
        //Farklı amaçlar için kullanıldığından context'ler ayrılmalıdır.
        public OcrResultAddCommandHandler(CampaignContext campaignContext)
        {
            _campaignContext = campaignContext;
        }

        public async Task<string> Handle(OcrResultAddCommand request, CancellationToken cancellationToken)
        {
            var json = request.Json;

            var ocrResponse = JsonConvert.DeserializeObject<OcrResponse>(json);

            await _campaignContext.AddAsync(ocrResponse);
            await _campaignContext.SaveChangesAsync();

            return "Ocr successfully saved.";
        }
    }
}