using MediatR;
using static Domain.Entities.Documents;

namespace Application.Features.RequestFeature.Commands.AddRequest;

public class AddRequestCommand : IRequest<string>
{
    public Guid IdTrainee { get; set; }
    public Guid ModeleId { get; set; }
    public string role { get; set; }
    public string DocumentType { get; set; }
    public DocumentStatus DocumentStatus { get; set; }
}