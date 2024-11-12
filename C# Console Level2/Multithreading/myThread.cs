using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class myThread
    {
        Thread t1;

        public myThread(Action action)
        {
            //t1 = new Thread(ThreadMethod1);
            t1 = new Thread(() => action());
        }

        public void Start()
        {
            // Note that your program is the main thread.
            // Create a new thread and start it
            t1.Start();
        }

        public void Join()
        {
            t1.Join();
        }

        public static void ThreadMethod1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread Method1: " + i);
                Thread.Sleep(1000);
            }
        }

        public static void ThreadMethod2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread Method2: " + i);
                Thread.Sleep(1000);
            }
        }

        public static void MainThreadMethod()
        {
            // Main thread continues its execution
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(1000); // Sleep for 1 second
            }
        }

        public static void DownloadAndPrintURL(string url)
        {
            string webPage = "";

            using (WebClient webClient = new WebClient())
            {
                webPage = webClient.DownloadString(url);
            }

            Console.WriteLine($"Web page {url} has {webPage.Length} charachters.");
        }
    }
}
