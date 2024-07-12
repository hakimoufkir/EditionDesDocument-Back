
using Application.Features.RequestFeature.Commands.AddRequest;
using Application.Features.RequestFeature.Commands.UpdateRequest;
using AutoMapper;
using Domain.Entities;

namespace EventService.Application.Mapping
{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            //Request Mapping
            CreateMap<Request, AddRequestCommand>().ReverseMap();
                

            // UpdateRequestCommand mapping
            CreateMap<UpdateRequestCommand, Request>().ReverseMap();
        }
    }
}
