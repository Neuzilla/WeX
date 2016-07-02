using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    /// <summary>
    /// Upload media types
    /// </summary>
    public enum UploadMediaType
    {
        /// <summary>
        /// image, less than 2MB, supports bmp/png/jpeg/jpg/gif
        /// </summary>
        Image,
        /// <summary>
        /// voice, less than 2MB, play lenth less than 60 seconds, supports AMR\MP3
        /// </summary>
        Voice,
        /// <summary>
        /// video, less than 10MB, supports mp4
        /// </summary>
        Video,
        /// <summary>
        /// thumb：64KB，supports jpg only
        /// </summary>
        Thumb
    }
}
