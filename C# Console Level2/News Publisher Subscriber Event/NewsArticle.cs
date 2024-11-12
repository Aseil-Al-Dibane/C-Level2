using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.News_Publisher_Subscriber_Event
{
    public class NewsArticle
    {
        public string Title { get; }
        public string Content { get; }

        public NewsArticle(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
