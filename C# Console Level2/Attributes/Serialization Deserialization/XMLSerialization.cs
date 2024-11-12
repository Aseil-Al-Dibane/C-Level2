using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C__Console_Level2.Serialization_Deserialization
{
    [Serializable]
    public class PersonXML
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

        public void Serialization(string Path = "xmlFile.xml")
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PersonXML));

            using(TextWriter writer = new StreamWriter(Path))
            {
                serializer.Serialize(writer, this);
            }
            Console.WriteLine("Serialization is Done Successfully!");
        }

        public static void Deserialization(PersonXML person, string Path = "xmlFile.xml")
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PersonXML));

            using (TextReader reader = new StreamReader(Path))
            {
                person = (PersonXML)serializer.Deserialize(reader);
            }
            Console.WriteLine($"Person name is : {person.Name}");
            Console.WriteLine($"Person age is : {person.Age}");
        }
    }
}
