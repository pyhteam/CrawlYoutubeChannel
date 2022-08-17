using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class VideoStreams
    {
        public int WidthPixels { get; set; }
        public int HeightPixels { get; set; }
        public double FrameRateFps { get; set; }
        public string AspectRatio { get; set; }
        public string Codec { get; set; }
        public long BitrateBps { get; set; }
        public string Rotation { get; set; }
        public string Vendor { get; set; }
    }
}
