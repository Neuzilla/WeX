using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace WexOne.Core.AzureStorage
{
    public class AzureBlobStorageProvider:IStorageProvider
    {
        private string _containerName;
        public AzureBlobStorageProvider(string containerName)
        {
            _containerName = containerName;
        }

        private string GetMimeType(string extension)
        {
            if (!extension.StartsWith("."))
                extension = "." + extension;
            switch (extension)
            {
                case ".jpg":
                    return "image/jpeg";
                case ".jpeg":
                    return "image/jpeg";
                case ".bmp":
                    return "image/bmp";
                case ".gif":
                    return "image/gif";
                case ".png":
                    return "image/png";
                case ".tif":
                    return "image/tif";
                case ".tiff":
                    return "image/tiff";
                case ".amr":
                    return "audio/amr";
                case ".speex":
                    return "audio/speex";
                case ".mp3":
                    return "audio/mpeg";
                case ".wav":
                    return "audio/x-wav";
                case ".mid":
                    return "audio/mid";
                default:
                    throw new InvalidDataException(extension);
            }
        }
        public async Task<string> Save(Stream stream, string extension)
        {
            return await Save(stream, extension, null);
        }

        public async Task<Stream> Load(string url)
        {
            if (url == null)
            {
                throw new ApplicationException("Specify the URI of the resource to retrieve.");
            }
            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(url);
            return data;
        }


        public async Task<string> Save(Stream stream, string extension, string mimeType)
        {
            CloudStorageAccount cloudStorageAccount = ConnectionString.GetConnectionString();
            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(_containerName);

            if (await cloudBlobContainer.CreateIfNotExistsAsync())
            {
                await cloudBlobContainer.SetPermissionsAsync(
                    new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Blob
                    }
                    );
            }
            string imageName = Guid.NewGuid().ToString();

            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(imageName);
            if(extension==null)
                cloudBlockBlob.Properties.ContentType = mimeType;
            else
                cloudBlockBlob.Properties.ContentType = GetMimeType(extension);
            if (stream.CanSeek)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }
            await cloudBlockBlob.UploadFromStreamAsync(stream);
            return cloudBlockBlob.Uri.ToString();
        }
    }
}