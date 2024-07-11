<<<<<<< HEAD
﻿using MediatR;
using static Domain.Entities.Documents;
=======
﻿using Domain.Entities;
using MediatR;
using static Domain.Entities.Document;
>>>>>>> 5b80bd99d1aeef3c01b441d9ce61ac3c7ce662c7

namespace Application.Features.RequestFeature.Commands.AddRequest;

public class AddRequestCommand : IRequest<string>
{
    public Guid IdTrainee { get; set; }
    public Guid ModeleId { get; set; }
    public string role { get; set; }
    public string DocumentType { get; set; }
    public DocumentStatus DocumentStatus { get; set; }
}