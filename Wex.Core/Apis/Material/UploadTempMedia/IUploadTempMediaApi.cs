using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IUploadTempMediaApi : IWeChatApi<UploadTempMediaApiResponse>, IMustPost, IUploadFileApi
    {
        [QueryString("type", true)]
        UploadMediaType Type { get; set; }

        [FormParameter("media")]
        string Media { get; }
    }
}
