using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    internal class VideosResult
    {
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoId { get; set; }
        public List<string> Tags { get; set; }
        public string ChannelId { get; set; }
        public string ChannelTitle { get; set; }
        public long View { get; set; }
        public string Duration { get; set; }
        public string Relution { get; set; }
        public DateTime PublishedAt { get; set; }

    }
}
