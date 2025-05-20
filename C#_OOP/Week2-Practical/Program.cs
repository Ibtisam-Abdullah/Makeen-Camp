using static System.Net.Mime.MediaTypeNames;

namespace Week2_Practical
{
    internal class Program
    {
        /* A company wants to build a C# application to calculate an employee's total salary after deducting a 3% tax. 
        * The application should:
        -> Ask the user to input their first name, last name, worked hours, and price per hour.
        -> Calculate the total salary after deducting 3% tax from the gross income.
        -> Display a message showing the employee’s full name, total hours worked, and final salary. */

        static void Main(string[] args)
        {

            Test t = new Test();
            bool result = t.isEven(10);
            Console.WriteLine(result);

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            t.evenNumbers(num);
            ////we will make this code easier using OOP so we can add more than one employee
            //Console.WriteLine("First Name: ");
            //string fname = Console.ReadLine();
            //Console.WriteLine("Last Name: ");
            //string lname = Console.ReadLine();
            //Console.WriteLine("Workwd Hours: ");
            //int workHours = int.Parse(Console.ReadLine());
            //Console.WriteLine("Price: ");
            //double price = double.Parse(Console.ReadLine());
            //const double TAX = 0.03;

            //double salary = (workHours * price) - (workHours * price * TAX);
            //Console.WriteLine($"{fname} {lname} worksed for {workHours} hours, the total salary: {salary}");

            ////employee 1
            //Employee e1 = new Employee();
            //e1.fname = "Khawla";
            //e1.lname = "Alharthi";
            //e1.workHours = 3;
            //e1.price = 50;
            ////e1.sayHi("Ahmad"); // argument 
            ////-------------------
            //int a = 5; // send 5 as as value to a in doubleValue() method 
            ////e1.doubleValue(a); // <calling by value> print 25 because it calls a from the method
            //e1.doubleValue(ref a); // <calling by reference>
            //Console.WriteLine(a); // then print 5 


            //// employee 2
            //Employee e2 = new Employee();
            //e2.fname = "Saif";
            //e2.lname = "Alharthi";
            //e2.workHours = 5;
            //e2.price = 60;
            //// employee 3
            //Employee e3 = new Employee();
            //e3.fname = "Aisha";
            //e3.lname = "Alharthi";
            //e3.workHours = 4;
            //e3.price = 40;

            //// put all employees in array
            //Employee[] employees = { e1, e2, e3 };

            //// display detailes foreach employee in Employee array  
            //foreach (Employee employee in employees)
            //{
            //    //employee.sayHi(); // call sayHi()
            //    employee.getSalary(); // call getSalary function from Employee class
            //    int h = employee.totalHours(); // totalHours() function we must save it in a variable
            //    Console.WriteLine(h);
            //}

        }
        public class Employee
        {
            public const double TAX = 0.03;
            public string fname;
            public string lname;
            public int workHours;
            public double price;

            public void getSalary() // void functions does not return a value 
            {
                double mainSalary = workHours * price;
                double finalSalary = mainSalary * TAX;
                double salary = mainSalary - finalSalary;
                Console.WriteLine($"{fname} {lname} worked for {workHours} hours," +
                    $" the total salary: {salary}");
            }

            public int totalHours() // this function does return value <must define the datatype>
            {
                return workHours;
            }
            // shortcut for this method:
            // public int totalHours() => workHours;

            public void sayHi(string s) // parameters
            {
                Console.WriteLine($"Hi. {s}");
            }

            public void doubleValue(ref int a)
            {
                a = a*a;
                Console.WriteLine(a);
            }
        }
        public class Test
        {
            public int evenNumbers(int[] arr)
            {
                foreach (int element in arr)
                {
                    if (isEven(element))
                    {
                        Console.Write(element + " ");
                    }
                }
                return 1;
            }

            public bool isEven(int i)
            {
                return i % 2 == 0;
            }

        }

    }
}
