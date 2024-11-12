using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesForValidation
{
    public class Person
    {
        [Range(1, 100, errorProvider = "ID must be between 1 to 100")]
        public int ID {  get; set; }
        public string Name { get; set; }

        [Range(20, 90, errorProvider = "Age must be between 20 to 90")]
        public int Age { get; set; }

        public static bool Validations(object obj)
        {
            Type type = obj.GetType();

            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                if (Attribute.IsDefined(property, typeof(RangeAttribute)))
                {
                    var range = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
                    int value = (int)property.GetValue(obj);

                    if (value < range.Min || value > range.Max)
                    {
                        Console.WriteLine($"Validation failed for property [{property.Name}] , {range.errorProvider}");
                        return false;
                    }
                }
            }

            return true;
        }

        public bool Validations()
        {
            Type type = typeof(Person);

            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                if(Attribute.IsDefined(property, typeof(RangeAttribute)))
                {
                    var range = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
                    int value = (int)property.GetValue(this);

                    if(value < range.Min || value > range.Max)
                    {
                        Console.WriteLine($"Validation failed for property [{property.Name}] , {range.errorProvider}");
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
