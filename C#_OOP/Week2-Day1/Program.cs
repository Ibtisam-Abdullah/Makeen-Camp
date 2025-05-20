namespace Week2_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //give the summition of the numbers entered by the user
            Console.Write("Enter numbers: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (numbers != 0)
            {
                int digit = numbers % 10;
                sum += digit;
                numbers /= 10;
            }
            Console.WriteLine("Sum = " + sum);

            // to print the factorial of a number entered by the user
            Console.WriteLine("Enter numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int f = 1; f <= num; f++)
            {
                result *= f;
            }
            Console.WriteLine("Factorial of a number:" + result);

            //// 2 dimention array need 2 loops
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
            };

            for (int r = 0; r < matrix.GetLength(0); r++) // r for rows of the array
            {
                for (int c = 0; c < matrix.GetLength(1); c++) // c for the column of the array
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }

            // FOR EACH LOOP -> while <for> used for countion and numbers <foreach> can be used for the strings
            // like going through each character on the string
            string s = "HELLO!";
            foreach (char character in s)
            {
                Console.WriteLine(character + " ");
            }

            // to print a triangle with four rows 
            int h = 4;
            for (int t = 1; t <= h; t++)
            {
                for (int j = 1; j <= t; j++)
                {
                    Console.Write(j + "  "); // print the current value with spacing
                }
                Console.WriteLine();
            }

            //differance between <continue> and <breake>
            for (int i = 0; i <= 6; i++)
            {
                if (i == 4)
                {
                    continue; // countinue but make the loop skip 4
                }
                Console.WriteLine(i);
            }

            for (int y = 0; y <= 6; y++)
            {
                if (y == 4)
                {
                    break; //  break will stop looping when reach 4
                }
                Console.WriteLine(y);
            }

            // GoTo
            int x = 5;
Point:
            Console.WriteLine("GoTo");
            if (x <= 7)
            {
                Console.WriteLine("smaller");
                goto Point; // it will repeate the block of code infinitly because we make it go to point which comes before if statement
            }

            // Casting > convert 
            string n1 = "5";
            string n2 = "6";
            Console.WriteLine(int.Parse(n1)+int.Parse(n2)); // there is Convert.ToInt32 works in the same way 
            // int.Prse caanot convert the null into integer while Convert.ToInt32 will give the null value(0)

            // practice: 
            Console.WriteLine("Enter grades: ");
            string grades = Console.ReadLine();

            int[] g = grades.Split(' ').Select(int.Parse).ToArray();
            foreach (int val in g)
            {
                if (val >= 0 && val <= 50)
                {
                    Console.WriteLine("F");
                }
                else if (val < 70)
                {
                    Console.WriteLine("D");
                }
                else if (val < 80)
                {
                    Console.WriteLine("C");
                }
                else if (val < 90)
                {
                    Console.WriteLine("B");
                }
                else if (val >=  90 && val <= 100)
                {
                    Console.WriteLine("A");
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }

            // array.sort() -> this method sorts the elements ascending
            int[] ints = { 40, 1, 3, 56, 19, 39 };
            Array.Sort(ints);
            Array.Reverse(ints); // thiw will give the elements in a revers from the last one to the first one
                                 // but if we print it after the sort it will sort it first then revers it
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }

            // copy from array to another array
            int[] num1 = { 60, 34, 21, 50, 46 }; // source
            int[] num2 = { 21, 61, 78 }; // destination
            // start take from num1[0].. replace num2[1] and num2[2] with num1[0] and num1[1]
            Array.Copy(num1, 0, num2, 1, 2); // output = {21, 60, 34}
            Console.Write("Copied array (num2): ");
            foreach (int number in num2)
            {
                Console.Write(num + " ");
            }


        }
    }
}
