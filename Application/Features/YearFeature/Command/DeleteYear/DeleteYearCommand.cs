using MediatR;

namespace Application.Features.YearFeature.Commands.DeleteYear
{
    public class DeleteYearCommand : IRequest<string>
    {
        public Guid YearId { get; set; }

        public DeleteYearCommand(Guid yearId)
        {
            YearId = yearId;
        }
    }
}
