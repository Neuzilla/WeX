using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IUploadPermanentImageMediaApi : IWeChatApi<UploadPermanentImageMediaApiResponse>, IMustPost, IUploadFileApi
    {
        [FormParameter("media")]
        string Media { get; }
    }
}
