using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.Core
{
    public interface IStorageProvider
    {
        Task<string> Save(Stream stream, string extension);
        Task<string> Save(Stream stream, string extension,string mimeType);
        Task<Stream> Load(string url);
    }
}
