using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IUploadFileApi
    {
        byte[] FileData { get; set; }
        string ServerFilePath { get; set; }
        string FileName { get; set; }
        string ContentType { get; set; }
    }
}
