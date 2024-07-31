
using Application.Features.DocumentFeature.Commands.AddDocument;
using Application.Features.DocumentFeature.Commands.UpdateDocument;
using Application.Features.DocumentFeature.Queries.GetDocumentById;
using Application.Features.RequestFeature.Commands.AddRequest;
using Application.Features.RequestFeature.Commands.UpdateRequest;
using Application.Features.TraineeFeature.Commands.UpdateTrainee;
using Application.Features.YearFeature.Command.AddYear;
using AutoMapper;
using Domain.Dtos;
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


            // addDocumentCommand mapping
            CreateMap<AddDocumentCommand, Document>().ReverseMap();

            //UpdateDocumentCommand mapping
            CreateMap<UpdateDocumentCommand, Document>();

            //UpdateTraineeCommand mapping
            CreateMap<UpdateTraineeCommand, Trainee>();

            CreateMap<TraineeDto, Trainee>();
            CreateMap<PaymentDto, Payment>();

            CreateMap<AddYearCommand, Year>().ReverseMap();
        }
    }
}
