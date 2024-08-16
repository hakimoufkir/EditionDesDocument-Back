using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.RequestFeature.Queries.GetRequestByID;

public class GetRequestByIdQueryHandler :IRequestHandler<GetRequestByIdQuery,Request>
{
    private readonly IUnitOfService _unitOfService;
    private readonly IMapper _mapper;

    public GetRequestByIdQueryHandler(IUnitOfService unitOfService, IMapper mapper)
    {
        _unitOfService = unitOfService;
        _mapper = mapper;
    }

    public async Task<Request> Handle(GetRequestByIdQuery request, CancellationToken cancellationToken)
    {
        Request result = await _unitOfService.RequestService.GetRequestByIdAsync(request.IdRequest);
        return result;
    }
}