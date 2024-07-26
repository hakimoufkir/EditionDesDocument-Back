using Application.Interfaces;
using Application.IServices;
using AutoMapper;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DocumentFeature.Commands.DeleteDocument
{
    public class DeleteAllDocumentsCommandHandler : IRequestHandler<DeleteAllDocumentsCommand, string>
    {
        private readonly IUnitOfService _unitOfService;
        private readonly IMapper _mapper;

        public DeleteAllDocumentsCommandHandler(IUnitOfService unitOfService, IMapper mapper)
        {
            _unitOfService = unitOfService;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteAllDocumentsCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _unitOfService.DocumentService.DeleteAllDocumentsAsync();
                return ResponsStutusHandler.StatusMessages.Added.ToString();
            }
            catch (Exception ex)
            {
                // Log the exception details
                throw new ApplicationException($"An error occurred while deleting documents. Details: {ex.Message} {ex.StackTrace}", ex);
            }
        }
    }
}
