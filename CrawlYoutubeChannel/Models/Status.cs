using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlYoutubeChannel.Models
{
    public class Status
    {
        public string UploadStatus { get; set; }
        public string FailureReason { get; set; }
        public string RejectionReason { get; set; }
        public string PrivacyStatus { get; set; }
        public string License { get; set; }
        public bool Embeddable { get; set; }
        public string PublicStatsViewable { get; set; }
        public string MadeForKids { get; set; }
        public string SelfDeclaredMadeForKids { get; set; }
        public DateTime PublishAt { get; set; }


    }
}
