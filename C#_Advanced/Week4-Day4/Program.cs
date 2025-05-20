using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week4_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle.print("Khawla");
            //Vehicle.print(6);

            MyArray<int> num = new MyArray<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);
            num.display();
            Console.WriteLine(num.isEmpty());
            Console.WriteLine(num.Count());

        }
    }
}
