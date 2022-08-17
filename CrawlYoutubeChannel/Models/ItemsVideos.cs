using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class ItemsVideos
    {
        public string? Kind { get; set; }
        public string? Etag { get; set; }
        public string? Id { get; set; }
        public Snippet? Snippet { get; set; }
        public ContentDetails? ContentDetails { get; set; }
        public Statistics? Statistics { get; set; }
       


    }
}
