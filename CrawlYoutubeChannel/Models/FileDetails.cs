using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class FileDetails
    {
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string FileType { get; set; }
        public string Container { get; set; }
        public VideoStreams VideoStreams { get; set; }
        public AudioStreams AudioStreams { get; set; }
        public long DurationMs { get; set; }
        public long BitrateBps { get; set; }
        public string CreationTime { get; set; }
    }
}
