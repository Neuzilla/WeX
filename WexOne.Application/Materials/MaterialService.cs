using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using Neuzilla.Wex.Core.Apis.Material;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.Materials
{
    public class MaterialService:IMaterialService
    {

        public string UploadImageTempMedia(IWeChatOAContext context,byte[] data, string filename, string mimeType)
        {
            IUploadTempMediaApi api = new UploadTempMediaApi(context);
            api.FileData = data;
            api.FileName = filename;
            api.ContentType = mimeType;
            api.Type = UploadMediaType.Image;
            var resp = api.Execute();
            return resp.Media_Id;
        }

        public MemoryStream DownloadTempMedia(IWeChatOAContext context,string mediaId)
        {
            IDownloadTempMaterialApi api = new DownloadTempMaterialApi(context);
            api.MediaId = mediaId;
            return api.Execute();
        }


        public string UploadPermanentMedia(IWeChatOAContext context, string filename, string mimeType, string serverFilePath)
        {
            IUploadPermanentImageMediaApi api = new UploadPermanentImageMediaApi(context);
            api.FileName = filename;
            api.ContentType = mimeType;
            api.ServerFilePath = serverFilePath;
            var response = api.Execute();
            return response.Url;
        }
    }
}
