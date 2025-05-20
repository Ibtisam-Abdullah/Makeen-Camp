using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Day4
{
    internal class MyArray<T>
    {
        public T[] array;

        public void Add(T element)
        {
            if (array is null)
            {
                array = new T[] { element };
            }
            else
            {
                int length = array.Length;
                T[] temp = new T[length+1];
                for (int i = 0; i < length; i++)
                {
                    temp[i] = array[i];
                }
                temp[temp.Length - 1] = element;
                array = temp;
            }
        }

        public void display()
        {
            foreach (T element in array)
            {
                Console.WriteLine($"{element}");
            }
        }

        public void remove()
        {

        }

        public int Count()
        {
            return array.Length;
        }

        public bool isEmpty()
        {
            if (array.Length == 0)
            {
                return true;
            }
            return false;
        }


    }
}
