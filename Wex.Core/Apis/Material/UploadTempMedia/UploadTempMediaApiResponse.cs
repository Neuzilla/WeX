using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class UploadTempMediaApiResponse:ApiResponseBase
    {
        public UploadMediaType Type { get; set; }
        public string Media_Id { get; set; }
        public long Created_At { get; set; }
    }
}
