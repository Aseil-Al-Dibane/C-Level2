﻿using C__Console_Level2.Refliction.Reflection_Example_2___Dynamically_Create_Objects_and_Invoke_Methods;
using C__Console_Level2.Serialization_Deserialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicallyCreateObjectsAndInvokeMethods
{
    public class myDynamicReflection
    {
        private static string _GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }

        /// <summary>
        /// Access The Properties and Methods of 'MyClass' Class 
        /// </summary>
        public static void AccessMyClass()
        {
            // Get the type information for MyClass
            Type myClassType = typeof(MyClass);

            // Get and display information about the type
            Console.WriteLine($"Type Name: {myClassType.Name}");
            Console.WriteLine($"Full Name: {myClassType.FullName}");

            // Get the properties of MyClass
            Console.WriteLine("\nProperties:");
            foreach (var property in myClassType.GetProperties())
            {
                Console.WriteLine($"Property Name: {property.Name}, Type: {property.PropertyType}");
            }

            // Get the methods of MyClass
            Console.WriteLine("\nMethods:\n");
            foreach (var method in myClassType.GetMethods())
            {
                Console.WriteLine($"\t{method.ReturnType} {method.Name}({_GetParameterList(method.GetParameters())})");
            }


            // Create an instance of MyClass
            object myClassInstance = Activator.CreateInstance(myClassType);


            // Set the value of Property1 using reflection
            myClassType.GetProperty("Property1").SetValue(myClassInstance, 42);
            Console.WriteLine("\nSet Property1 to 42 using reflection:");


            // Get the value of Property1 using reflection
            Console.WriteLine("\nGetting Property1 is value using reflection:");
            int Property1Value = (int)myClassType.GetProperty("Property1").GetValue(myClassInstance);
            Console.WriteLine($"\tProperty1 Value: {Property1Value}");


            //now how to execute methods using reflection:
            Console.WriteLine("\nExecuting Methods using reflection:\n");

            // Invoke the Method1 using reflection
            myClassType.GetMethod("Method1").Invoke(myClassInstance, null);

            // Invoke Method2 with parameters using reflection
            object[] parameters = { 100, "Mohammed Abu-Hadhoud" };
            myClassType.GetMethod("Method2").Invoke(myClassInstance, parameters);
        }
    }
}
