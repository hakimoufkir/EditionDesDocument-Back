
﻿using MediatR;
//using static Domain.Entities.Documents;

﻿using Domain.Entities;
using MediatR;
using static Domain.Entities.Document;


namespace Application.Features.RequestFeature.Commands.AddRequest;

public class AddRequestCommand : IRequest<string>
{
 
    public Guid IdTrainee { get; set; }
    public string? NameTrainee { get; set; }
    public Guid ModeleId { get; set; }
    public string ReasonRejection { get; set; }
    public string DocumentType { get; set; }
    public DocumentStatus DocumentStatus { get; set; }
    public string MotifRejection { get; set; }

}