
﻿using MediatR;


﻿using Domain.Entities;
using MediatR;
using static Domain.Entities.Document;
using Domain.Enums;


namespace Application.Features.RequestFeature.Commands.AddRequest;

public class AddRequestCommand : IRequest<string>
{
 
    public Guid IdTrainee { get; set; }
    public string? NameTrainee { get; set; }
    public Guid ModeleId { get; set; }
    public string ReasonRejection { get; set; }
    public string DocumentType { get; set; }
    public string Role { get; set; }
    public DocumentStatus DocumentStatus { get; set; }
    public string MotifRejection { get; set; }

}