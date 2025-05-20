namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<data-type> [] <array-name> = new <data-type> [size]
            int[] numbers = new int[5];
            //Console.WriteLine(numbers);
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            //Console.WriteLine(numbers[2..4]);
            string[] names = new string[3] { "A", "B", "C" };
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names.Length);

            /* multidimention array -> it's like a table,, int[row],[column] matrix = new int[3][4];
             * OR we can do it like int [,] matrix = new int[3,4]; */
            int[,] num = new int[2, 2];
            int[,] n = { {1, 2},
                         {1, 3},
             };

            // other type of array is jagged array (array inside array), use to initialize list
            int[][] jaggedArray = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5},
                new int[] {6, 7, 8, 9},
            };
            //Console.WriteLine(jaggedArray); 



            int[] numb = { 1, 2, 3, 4, 5, 6 };
            int[] slice = numb[2..4]; // used to slice spicific elements on array in new array
            int[] slice1 = numb[2..]; // used to sliice from known position till the end of the array
            int[] slice2 = numb[..3]; // used to slice from the beginign till specific position
            int[] slice3 = numb[2..^2]; // to ignore the first two and the last two of the array
            //Console.WriteLine(slice[1]);

            // let the user enter a number then print odd or even numbers using ternary(?)
            Console.Write("Enter numer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string result = (x % 2 == 0) ? "even" : "odd";
            Console.WriteLine(result);

            //Console.Write("Enter your name: ");
            string name = null; //Console.ReadLine();
            string username = name == null ? "no name" : name;
            string username1 = name ?? name;
            Console.WriteLine(username);

            int y = 3;
            y++;
            Console.WriteLine(y);
            Console.WriteLine(y++); // the code read then add but if we put ++y the code will add then read
            Console.WriteLine(y);

            // if condition 
            Console.Write("Enter number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            else
            {
                Console.WriteLine("enter positive number");
            }

            // complex if condition  <if, else if>
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>=b && a>=c)
            {
                Console.WriteLine("Largest number is: " + a);
            }
            else if (b>=c && b>=a)
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }


            // create calculater using complex if condition
            Console.Write("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation: ");
            string s = (Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (s == "+")
            {
                int result = n1 + n2;
                Console.WriteLine("addition result: " + result);
            }
            else if (s == "-")
            {
                int result = n1 - n2;
                Console.WriteLine("subtraction result: " + result);

            }
            else if (s == "*")
            {
                int result = n1 * n2;
                Console.WriteLine("multiplication result: " + result);
            }
            else if (s == "/")
            {
                int result = n1 / n2;
                Console.WriteLine("division result: " + result);
            }
            else
            {
                Console.WriteLine("please enter one of these operation (+, -, *, /)!");
            }


            //listed if condition
            Console.Write("Enter your gender: ");
            string gender = (Console.ReadLine());
            if (gender.ToUpper() == "M")
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (25 <= age && age <= 30)
                {
                    Console.WriteLine("Accepted");
                }
                else
                {
                    Console.WriteLine("Rejected");
                }
            }
            else
            {
                Console.WriteLine("Rejected");
            }

            //switch condition.. check multible cases
            string day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("Sunday");
                    break;
                case "2":
                    Console.WriteLine("Monday");
                    break;
                case "3":
                    Console.WriteLine("Tuesday");
                    break;
                case "4":
                    Console.WriteLine("Wednsday");
                    break;
                case "5":
                    Console.WriteLine("Thirsday");
                    break;
                case "6":
                    Console.WriteLine("Friday");
                    break;
                case "7":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

    }
}
