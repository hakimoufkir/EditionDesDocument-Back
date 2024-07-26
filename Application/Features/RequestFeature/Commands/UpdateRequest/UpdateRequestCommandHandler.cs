using Application.Interfaces;
using Application.IRepository;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.RequestFeature.Commands.UpdateRequest
{
    public class UpdateRequestCommandHandler : IRequestHandler<UpdateRequestCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public UpdateRequestCommandHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }
        

        public async Task<string> Handle(UpdateRequestCommand request, CancellationToken cancellationToken)
        {
            Request existingRequest = await _unitOfService.RequestService.GetRequestByIdAsync(request.Id);
            if (existingRequest == null)
            {
                return ResponsStutusHandler.StatusMessages.RequestNotFound.ToString();
            }


           

            existingRequest.DocumentStatus = request.DocumentStatus;

           

            existingRequest.LastModifiedDate = DateTime.UtcNow;

            // Map the update command to the existing request
            _mapper.Map(request, existingRequest);

            return await _unitOfService.RequestService.UpdateRequestAsync(existingRequest);
        }
    }
}
