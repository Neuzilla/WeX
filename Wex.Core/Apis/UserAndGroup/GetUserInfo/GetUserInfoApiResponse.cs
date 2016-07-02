using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class GetUserInfoApiResponse : ApiResponseBase
    {
        /// <summary>
        /// whether the user subscribed the wechat public account; if 0, rest properties will be null;
        /// </summary>
        public int Subscribe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long Subscribe_Time { get; set; }
        /// <summary>
        /// open id of the user
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// nickname of the user
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        ///  gender of the user
        /// </summary>
        /// <remarks>1 for male, 2 for female
        /// </remarks>
        public int Sex { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        /// <summary>
        /// avator url of the user
        /// </summary>
        /// <example>
        /// http://wx.qlogo.cn/mmopen/g3MonUZtNHkdmzicIlibx6iaFqAc56vxLSUfpb6n5WKSYVY0ChQKkiaJSgQ1dZuTOgvLLrhJbERQQ4eMsv84eavHiaiceqxibJxCfHe/0
        /// </example>
        public string HeadImgUrl { get; set; }
        /// <summary>
        /// User language: zh-CN(default) 简体，zh-TW 繁体，en 英语
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// id of the group that the user belongs to
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// remark from the operator of wechat public account
        /// </summary>
        public string Remark { get; set; }
    }
}
