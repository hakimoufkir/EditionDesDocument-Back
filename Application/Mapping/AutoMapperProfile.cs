
using Application.Features.DocumentFeature.Commands.UpdateDocument;
using Application.Features.DocumentFeature.Queries.GetDocumentById;
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

            // GetDocumentByIdQuery mapping
            CreateMap<GetDocumentByIdQuery, Document>().ReverseMap();


            //UpdateDocumentCommand mapping
            CreateMap<UpdateDocumentCommand, Document>();
        }
    }
}
