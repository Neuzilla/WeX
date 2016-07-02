using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu
{
    public enum MenuButtonType
    { 
        none,
        click,
        view,
        scancode_push,
        scancode_waitmsg,
        pic_sysphoto,
        pic_photo_or_album,
        pic_weixin,
        location_select,
        media_id,
        view_limited
    }

    public interface INamedMenuButton
    {
        /// <summary>
        /// Menu title, length is less than 16 byte; sub menu title, length is less than 40 bytes
        /// </summary>
        string Name { get; set; }

    }
}
