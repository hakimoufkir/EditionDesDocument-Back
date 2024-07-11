
using Application.Features.RequestFeature.Commands.AddRequest;
using AutoMapper;
using Domain.Entities;

namespace EventService.Application.Mapping
{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            //Request Mapping
            CreateMap<Request,AddRequestCommand>().ReverseMap();          

        }
    }
}
