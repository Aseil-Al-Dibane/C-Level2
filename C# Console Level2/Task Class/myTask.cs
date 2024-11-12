using DVLD_BuisnessLayer;
using Microsoft.Win32;
using myRegisrty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class
{
    public class myTask
    {
        public delegate void CallbackEventArgs(object sender, CustomEventArgs e);
        public static CallbackEventArgs Callback;

        public static async Task DownloadFileAsync(string fileName, CallbackEventArgs callback)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 0)
                        Console.Write($"Downloading...");
                    Console.Write($"{i}%  ");
                }
                CustomEventArgs customEvent = new CustomEventArgs(fileName);
                callback(null, customEvent);
            });
        }

        public static void OnDownloadCompleted(object sender, CustomEventArgs customEvent)
        {
            Console.WriteLine($"\nFile: {customEvent.FileName} downloaded successfully!");
        }

        //-----------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------//

        static public async Task myTaskMethodAsync(int userID)
        {
            Task<int> Result = GetPersonIDAsync(userID);
            Console.WriteLine("Doing another task...");
            int result = await Result;
            Console.WriteLine(result);
        }

        public static void SaveToRegistryAsync(string url)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\URLs";
            string valueName = "url";
            string Value = url;

            try
            {
                Registry.SetValue(keyPath, valueName, Value, RegistryValueKind.String);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static async Task DownloadAndPrintURLTaskAsync(string url, Action<string> OnTaskCompleted)
        {
            string webPage = "";

            using (WebClient webClient = new WebClient())
            {
                webPage = await webClient.DownloadStringTaskAsync(url);
                Console.WriteLine($"url: {url} contains: {webPage.Length}characters");
            }

            OnTaskCompleted?.Invoke(webPage);
        }

        private static async Task<int> GetPersonIDAsync(int userID)
        {
            int personID = -1;
            await Task.Run(() =>
            {
                clsUser user = clsUser.GetUser(userID);
                if (user != null)
                    personID = user.PersonID;
            });
            return personID;
        }



        //Copy this code to Main page
        /*
          public struct stDataEventArgs
          {
              public int ID {  get; set; }
              public string Name { get; set; }
          
              public stDataEventArgs(int id, string name)
              {
                  ID = id;
                  Name = name;
              }
          }
          
          internal class Program
          {
              public delegate void CallBackEventHandler(object sender, stDataEventArgs e);
              public static event CallBackEventHandler CallBack;
          
              public static async Task DBSendRequest()
              {
                  Console.WriteLine("Requesting data from database...");
                  await Task.Delay(5000);
          
                  stDataEventArgs e = new stDataEventArgs(1, "Aseil");
                  CallBack?.Invoke(null, e);
              }
          
              public static void DBGetRequest(object sender, stDataEventArgs e)
              {
                  Console.WriteLine("\nYour data request accepted");
                  Console.WriteLine($"ID: {e.ID}\nName: {e.Name}");
              }
          
              public static void AnotherTask()
              {
                  Console.WriteLine();
                  Console.WriteLine("Doing another work...");
              }
          
              static void Main()
              {
                  CallBack += DBGetRequest;
                  Task task = DBSendRequest();
                  
                  AnotherTask();
                  Console.ReadKey();
              }
          }*/
    }
}
