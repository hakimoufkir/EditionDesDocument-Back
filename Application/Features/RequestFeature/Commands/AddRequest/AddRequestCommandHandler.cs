using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
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
        private readonly IUnitOfService _uos;
        private readonly IMapper _mapper;
        public AddRequestCommandHandler(IUnitOfService uos, IMapper mapper)
        {
            _uos = uos;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddRequestCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Request requests = _mapper.Map<Request>(request);
                var result = await _uos.RequestService.AddRequestAsync(requests);
                if (result == "Success")
                {
                    return "Request added successfully !";
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
