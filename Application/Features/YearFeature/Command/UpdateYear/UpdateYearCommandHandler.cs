using Application.IServices;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.YearFeature.Command.UpdateYear
{
    public class UpdateYearCommandHandler : IRequestHandler<UpdateYearCommand, string>
    {
        private readonly IYearService _yearService;
        private readonly IMapper _mapper;

        public UpdateYearCommandHandler(IYearService yearService, IMapper mapper)
        {
            _yearService = yearService;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateYearCommand request, CancellationToken cancellationToken)
        {   
            try
            {
                Year year = _mapper.Map<Year>(request.Year);
                await _yearService.UpdateYearAsync(year);
                return "Year updated successfully";
            }
            catch (Exception ex)
            {
                return $"An error occurred while updating the year: {ex.Message}";
            }
        }
    }
}
