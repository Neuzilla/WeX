using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Utility
{
    public static class DateTimeHelper
    {
        public static DateTime BaseTime = new DateTime(1970, 1, 1);

        /// <summary>
        /// Convert wechat timestamp to .NET DateTime
        /// </summary>
        /// <param name="dateTimeFromXml">Wechat timestamp</param>
        /// <returns></returns>
        public static DateTime ConvertFromWeChatTimeStamp(long dateTimeFromXml)
        {
            return BaseTime.AddTicks((dateTimeFromXml + 8 * 60 * 60) * 10000000);
        }
        /// <summary>
        /// Convert wechat timestamp to .NET DateTime
        /// </summary>
        /// <param name="dateTimeFromXml">Wechat timestamp</param>
        /// <returns></returns>
        public static DateTime ConvertFromWeChatTimeStamp(string dateTimeFromXml)
        {
            return ConvertFromWeChatTimeStamp(long.Parse(dateTimeFromXml));
        }

        /// <summary>
        /// Convert .NET DateTime to wechat timestamp
        /// </summary>
        /// <param name="dateTime">.NET datetime</param>
        /// <returns></returns>
        public static long ConvertToWeChatTimestamp(DateTime dateTime)
        {
            return (dateTime.Ticks - BaseTime.Ticks) / 10000000 - 8 * 60 * 60;
        }

        public static long NowForWeChat
        {
            get 
            {
                return ConvertToWeChatTimestamp(DateTime.Now);
            }
        }
    }
}
