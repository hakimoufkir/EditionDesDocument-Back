using Application.IServices;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.YearFeature.Commands.DeleteYear
{
    public class DeleteYearCommandHandler : IRequestHandler<DeleteYearCommand, string>
    {
        private readonly IYearService _yearService;

        public DeleteYearCommandHandler(IYearService yearService)
        {
            _yearService = yearService;
        }

        public async Task<string> Handle(DeleteYearCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _yearService.DeleteYearAsync(request.YearId);
                return "Year deleted successfully";
            }
            catch (Exception ex)
            {
                return $"An error occurred while deleting the year: {ex.Message}";
            }
        }
    }
}
