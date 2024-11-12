using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Conditional_Attribute_Examples
{
    public class ObsoleteAttributeClass
    {
        [Obsolete("This method will be deprecated in the future, We recommend to use NewSplitText method")]
        public static void SplitText(string Text, char Seperator)
        {
            string[] arrString = Text.Split(Seperator);

            foreach (var item in arrString)
            {
                Console.WriteLine(item);
            }
        }

        public static void NewSplitText(string Text, char Seperator)
        {
            string[] arrString = Text.Split(Seperator);

            foreach (var item in arrString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
