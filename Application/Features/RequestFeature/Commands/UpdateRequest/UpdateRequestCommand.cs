using Domain.Enums;
using MediatR;
using static Domain.Entities.Document;

namespace Application.Features.RequestFeature.Commands.UpdateRequest
{
    public class UpdateRequestCommand : IRequest<string>
    {
        public Guid Id { get; set; }
        public DocumentStatus DocumentStatus { get; set; }

        /*        public DateTime? LastModifiedDate { get; set; }
        */
    }
}
