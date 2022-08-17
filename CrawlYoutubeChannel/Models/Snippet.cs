using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class Snippet
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Thumbnails? Thumbnails { get; set; }
        public string ChannelTitle { get; set; }
        public List<string>? Tags { get; set; }
        public string CategoryId { get; set; }
        public string LiveBroadcastContent { get; set; }
        public string DefaultLanguage { get; set; } 
        public Localized? Localized { get; set; } 
        public string? DefaultAudioLanguage { get; set; }
        

    }
}
