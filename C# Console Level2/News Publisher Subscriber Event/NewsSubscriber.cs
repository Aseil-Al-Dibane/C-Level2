using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.News_Publisher_Subscriber_Event
{
    public class NewsSubscriber
    {
        public string SubscriberName { get; set; }

        public NewsSubscriber(string SubscriberName) 
        {
            this.SubscriberName = SubscriberName;
        }

        public void Subscribe(NewsPublisher publisher)
        {
            publisher.NewNewsPublished += HandleNewNewsPublished;
        }

        public void UnSubscribe(NewsPublisher publisher)
        {
            publisher.NewNewsPublished -= HandleNewNewsPublished;
        }


        public void HandleNewNewsPublished(object sender, NewsArticle newsArticle)
        {
            Console.WriteLine();
            Console.WriteLine($"New News For Subscriber {SubscriberName}");
            Console.WriteLine($"Title : {newsArticle.Title}");
            Console.WriteLine($"Content : {newsArticle.Content}");
            Console.WriteLine();
        }
    }
}
