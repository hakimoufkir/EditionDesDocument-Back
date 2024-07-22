using Application.Interfaces;
using Application.IServices;
using Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FilesFeature.Queries.GetAllFiles
{
    public class GetAllFilesQueryHandler : IRequestHandler<GetAllFilesQuery, List<string>>
    {
        private readonly IUnitOfService _unitOfService;

        public GetAllFilesQueryHandler(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }
        public async Task<List<string>> Handle(GetAllFilesQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfService.FileManagementService.ListAllFiles();
        }
    }
}
