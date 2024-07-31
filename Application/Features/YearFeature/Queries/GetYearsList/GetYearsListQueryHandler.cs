using Application.IServices;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.YearFeature.Queries.GetYearsList
{
    public class GetYearsListQueryHandler : IRequestHandler<GetYearsListQuery, List<Year>>
    {
        private readonly IYearService _yearService;

        public GetYearsListQueryHandler(IYearService yearService)
        {
            _yearService = yearService;
        }

        public async Task<List<Year>> Handle(GetYearsListQuery request, CancellationToken cancellationToken)
        {
            return await _yearService.GetAllYearsAsync();
        }
    }
}
