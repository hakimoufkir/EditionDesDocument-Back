using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.RequestFeature.Commands.AddRequest
{
    public class AddRequestCommandHandler : IRequestHandler<AddRequestCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;
        public AddRequestCommandHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddRequestCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Request requests = _mapper.Map<Request>(request);
                var result = await _unitOfService.RequestService.AddRequestAsync(requests);
                if (result == ResponsStutusHandler.Status.Success.ToString())
                {
                    //return "Request added successfully !";
                    return ResponsStutusHandler.StatusMessages.Added.ToString();
                }
                else
                {
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
    }
}