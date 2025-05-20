using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Day3.Models
{
    internal class Report
    {
        // delegate functions sum all the previus functions and make all in one function
        public delegate bool SaleaCondition(Employee employee);
        public void ProcessSales(Employee[] employee, string title, SaleaCondition cond)
        {
            Console.WriteLine("\nReport Generator");
            Console.WriteLine(title);

            foreach (Employee emp in employee)
            {
                if (cond(emp))
                {
                    Console.WriteLine($"{emp.Name} has total sales {emp.TotalSales}");
                }
            }
            Console.WriteLine("---------------------------------------------");
        }


        //public void totalSaleMoreThan60k(Employee[] employees)
        //{
        //    Console.WriteLine("\nReport Generator");
        //    Console.WriteLine("Total Sale More Than 60k: ");

        //    foreach (Employee employee in employees)
        //    {
        //        if(employee.TotalSales >= 60000)
        //        {
        //            Console.WriteLine($"{employee.Name} has total sales {employee.TotalSales}");
        //        }
        //    }
        //}
        //public void totalSaleMoreThan30k(Employee[] employees)
        //{
        //    Console.WriteLine("\nReport Generator");
        //    Console.WriteLine("Total Sale More Than 30k: ");

        //    foreach (Employee employee in employees)
        //    {
        //        if ((employee.TotalSales < 60000) && (employee.TotalSales >= 30000))
        //        {
        //            Console.WriteLine($"{employee.Name} has total sales {employee.TotalSales}");
        //        }
        //    }
        //}
        //public void totalSaleLessThan30k(Employee[] employees)
        //{
        //    Console.WriteLine("\nReport Generator");
        //    Console.WriteLine("Total Sale Less Than 30k: ");

        //    foreach (Employee employee in employees)
        //    {
        //        if (employee.TotalSales < 30000)
        //        {
        //            Console.WriteLine($"{employee.Name} has total sales {employee.TotalSales}");
        //        }
        //    }
        //}

    }
}
