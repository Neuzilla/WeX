using Abp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WexOne.Dto;
using WexOne.WeChat;
using WexOne.WeChat.Dto;

namespace WexOne.Web.Controllers
{
    public class EventLogsController : Controller
    {
        IWeChatEventLogAppService _eventLogsAppService;

        public EventLogsController(IWeChatEventLogAppService eventLogsAppService)
        {
            _eventLogsAppService = eventLogsAppService;
        }
        // GET: EventLogs
        public ActionResult Index()
        {
            return View();
        }
        [DontWrapResult]
        public async Task<JsonResult> GetEventLogsList(DatatablesPagedAndSortedInputDto input)
        {
            return Json(await _eventLogsAppService.GetEventLogs(input));
        }
    }
}