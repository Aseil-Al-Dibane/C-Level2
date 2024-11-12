using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Nullable_Data_Types
{
    public class NullableClass
    {
        public static void NullableMethod()
        {
            // Declare a nullable int using Nullable<T>
            Nullable<int> nullableInt1 = null;


            // Shorthand notation using int?
            int? nullableInt2 = null;

            // Check if the nullable ints have values
            if (nullableInt1.HasValue)
            {
                Console.WriteLine("nullableInt1 has a value: " + nullableInt1.Value);
            }
            else
            {
                Console.WriteLine("nullableInt1 is null.");
            }


            if (nullableInt2.HasValue)
            {
                Console.WriteLine("nullableInt2 has a value: " + nullableInt2.Value);
            }
            else
            {
                Console.WriteLine("nullableInt2 is null.");
            }


            // Using the null-coalescing operator
            int result = nullableInt2 ?? 0;
            Console.WriteLine("Using null-coalescing operator: " + result);


            // Using the null-conditional operator
            string stringValue = nullableInt2?.ToString();
            Console.WriteLine("String representation: " + (stringValue ?? "null"));
        }


        //-----------------------------------------------------------------------------------------//
        //Example 2

        public static void Procedure1(string Name, Nullable<int> Age)
        {

            Console.WriteLine("\nName is :" + Name);

            if (Age.HasValue)
            {
                Console.WriteLine("Age is :" + Age.ToString());
            }
            else
            {
                Age = -1;
                Console.WriteLine($"Age is {Age}");
            }


        }

        public static void Procedure2(string Name, int? Age)
        {

            Console.WriteLine("\nName is :" + Name);

            if (Age.HasValue)
            {
                Console.WriteLine("Age is :" + Age.ToString());
            }
            else
            {
                Age = -1;
                Console.WriteLine($"Age is {Age}");
            }


        }
    }
}
