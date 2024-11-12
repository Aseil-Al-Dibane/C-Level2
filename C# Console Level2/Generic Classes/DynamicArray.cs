using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class DynamicArray<T>
    {
        private int _Size;
        private T[] _Array;
        private int _Length = 0;

        public DynamicArray(int size)
        {
            _Array = new T[size];
            _Size = size;
        }

        public void Insert(T value)
        {
            if (_Length < _Size)
            {
                _Array[_Length] = value;
                _Length++;
            }
        }

        public void Pop()
        {
            //To be continue...
        }

        public void Print()
        {
            for (int i = 0; i < _Size; i++)
            {
                Console.WriteLine(_Array[i]);
            }
        }
    }
}
