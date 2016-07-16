using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.WeChat
{
    [Table("Wex_WeChatEventLogs")]
    public class WeChatEventLog: CreationAuditedEntity<long>
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
