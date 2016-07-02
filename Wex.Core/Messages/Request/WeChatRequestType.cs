using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages
{
    /// <summary>
    /// request type defined by wechat offical
    /// </summary>
    /// <remarks>
    /// http://mp.weixin.qq.com/wiki/17/f298879f8fb29ab98b2f2971d42552fd.html#.E5.9C.B0.E7.90.86.E4.BD.8D.E7.BD.AE.E6.B6.88.E6.81.AF
    /// </remarks>
    public enum WeChatRequestType
    {
        Text,
        Image,
        Voice, 
        Video,
        Location,
        ShortVideo,
        Link,
        Event   //subscribe event, unsubscribe
    }
}
