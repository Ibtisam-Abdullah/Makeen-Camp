using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Day1.Models
{
    internal class Employee : User
    {
        public int Salary { get; set; }
        public string Position { get; set; }

        public Employee(int id, string firstName, string lastName, string address, string city, int salary, string position) : base(id, firstName, lastName, address, city)
        {
            Salary = salary;
            Position = position;
        }

        public override void greating()
        {
            base.greating();
            Console.WriteLine($"The position is {Position} Your salary is {Salary}");
        }
    }
}
