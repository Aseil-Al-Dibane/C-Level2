using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace C__Console_Level2.Serialization_Deserialization
{
    [Serializable]
    public class PersonBinary
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

        public void Serialization(string Path = "binaryFile.bin")
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(Path, FileMode.Create))
            {
                formatter.Serialize(stream, this);
            }
            Console.WriteLine("Serialization is Done Successfully!");
        }

        public static void Deserialization(PersonBinary person, string Path = "binaryFile.bin")
        {
            BinaryFormatter serializer = new BinaryFormatter();

            // Deserialize the object back
            using (FileStream stream = new FileStream(Path, FileMode.Open))
            {
                person = (PersonBinary)serializer.Deserialize(stream);
            }
            Console.WriteLine($"Person name is : {person.Name}");
            Console.WriteLine($"Person age is : {person.Age}");
        }
    }
}
