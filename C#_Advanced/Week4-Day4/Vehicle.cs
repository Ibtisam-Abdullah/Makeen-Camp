using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Day4
{
    internal class Vehicle
    {
        public static void print<T>(T x)
        {
            Console.WriteLine($"data type: {typeof(T)}");
            Console.WriteLine(x);
        }

    }
}
