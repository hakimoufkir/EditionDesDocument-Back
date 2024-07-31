using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.YearFeature.Command.AddYear
{
    public class AddYearCommand : IRequest<Year>
    {
        public Year Year { get; set; }

        public AddYearCommand(Year year)
        {
            Year = year;
        }
    }
}
