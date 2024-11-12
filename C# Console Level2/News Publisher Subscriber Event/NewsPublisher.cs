using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.News_Publisher_Subscriber_Event
{
    public class NewsPublisher
    {
        public event EventHandler<NewsArticle> NewNewsPublished;

        public void PublishNews(string Title, string Content)
        {
            NewsArticle NewsArticle = new NewsArticle(Title, Content);
            OnNewNewsPublished(NewsArticle);
        }

        public void OnNewNewsPublished(NewsArticle NewsArticle)
        {
            NewNewsPublished?.Invoke(this, NewsArticle);
        }
    }
}
