using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GenerateShortUrlApiResponse:ApiResponseBase
    {
        /// <summary>
        /// the generated result
        /// </summary>
        public string ShortUrl { get; set; }
    }
}
