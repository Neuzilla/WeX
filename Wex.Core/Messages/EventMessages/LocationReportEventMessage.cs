using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Messages.EventMessages
{
    /// <summary>
    /// location report event when user enters an OA that has enabled location collection 
    /// </summary>
    public class LocationReportEventMessage : WeChatRequestEventMessageBase
    {
        public override EventType Event
        {
            get { return EventType.LOCATION; }
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Precision { get; set; }
    }
}
