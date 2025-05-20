namespace Day1
{
    internal class Program
    {
        /* 
       this is 
       for multible line 
       comments */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // new line
            Console.Write("Hello, World!"); // all text in single (new) line

            // <data-type> variable-name = value;
            string name = "Khawla" + " " + "Saif";
            char gender = 'F';
            double grade = 3.86;
            int age = 18;
            /* or 
            int age1;
            age1 = 18;
            uint age2 = 18; // only accept POSITIVE numbers the lowest number on it is 0 bacause it doe'nt accept negative numbers
            */
            //print the variables 
            Console.WriteLine("name: " + name);
            Console.WriteLine($"name: {name}"); // use $ so you can add {} inside the pracet
            Console.WriteLine("gender: " + gender);
            Console.WriteLine("grade: " + grade);
            Console.WriteLine("age: " + age);


            // Class string (var)
            var s = 5;
            s = 52;   // here the s will change from 5 into 52 becuse it has the same data type INTEGER

            /* while if we type 
            var s = 5;
            s = 5,3;  it will give error because the data type is different <here comes the DYNAMIC>*/

            // (dynamic) more flixible then var
            dynamic x = 5.3;
            x = 5; // here it will change based on the latest data type you give without giving error 

            // use comparison operators with strings
            string t1 = "Hi";
            string t2 = "Hello";
            Console.WriteLine(t1.Length > t2.Length); // false
            Console.WriteLine(t1.Length < t2.Length); // true

            // Let users enter mark and compare with the pass mark to return PASS or FAIL
            int passMark = 70;
            int mark = Convert.ToInt16(Console.ReadLine());
            var result = (mark >= passMark) ? "Pass" : "Fail"; // after '?' if true <pass> else false <fail>
            Console.WriteLine(result);
        }
    }
}
