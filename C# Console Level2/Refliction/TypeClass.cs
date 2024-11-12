using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Refliction
{
    public class TypeClass
    {
        public static void TypeOfAnyObject(object Class)
        {
            Type tp = Class.GetType();
            Console.WriteLine($"The Namespace is : {tp.Namespace}");
            Console.WriteLine($"The Name is : {tp.Name}");
            Console.WriteLine($"The Fullname is : {tp.FullName}");
            Console.WriteLine($"Is Class ? : {tp.IsClass}");
        }

        public static void TypeOfString()
        {
            Type tp = typeof(string);
            Console.WriteLine($"The Namespace is : {tp.Namespace}");
            Console.WriteLine($"The Name is : {tp.Name}");
            Console.WriteLine($"The Fullname is : {tp.FullName}");
            Console.WriteLine($"Is Class ? : {tp.IsClass}");
        }

        public static void TypeOfInt()
        {
            Type tp = typeof(int);
            Console.WriteLine($"The Namespace is : {tp.Namespace}");
            Console.WriteLine($"The Name is : {tp.Name}");
            Console.WriteLine($"The Fullname is : {tp.FullName}");
            Console.WriteLine($"Is Class ? : {tp.IsClass}");
        }
    }
}
