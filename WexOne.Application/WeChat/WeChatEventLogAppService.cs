using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WexOne.WeChat.Dto;
using Abp.AutoMapper;
using WexOne.Dto;
using System.Data.Entity;
using System.Linq.Dynamic;
using Abp.Linq.Extensions;

namespace WexOne.WeChat
{
    public class WeChatEventLogAppService: IWeChatEventLogAppService
    {
        private readonly IRepository<WeChatEventLog, long> _eventLogRepository;

        public WeChatEventLogAppService(IRepository<WeChatEventLog, long> eventLogRepository)
        {
            _eventLogRepository = eventLogRepository;
        }

        public async Task ClearEventLog()
        {
            await _eventLogRepository.DeleteAsync(x=>1==1);
        }

        public async Task CreateEventLog(CreateEventLogInput input)
        {
            var x = input.MapTo<WeChatEventLog>();
            await _eventLogRepository.InsertAsync(x);
        }

        public async Task<DatatablePagedResultDto<EventLogListDto>> GetEventLogs(GetEventLogsInput input)
        {
            var query = _eventLogRepository.GetAll()
                .WhereIf(!string.IsNullOrWhiteSpace(input.Filter),x=>x.FromUserName.Contains(input.Filter)|| x.ToUserName.Contains(input.Filter))
                .WhereIf(!string.IsNullOrWhiteSpace(input.MsgType), x => input.MsgType == input.MsgType);

            var count = await query.CountAsync();
            var data = await query.OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            var dataDto=data.MapTo<List<EventLogListDto>>();
            return new DatatablePagedResultDto<EventLogListDto>(count, dataDto);
        }
    }
}
