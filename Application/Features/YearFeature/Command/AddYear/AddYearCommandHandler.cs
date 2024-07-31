using Application.IServices;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.YearFeature.Command.AddYear
{
    public class AddYearCommandHandler : IRequestHandler<AddYearCommand, Year>
    {
        private readonly IYearService _yearService; 

        public AddYearCommandHandler(IYearService yearService)
        {
            _yearService = yearService;
        }

        public async Task<Year> Handle(AddYearCommand request, CancellationToken cancellationToken)
        {
            return await _yearService.CreateYearAsync(request.Year);
        }
    }
}
