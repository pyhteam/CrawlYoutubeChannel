using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class ProcessingDetails
    {
        public string ProcessingStatus { get; set; }
        public string ProcessingFailureReason { get; set; }
        public string ProcessingIssuesAvailability { get; set; }
        public ProcessingProgress ProcessingProgress { get; set; }
        public string FileDetailsAvailability { get; set; }
        public string TagSuggestionsAvailability { get; set; }
        public string EditorSuggestionsAvailability { get; set; }
        public string ThumbnailsAvailability { get; set; }

    }
}
