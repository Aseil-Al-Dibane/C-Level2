using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__Console_Level2.Multithreading.Multithreading_Synchronization
{
    public class CopyTheCode
    {
        //Copy this code to Main page

       /* static int sharedCounter;
        static object lockObject = new object();

        public static void IncrementCounter()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (lockObject)
                    sharedCounter++;
            }
        }

        static void Main()
        {
            Thread mythread = new Thread(IncrementCounter);
            Thread mythread1 = new Thread(IncrementCounter);

            mythread1.Start();
            mythread.Start();

            mythread1.Join();
            mythread.Join();

            Console.WriteLine("Counter: " + sharedCounter);
            Console.ReadKey();
        }
       */
    }
}
