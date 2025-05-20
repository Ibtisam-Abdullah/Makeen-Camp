using Week4_Day3.Models;

namespace Week4_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp =
            {
                new Employee(2, "Ibrahim" , 'M', 900000),
                new Employee(1, "Khawla" , 'F', 1000000),
                new Employee(3, "Yousif" , 'M', 400000),
                new Employee(4, "Nama" , 'F', 50000),
                new Employee(5, "Nasser" , 'M', 30000),
                new Employee(6, "Sultan" , 'M', 20000),
                new Employee(5, "Helal" , 'M', 800000),
                new Employee(6, "Aisha" , 'F', 670000)
            };

            Report r = new Report();
            //r.totalSaleLessThan30k(emp);
            //r.totalSaleMoreThan60k(emp);
            //r.totalSaleMoreThan30k(emp);


            // Method using expression-bodied syntax to define a delegate target
            // Pass named method as delegate — clear and reusable
            bool TotalSalesMorethan60k(Employee e) => e.TotalSales >= 60000;
            r.ProcessSales(emp, "Employees with Sales More than 60000:", TotalSalesMorethan60k);

            // Pass inline lambda expression to filter employees with sales between 30000 and 60000
            // Good for one-time conditions — no need for a separate method
            r.ProcessSales(emp, "Employees with Sales Between 30000 and 60000:", e => e.TotalSales < 60000 && e.TotalSales >= 30000);
            r.ProcessSales(emp, "Employees with Sales Less than 30000:", e => e.TotalSales < 30000);


            Money m1 = new Money(5);
            Money m2 = new Money(4);
            Money sum = m1 + m2;
            Money diff = m1 - m2;

            Console.WriteLine($"Sum: {sum.amount}");
            Console.WriteLine($"Difference: {diff.amount}");
            Console.WriteLine("Comparison using overloaded operators:");
            // Use overloaded > and < operators
            if (m1 > m2)
                Console.WriteLine("m1 is greater than m2");

            if (m2 < m1)
                Console.WriteLine("m2 is less than m1");
        }

    }
}

