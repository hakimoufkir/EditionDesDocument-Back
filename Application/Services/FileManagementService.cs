using Application.IServices;
using Azure.Storage;
using Microsoft.AspNetCore.Http;
using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Castle.Core.Configuration;
//using Gestion_Inscriptions_Stagiaires.Application.Services.Interfaces;


//using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Configuration;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;


namespace Application.Services;

//public class FileManagement : IFileManagement
//{

    //    private readonly IConfiguration _configuration;
    //    private readonly string BlobName;
    //    private readonly string Key;
    //    private readonly string ConnectionString;
    //    private readonly string BlobSasToken;
    //    private readonly string BlobSasUrl;
    //    private readonly string ContainerName;

    //    public FileManagement(IConfiguration configuration)
    //    {
    //        _configuration = configuration;
    //        BlobName = _configuration.GetValue<string>("BlobStorage:BlobName");
    //        Key = _configuration.GetValue<string>("BlobStorage:Key");
    //        ConnectionString = _configuration.GetValue<string>("BlobStorage:ConnectionString");
    //        BlobSasToken = _configuration.GetValue<string>("BlobStorage:BlobSasToken");
    //        BlobSasUrl = _configuration.GetValue<string>("BlobStorage:BlobSasUrl");
    //        ContainerName = _configuration.GetValue<string>("BlobStorage:ContainerName");
    //    }


    //    public async Task<string> Uploadd(IFormFile file)
    //    {
    //        // Create a BlobServiceClient object which will be used to create a container client
    //        BlobServiceClient blobServiceClient = new BlobServiceClient(ConnectionString);

    //        // Create a container client
    //        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(ContainerName);

    //        // Ensure the container exists
    //        await containerClient.CreateIfNotExistsAsync();

    //        // Get a reference to a blob
    //        BlobClient blobClient = containerClient.GetBlobClient(Guid.NewGuid() + file.FileName);

    //        // Open the file and upload its data
    //        using (Stream uploadFileStream = file.OpenReadStream())
    //        {
    //            await blobClient.UploadAsync(uploadFileStream, true);
    //            uploadFileStream.Close();
    //        }

    //        // Return the URL of the uploaded blob
    //        return blobClient.Uri.ToString();
    //    }

    //    public async Task<IFormFile> GetFiles(string url)
    //    {
    //        using (HttpClient client = new HttpClient())
    //        {

    //            BlobSasBuilder sasBuilder = new BlobSasBuilder()
    //            {
    //                BlobContainerName = ContainerName,
    //                BlobName = BlobName,
    //                Resource = "b",
    //                StartsOn = DateTimeOffset.UtcNow,
    //                ExpiresOn = DateTimeOffset.UtcNow.AddHours(1)
    //            };

    //            sasBuilder.SetPermissions(BlobSasPermissions.Read);
    //            // StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(ContainerName, BlobSasToken);
    //            //
    //            // string sasToken = sasBuilder.ToSasQueryParameters(sharedKeyCredential).ToString();

    //            Uri blobUrlWithSas = new Uri(url + "?" + BlobSasToken);

    //            // Get the content of the file from the URL
    //            HttpResponseMessage response = await client.GetAsync(blobUrlWithSas);
    //            response.EnsureSuccessStatusCode();

    //            // Read the content into a stream
    //            var stream = await response.Content.ReadAsStreamAsync();

    //            // Convert the stream to a form file
    //            var fileName = Path.GetFileName(new Uri(url).LocalPath);
    //            return new Microsoft.AspNetCore.Http.fo(stream, 0, stream.Length, fileName, fileName);
    //        }
    //    }

    public class FileManagementService : IFileManagement
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

    public async Task<string> Uploadd(IFormFile file)
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

        public async Task<Stream> GetFiles(string url)
        {
        var blobClient = new BlobClient(new Uri(url + "?" + _blobSasToken));

        var response = await blobClient.DownloadAsync();

        return response.Value.Content;
    }


    public Task<string> Upload(Stream fileStream, string fileName)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> GetFile(string url)
    {
        throw new NotImplementedException();
    }

    // Other methods for managing files can be added as needed
}

