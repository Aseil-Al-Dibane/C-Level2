#define TracingMode_On
using C__Console_Level2.New_Order_Event;
using C__Console_Level2.News_Publisher_Subscriber_Event;
using System;
using C__Console_Level2.Logger__Delegation;
using C__Console_Level2.Func_And_Action_And_Predicate_Delegates;
using C__Console_Level2.Lambda_Expression;
using static System.Math; //To use Math class static methods directly
using C__Console_Level2.C__using_for_Resource_Management;
using C__Console_Level2.Nullable_Data_Types;
using C__Console_Level2.Serialization_Deserialization;
using C__Console_Level2.Conditional_Attribute_Examples;
using C__Console_Level2.Refliction;
using DynamicallyCreateObjectsAndInvokeMethods;
using ReflectionWithCustomAttributes;
using CustomAttributesForValidation;
using SpecialComments;
using System.Runtime.InteropServices;
using GenericClasses;
using myRegisrty;
using Microsoft.Win32;
using System.Security.Authentication;
using myEventLog;
using System.Configuration;
using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Runtime.Remoting.Channels;
using Cryptography;
using System.IO;
using Cryptography.Encrypt_photo_example;
using Operator_Overloading;
using Multithreading;
using System.Threading;
using System.Net;
using System.Threading.Tasks;
using DVLD_BuisnessLayer;
using Task_Class;
using System.Collections;

namespace C__Console_Level2
{
    internal class Program
    {

        static void Main()
        {
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
            }

            //To clean resources in ram
            cts.Dispose();
            Console.ReadKey();
        }
    }
}
