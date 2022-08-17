using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class RegionRestriction
    {
        public string[] Blocked { get; set; }
        public string[] Allowed { get; set; }
    }
}
