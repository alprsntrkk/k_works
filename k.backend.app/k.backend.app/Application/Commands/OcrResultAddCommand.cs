using MediatR;

namespace k.backend.app.service.Application.Commands
{
    public class OcrResultAddCommand : IRequest<string>
    {
        public object Json { get; set; }
    }
}