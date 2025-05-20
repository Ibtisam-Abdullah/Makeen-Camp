using Week4_Day1.Models;

namespace Week4_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Khawla", "Alharthi", "Oman", "Al_Qabil", 2000, "Manager");
            emp.greating();
            Customer c = new Customer(1, "Nama", "Alharthi", "Oman", "Al_Qabil", 3, "Viza");
            c.greating();
        }
    }
}
