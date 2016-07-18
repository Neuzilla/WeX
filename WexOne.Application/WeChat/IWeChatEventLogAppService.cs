using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WexOne.Dto;
using WexOne.WeChat.Dto;

namespace WexOne.WeChat
{
    public interface IWeChatEventLogAppService:IApplicationService
    {
        Task CreateEventLog(CreateEventLogInput input);
        Task ClearEventLog();
        Task<WexOne.Dto.DatatablePagedResultDto<EventLogListDto>> GetEventLogs(DatatablesPagedAndSortedInputDto input);
    }
}
