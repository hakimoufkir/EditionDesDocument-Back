using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IFileManagementService
    {
        Task<string> Upload(IFormFile file);
        Task<Stream> GetFile(string url);
      
    }
}
