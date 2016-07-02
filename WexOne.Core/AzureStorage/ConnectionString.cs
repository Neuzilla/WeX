using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage;
using System.Configuration;

namespace WexOne.Core.AzureStorage
{
    public static class ConnectionString
    {
        static string account = ConfigurationManager.AppSettings["AzureStorage.AccountName"];
        static string key = ConfigurationManager.AppSettings["AzureStorage.AccountKey"];
        static string blobEndpoint = ConfigurationManager.AppSettings["AzureStorage.BlobEndpoint"];
        public static CloudStorageAccount GetConnectionString()
        {
            string connectionString = string.Format("DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1};BlobEndpoint={2};", account, key, blobEndpoint);
            return CloudStorageAccount.Parse(connectionString);
        }
    }  
}