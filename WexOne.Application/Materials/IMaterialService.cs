using Neuzilla.Wex.Core;
using Neuzilla.Wex.Core.Apis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.Materials
{
    public interface IMaterialService : IWeChatOAService
    {
        string UploadImageTempMedia(IWeChatOAContext context,byte[] data, string filename, string mimeType);
        MemoryStream DownloadTempMedia(IWeChatOAContext context,string mediaId);
        string UploadPermanentMedia(IWeChatOAContext context, string filename, string mimeType,string serverFilePath);

    }
}
