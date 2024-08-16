using Domain.Entities;
using MediatR;

namespace Application.Features.RequestFeature.Queries.GetRequestByID;

public class GetRequestByIdQuery: IRequest<Request>
{
    public Guid IdRequest { get; set; }

    public GetRequestByIdQuery(Guid idRequest)
    {
        IdRequest = idRequest;
    
    }
}