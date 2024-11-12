using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Pointer
    {
        private int X ; 
        private int Y;

        private string x;
        private string y;

        public Pointer(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Pointer(string x, string y)
        {
            this.x = x;
            this.y = y;
        }

        public static Pointer operator +(Pointer pointer1, Pointer pointer2)
        {
            return new Pointer(pointer1.X + pointer2.X, pointer1.Y + pointer2.Y);
        }

        //To concatenate two strings:
        //public static Pointer operator +(Pointer pointer1, Pointer pointer2)
        //{
        //    return new Pointer(pointer1.x + pointer2.x, pointer1.y + pointer2.y);
        //}

        public static Pointer operator -(Pointer pointer1, Pointer pointer2)
        {
            return new Pointer(pointer1.X - pointer2.X, pointer1.Y - pointer2.Y);
        }

        public static Pointer operator /(Pointer pointer1, Pointer pointer2)
        {
            try
            {
                return new Pointer(pointer1.X / pointer2.X, pointer1.Y / pointer2.Y);
            }
            catch(DivideByZeroException)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static Pointer operator *(Pointer pointer1, Pointer pointer2)
        {
            return new Pointer(pointer1.X * pointer2.X, pointer1.Y * pointer2.Y);
        }

        public static bool operator ==(Pointer pointer1, Pointer pointer2)
        {
            return (pointer1.X == pointer2.X && pointer1.Y == pointer2.Y);
        }

        public static bool operator !=(Pointer pointer1, Pointer pointer2)
        {
            return (pointer1.X != pointer2.X && pointer1.Y != pointer2.Y);
        }

        public override string ToString()
        {
            return (x != null && y != null) ? x + ", " + y : $"{X}, {Y}";
        }
    }
}
