using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IFileManagement
    {
        Task<string> Uploadd(IFormFile file);
        Task<Stream> GetFiles(string url);
        Task<string> Upload(Stream fileStream, string fileName);
        Task<Stream> GetFile(string url);
    }
}
