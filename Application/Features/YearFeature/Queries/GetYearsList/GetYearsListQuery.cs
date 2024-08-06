using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Features.YearFeature.Queries.GetYearsList
{
    public class GetYearsListQuery : IRequest<List<Year>>
    {
    }
}
