using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI
{
    public class PostMessageRequest
    {
        public string channel { get; set; }
        public string text { get; set; }
        public bool as_user { get; set; }
        public string username { get; set; }
        public IEnumerable<SlackAPI.Attachment> attachments { get; set; }
        public string icon_emoji { get; set; }
        public string icon_url { get; set; }
        public bool link_names { get; set; }
        public bool mrkdwn { get; set; }
        public ParseMode parse { get; set; }
        public bool reply_broadcast { get; set; }
        public bool unfurl_link { get; set; }
        public bool unfurl_media { get; set; }
        public string thread_ts { get; set; }
    }

    public enum ParseMode
    {
        full,
        none
    }
}
