using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class YoutubeVideos
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public List<ItemsVideos> Items { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
