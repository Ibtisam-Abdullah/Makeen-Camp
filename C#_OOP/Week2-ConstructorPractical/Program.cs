namespace Week2_ConstructorPractical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c1-object1
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.Name = "Amna";
            e1.Salary = 389.8;
            //c2-object2
            Employee e2 = new Employee(2, "Ali", 190.3);
            //c3-object3
            Employee e3 = new Employee("Reem")
            {
                Id = 3,
                Salary = 470.9
            };
            //c1-object4
            Employee e4 = new Employee()
            {
                Id = 4,
                Name = "Raya",
                Salary = 405.5
            };

            Employee[] employees = { e1, e2, e3, e4 };
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.getData());
            }
        }
    }

    // employee class
    public class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        //constructer 1
        public Employee() { }

        //constructer 2
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        //constructer 3
        public Employee(string name)
        {
            Name = name;
        }

        public string getData()
        {
            return $"id: {Id}, Name: {Name}, your salary is {Salary}";
        }
    }

}

