using MediatR;
using static Domain.Entities.Document;

namespace Application.Features.RequestFeature.Commands.UpdateRequest
{
    public class UpdateRequestCommand : IRequest<string>
    {
        public Guid Id { get; set; }
        public Guid IdTrainee { get; set; }
        public string? NameTrainee { get; set; }
        public Guid ModeleId { get; set; }
        public string role { get; set; }
        public string DocumentType { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
    }
}
