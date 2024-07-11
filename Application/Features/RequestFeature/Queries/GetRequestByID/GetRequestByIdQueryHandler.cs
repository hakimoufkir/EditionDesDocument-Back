using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.RequestFeature.Queries.GetRequestByID;

public class GetRequestByIdQueryHandler :IRequestHandler<GetRequestByIdQuery,Request>
{
    private readonly IUnitOfService _uos;
    private readonly IMapper _mapper;

    public GetRequestByIdQueryHandler(IUnitOfService uos, IMapper mapper)
    {
        _uos = uos;
        _mapper = mapper;
    }

    public Task<Request> Handle(GetRequestByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}