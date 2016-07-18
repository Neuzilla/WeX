using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using WexOne.Dto;
using Abp.Runtime.Validation;
using System;
using System.Web.Mvc;

namespace WexOne.WeChat.Dto
{
    [ModelBinder(typeof(DatatablesModelBinder))]

    public class GetEventLogsInput : DatatablesPagedAndSortedInputDto, IShouldNormalize
    {
        public string Filter {
            get {
                return this.Search.Value;
            }
        }
        public string MsgType { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "CreationTime desc";
            }
        }
    }
}