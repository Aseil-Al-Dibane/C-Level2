using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
namespace C__Console_Level2.Serialization_Deserialization
{
    [Serializable]
    public class PersonJSON
    {
        public string Name { get; set; }
        public int Age { get; set; }

        [NonSerialized]
        public int Number1;

        [NonSerialized]
        public int Number2;

        public int SumTwoNumbers()
        {
            return Number2 + Number1;
        }

        public void Serialization(string Path = "jsonFile.json")
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PersonJSON));
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, this);
                string jsonString = Encoding.UTF8.GetString(stream.ToArray());

                // Save the JSON string to a file (optional)
                File.WriteAllText(Path, jsonString);
            }
            Console.WriteLine("Serialization is Done Successfully!");
        }

        public static void Deserialization(PersonJSON person, string Path = "jsonFile.json")
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PersonJSON));
            using (FileStream stream = new FileStream(Path, FileMode.Open))
            {
                person = (PersonJSON)serializer.ReadObject(stream);
            }
            Console.WriteLine($"Person name is : {person.Name}");
            Console.WriteLine($"Person age is : {person.Age}");
        }
    }
}
