using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class Suggestions
    {
        public string[] ProcessingErrors { get; set; }
        public string[] ProcessingWarnings { get; set; }
        public string[] ProcessingHints { get; set; }
        public TagSuggestions TagSuggestions { get; set; }
    }
}
