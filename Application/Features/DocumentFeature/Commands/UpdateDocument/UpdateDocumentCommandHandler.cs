using Application.IRepository;
using Application.IServices;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using AutoMapper;

namespace Application.Features.DocumentFeature.Commands.UpdateDocument
{
    public class UpdateDocumentCommandHandler : IRequestHandler<UpdateDocumentCommand, string>
    {
        private readonly IDocumentService _documentService;
        private readonly IMapper _mapper;

        public UpdateDocumentCommandHandler(IDocumentService documentService, IMapper mapper)
        {
            _documentService = documentService;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Document document = _mapper.Map<Document>(request);
                await _documentService.UpdateDocumentAsync(document);
                return "Document updated successfully";
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }
    }
}
