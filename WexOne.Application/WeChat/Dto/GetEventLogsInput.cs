using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using WexOne.Dto;

namespace WexOne.WeChat.Dto
{
    public class GetEventLogsInput : DatatablesPagedAndSortedInputDto
    {
        public string Filter{ get; set; }
        public string MsgType { get; set; }
    }
}