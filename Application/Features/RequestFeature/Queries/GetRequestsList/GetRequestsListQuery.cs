using Domain.Entities;
using MediatR;

namespace Application.Features.RequestFeature.Queries.GetRequestsList;

public class GetRequestsListQuery : IRequest<List<Request>>
{
    
}