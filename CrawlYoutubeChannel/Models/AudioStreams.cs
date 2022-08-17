using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class AudioStreams
    {
        public int ChannelCount { get; set; }
        public string Codec { get; set; }
        public long BitrateBps { get; set; }
        public string Vendor { get; set; }


    }
}
