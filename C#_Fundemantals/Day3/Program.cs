namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using switch without repeating for each case.
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("Odd");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("Even");
                    break;
                default:
                    Console.WriteLine("Number out of range");
                    break;
            }

            /* if we want the switch to deside the data type>> all data types are objects. 
             * if we change the object to int the first case will run but in this situation the second one
             * because o = string */
            object o = "Khawla";
            switch (o)
            {
                case int i:
                    Console.WriteLine(i*i);
                    break;
                case string s:
                    Console.WriteLine(s.ToUpper()); // this case will run since the object gives string value 
                    break;
                case double d:
                    Console.WriteLine(Math.Floor(d));
                    break;
                case float f:
                    Console.WriteLine(Math.Floor(f));
                    break;
                default:
                    Console.WriteLine("Done");
                    break;
            }

            //if we want to use int and double cases as the same time
            object O = 3;
            switch (o)
            {
                case int or double:
                    Console.WriteLine((dynamic)O*2); // if object O is intejer or double this case will run 
                    break;
                case string s:
                    Console.WriteLine(s.ToUpper());
                    break;
                case float f:
                    Console.WriteLine(Math.Floor(f));
                    break;
                default:
                    Console.WriteLine("Done");
                    break;
            }

            // advance switch
            bool isBusniess = true;
            bool hasBit = true;
            switch (isBusniess)
            {
                case bool j when hasBit == true:      //this is when the case doesn't relay in one codition
                    Console.WriteLine("more chrge");
                    break;
                case bool j:
                    Console.WriteLine("go inside");
                    break;
                default:
                    Console.WriteLine("hello");
                    break;
            }

            //expression switch
            int cardNo = 13;
            string cardName = cardNo switch
            {
                //<pattern> => <result> 
                //the result here is a string <cardNme>
                1 => "ACE",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                _ => cardNo.ToString() // we need to convert it to string becase the cardName is string
            };

            // iteration & collecting all togather (looping) repeating a block of codeor statement..
            // WHILE LOOP
            int n = 0; // start point
            while (n < 10) // the condition determain when the loop stop. check the condition and repeat if true till  reach false
            {
                Console.WriteLine(n);
                n++;    // start from 0 and stop when met the condition 10 
                // i += 1 
                // i = i + 1
            }

            // practice 
            int even = 0;
            while (even <= 10)
            {
                Console.WriteLine(even);
                even += 2;
            }

            // DO WHILE 
            // do before check
            int x = 0;
            do
            {
                Console.WriteLine("x: " + x);
                x++; // incrase by one then check while condition..
                     // even it doesn't meet the codition it will print the first number
                     // because it print then check
            }
            while (x < 10); // repeat the do block while the condition true 


            // practice - guessing game
            int guess;
            do
            {
                Console.Write("Guess the number from 1 to 20: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == 8)
                {
                    Console.WriteLine("you guess the right number!!");
                }
                else if (guess > 8)
                {
                    Console.WriteLine("go down!");
                }
                else
                {
                    Console.WriteLine("go up!");
                }
            }
            while (guess != 8);

            // other way for the game:
            int key = 20;
            int No;
            bool flage = true;
            Console.WriteLine("Guess the number");
            while (flage)
            {
                No = Convert.ToInt32(Console.ReadLine());
                if (No > key)
                {
                    Console.WriteLine("go down!");
                }
                else if (No < key)
                {
                    Console.WriteLine("go up!");
                }
                else
                {
                    Console.WriteLine("you guess the right number!!");
                    flage = false;
                }
            }


            // FOR LOOP -> used when you know how many times you need to loop.
            for (int i1 = 0; i1 < 5; i1++) //the initil and condition and increment all in one place 
            {
                Console.WriteLine(i1);
            }

            // for loop with array
            int[] num1 = { 10, 20, 30, 40 };
            for (int ind = 0; ind < num1.Length; ind++)
            {
                Console.Write(num1[ind] + " ");
            }

            //practice - give factors of number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int f = 1; f<=number; f++)
            {
                if (number % f ==0)
                {
                    Console.WriteLine(f + " ");
                }
            }

        }
    }
}
