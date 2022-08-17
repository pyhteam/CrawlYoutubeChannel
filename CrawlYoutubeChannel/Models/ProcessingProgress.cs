using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class ProcessingProgress
    {
        public long PartsTotal { get; set; }
        public long PartsProcessed { get; set; }
        public long TimeLeftMs { get; set; }

    }
}
