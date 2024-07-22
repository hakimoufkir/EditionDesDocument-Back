using Domain.Entities;
using MediatR;

public class GetDocumentByUrlQuery : IRequest<Document>
{
    public string DocumentUrl { get; set; }

    public GetDocumentByUrlQuery(string documentUrl)
    {
        DocumentUrl = documentUrl;
    }
}
