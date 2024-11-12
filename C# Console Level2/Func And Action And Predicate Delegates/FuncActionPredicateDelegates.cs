using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Func_And_Action_And_Predicate_Delegates
{
    public class FuncActionPredicateDelegates
    {
        public Func<int, int, int> Multiplication = (x, y) => x * y;
        public Func<int, int> Square = _Function;
        public Action ParameterLessMethod = _Method1;
        public Action<int, string> ParameterizedMethod = _Method2;
        public Predicate<int> IsEvenPredicate = _IsEven;

        private static void _Method1()
        {
            Console.WriteLine("Hello Im a Method1");
        }

        private static void _Method2(int number, string text)
        {
            Console.WriteLine($"Number : {number}\t\tText : {text}");
        }

        private static int _Function(int X)
        {
            return X * X;
        }

        private static bool _IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
