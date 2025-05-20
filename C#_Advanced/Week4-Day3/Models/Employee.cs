using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Day3.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public double TotalSales { get; set; }

        public Employee(int id, string name, char gender, double totalSales)
        {
            Id = id;
            Name = name;
            Gender = gender;
            TotalSales = totalSales;
        }

    }
}
