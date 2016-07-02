using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class CountMaterialApiResponse:ApiResponseBase
    {
        [JsonProperty("voice_count")]
        public int VoiceCount { get; set; }
        [JsonProperty("video_count")]
        public int VideoCount { get; set; }
        [JsonProperty("image_count")]
        public int ImageCount { get; set; }
        [JsonProperty("news_count")]
        public int NewsCount { get; set; }
    }
}
