using Application.Interfaces;
using Application.IRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.RequestFeature.Commands.UpdateRequest
{
    public class UpdateRequestCommandHandler : IRequestHandler<UpdateRequestCommand, string>
    {
        private readonly IUnitOfService _uos;
        private readonly IMapper _mapper;

        public UpdateRequestCommandHandler(IUnitOfService uos, IMapper mapper)
        {
            _uos = uos;
            _mapper = mapper;
        }
        

        public async Task<string> Handle(UpdateRequestCommand request, CancellationToken cancellationToken)
        {
            Request existingRequest = await _uos.RequestService.GetRequestByIdAsync(request.Id);
            if (existingRequest == null)
            {
                return "Request not found";
            }


           

            existingRequest.DocumentStatus = request.DocumentStatus;

           

            existingRequest.LastModifiedDate = DateTime.UtcNow;

            // Map the update command to the existing request
            _mapper.Map(request, existingRequest);

            return await _uos.RequestService.UpdateRequestAsync(existingRequest);
        }
    }
}
