using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Task_Class
{
    public class myTaskFactory
    {
        //Copy this code to Main block
        /*
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            TaskFactory taskFactory = new TaskFactory(token, TaskCreationOptions.AttachedToParent, 
                TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);

            Task task1 = taskFactory.StartNew(() =>
            {
                Console.WriteLine("task 1 start downloading...");
                Thread.Sleep(5000);
                Console.WriteLine("task 1 Finished");
            });

            Task task2 = taskFactory.StartNew(() => 
            {
                Console.WriteLine("task 2 start downloading...");
                Thread.Sleep(5000);
                Console.WriteLine("task 2 Finished");
            });

            try
            {
                Task.WaitAll(task1, task2);
                Console.WriteLine("\nTasks completed");
            }
            catch (AggregateException ae)
            {
                foreach(var exception in ae.InnerExceptions)
                    Console.WriteLine(exception.Message);
                throw;
            }

            //To clean resources in ram
            cts.Dispose();

            Console.ReadKey();
         */
    }
}
