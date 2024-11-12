using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Refliction
{
    public class NavigateLibrary
    {
        public static void NavigateAnyObject(object Class)
        {
            // Get the System.Object type
            Type type = Class.GetType();


            if (type != null)
            {
                Console.WriteLine($"Methods of the {type.Name} class:\n");


                // Get all public methods of the System.Object class
                var objectMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                    .OrderBy(method => method.Name);


                foreach (var method in objectMethods)
                {
                    Console.WriteLine($"\t{method.ReturnType} {method.Name}({_GetParameterList(method.GetParameters())})");
                }
            }
            else
            {
                Console.WriteLine($"{type.Name} type not found.");
            }
        }

        public static void NavigateStringType()
        {
            // Get the System.String type
            Type stringType = typeof(string);


            if (stringType != null)
            {
                Console.WriteLine($"Methods of the System.String class:\n");


                // Get all public methods of the System.String class
                var stringMethods = stringType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .OrderBy(method => method.Name);


                foreach (var method in stringMethods)
                {
                    Console.WriteLine($"\t{method.ReturnType} {method.Name}({_GetParameterList(method.GetParameters())})");
                }
            }
            else
            {
                Console.WriteLine("System.String type not found.");
            }
        }

        public static void NavigateBooleanType()
        {
            // Get the assembly containing the System.Boolean type
            Assembly mscorlib = typeof(bool).Assembly;


            // Get the System.Boolean type
            Type boolType = mscorlib.GetType("System.Boolean");

            if (boolType != null)
            {
                Console.WriteLine($"Methods of the System.Boolean struct:\n");

                // Get all public methods of the System.Boolean struct
                var boolMethods = boolType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                    .OrderBy(method => method.Name);

                foreach (var method in boolMethods)
                {
                    Console.WriteLine($"\t{method.ReturnType} {method.Name}({_GetParameterList(method.GetParameters())})");
                }
            }
            else
            {
                Console.WriteLine("System.Boolean type not found.");
            }
        }

        private static string _GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
    }
}
