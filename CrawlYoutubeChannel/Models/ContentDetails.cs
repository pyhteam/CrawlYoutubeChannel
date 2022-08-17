using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class ContentDetails
    {
        public string Duration { get; set; }
        public string Dimension { get; set; }
        public string Definition { get; set; }
        public string Caption { get; set; }
        public bool LicensedContent { get; set; }
        public ContentRating? ContentRating { get; set; }
        public string Projection { get; set; }
    }
}
