using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.YearFeature.Command.UpdateYear
{
    public class UpdateYearCommand : IRequest<string>
    {
        public Year Year { get; set; }

        public UpdateYearCommand(Year year)
        {
            Year = year;
        }
    }
}
