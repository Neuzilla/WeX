using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;

namespace WexOne.WeChat.Dto
{
    [AutoMap(typeof(WeChatEventLog))]
    public class CreateEventLogInput : IInputDto
    {
        [StringLength(200)]
        public string ToUserName { get; set; }
        [StringLength(200)]
        public string FromUserName { get; set; }
        [StringLength(100)]
        public string MsgType { get; set; }

        public string OriginalXml { get; set; }
    }
}