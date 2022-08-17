using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class YoutubeSearch
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string? NextPageToken { get; set; }
        public string? PrevPageToken { get; set; }
        public string RegionCode { get; set; }
        public PageInfo PageInfo { get; set; }
        public List<Items> Items { get; set; }
    }
}
