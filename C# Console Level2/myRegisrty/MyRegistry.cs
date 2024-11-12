using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace myRegisrty
{
    public class MyRegistry
    {
        public static void SetValue(string keyPath, string valueName, object Value)
        {
            try
            {
                Registry.SetValue(keyPath, valueName, Value);
                Console.WriteLine("Registry added new data successfully");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(@"UnauthorizedAccessException: Run the program with 
administrative privileges.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string GetValue(string keyPath, string valueName, object defaultValue)
        {
            try
            {
                string Value = Registry.GetValue(keyPath, valueName, defaultValue) as string;

                if (Value != null)
                    return Value;
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(@"UnauthorizedAccessException: Run the program with 
administrative privileges.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
            return "";
        }

        public static bool DeleteValue(string keyPath, string valueName) 
        {
            try
            {
                using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser,
    RegistryView.Registry64))
                {
                    using (RegistryKey registry = registryKey.OpenSubKey(keyPath, true))
                    {
                        if (registry != null)
                        {
                            registry.DeleteValue(valueName);
                            return true;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(@"UnauthorizedAccessException: Run the program with 
administrative privileges.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
    }
}
