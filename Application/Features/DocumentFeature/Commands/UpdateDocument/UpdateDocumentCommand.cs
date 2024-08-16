using MediatR;

namespace Application.Features.DocumentFeature.Commands.UpdateDocument
{
    public class UpdateDocumentCommand : IRequest<string>
    {
        public Guid Id { get; set; }
        public string PathFile { get; set; }
        public string InstantJSON { get; set; }
        public string? Name { get; set; }

        public UpdateDocumentCommand(Guid id, string pathFile, string instantJSON, string? name)
        {
            Id = id;
            PathFile = pathFile;
            InstantJSON = instantJSON;
            Name = name;
        }
    }
}
