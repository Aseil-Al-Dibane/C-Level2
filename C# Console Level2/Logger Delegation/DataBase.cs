using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Logger__Delegation
{
    public class DataBase
    {
        public static void LogToDataBase(string messege)
        {
            /*
             
            Code

             */
            Console.WriteLine($"Messege : {messege} sent to database");
        }
    }
}
