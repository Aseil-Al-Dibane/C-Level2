using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Lambda_Expression
{
    public class LambdaExpression
    {
        //With Lambda Shortcut
        public void ExecuteOperationWithLambda(int Number1,  int Number2, Func<int, int, int> Operation)
        {
            int result = Operation(Number1, Number2);
            Console.WriteLine($"Result = {result}");
        }

        //--------------------------------------------------------------------------------------------

        //Without Lambda
        public delegate int Operation(int Number1, int Number2);

        public void ExecuteOperationWithoutLambda(int Number1, int Number2, Operation operation)
        {
            int result = operation(Number1, Number2);
            Console.WriteLine($"Result = {result}");
        }

        public int Add(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

        public int Sub(int Number1, int Number2)
        {
            return Number1 - Number2;
        }

    }
}
