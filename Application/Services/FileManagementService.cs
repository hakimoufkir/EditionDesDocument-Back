using Application.IServices;
using Microsoft.AspNetCore.Http;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;


namespace Application.Services;


public class FileManagementService : IFileManagementService
    {
        private readonly string _blobSasToken;
        private readonly string _containerName;
        private readonly BlobServiceClient _blobServiceClient;

        public FileManagementService(IConfiguration configuration)
        {
            _blobSasToken = configuration.GetValue<string>("BlobStorage:BlobSasToken");
            _containerName = configuration.GetValue<string>("BlobStorage:ContainerName");
            var connectionString = configuration.GetValue<string>("BlobStorage:ConnectionString");

            _blobServiceClient = new BlobServiceClient(connectionString);
        }

    public async Task<string> Upload(IFormFile file)
        {
             // Create or get the container

            var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
            await blobContainerClient.CreateIfNotExistsAsync();

            // Generate a unique filename or use the original filename
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            // Upload the file to Azure Blob Storage
            var blobClient = blobContainerClient.GetBlobClient(fileName);
            await blobClient.UploadAsync(file.OpenReadStream(), true);

            // Return the URL of the uploaded blob
            return blobClient.Uri.ToString();
        }

        public async Task<Stream> GetFile(string url)
        {
        var blobClient = new BlobClient(new Uri(url + "?" + _blobSasToken));

        var response = await blobClient.DownloadAsync();

        return response.Value.Content;
    }


    
}

