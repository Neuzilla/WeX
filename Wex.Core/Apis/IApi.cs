using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public interface IApi<T>
    {
        string Url { get; }
        T Execute();
        string ExecuteRawContent();
    }
}
