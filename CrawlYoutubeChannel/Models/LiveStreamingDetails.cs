using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class LiveStreamingDetails
    {
        public string ActiveLiveChatId { get; set; }
        public long ConcurrentViewers { get; set; }
        public DateTime ActualStartTime { get; set; }
        public DateTime ActualEndTime { get; set; }
        public DateTime ScheduledEndTime { get; set; }
        public DateTime ScheduledStartTime { get; set; }
    }
}
