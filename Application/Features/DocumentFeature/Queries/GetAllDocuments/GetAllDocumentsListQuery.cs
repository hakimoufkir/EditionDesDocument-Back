using Domain.Entities;
using MediatR;

namespace Application.Features.DocumentFeature.Queries.GetAllDocuments
{
    public class GetAllDocumentsListQuery : IRequest<List<Document>>
    {
       
    }
}
