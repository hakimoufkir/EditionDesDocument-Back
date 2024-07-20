using Application.IRepository;
using Application.IServices;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public class CheckRoleService : ICheckRoleService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IMapper _mapper;

        public CheckRoleService(IRequestRepository requestRepository , IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }


        public async Task<bool> CheckRole(Request request)
        {
           
            if (request.Role == Roles.roles.assistant.ToString() || request.Role == Roles.roles.trainee.ToString() || request.Role == Roles.roles.director.ToString())
            {
                return false;
            }

           
            return true;
        }
    }
}
