using MediatR;

namespace k.backend.app.service.Application.Commands
{
    public class OcrResultAddCommand : IRequest<string>
    {
        public string Json { get; set; }
    }
}