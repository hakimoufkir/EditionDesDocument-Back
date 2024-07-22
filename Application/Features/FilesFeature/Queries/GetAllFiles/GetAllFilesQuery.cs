using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FilesFeature.Queries.GetAllFiles
{
    public class GetAllFilesQuery : IRequest<List<string>>
    {
    }
}
