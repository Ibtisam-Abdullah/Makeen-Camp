namespace Week2_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Ali", 56.7);
            Teacher teacher = new Teacher(1, "Mohammad", 700.80);
            Console.WriteLine(student.ToString());
            Console.WriteLine(teacher.ToString());
            teacher.name = "Teacher";
            student.name = "Student";

        }
    }
    public class Person
    {
        public string name;
        public int id;

        public virtual string sayHi() // virtual -> to override in child classes
        {
            return "Hi from person";
        }
        public virtual string ToString()
        {
            return $" {id}";
        }
    }

    public class Student : Person
    {
        double grade;
        public override string sayHi() // override -> using same method in parent but in the class
        {
            return base.sayHi() + "Hi from student"; // base is similar to this but from parent to child
        }
        public override string ToString()
        {
            return $"Student name is: {name}, grade: {grade}";
        }
        public Student(int id, string name, double grade)
        {
            this.grade = grade;
        }
    }
    public class Teacher : Person
    {
        double salary;
        public override string ToString()
        {
            return $"Teacher name is: {name}, salary: {salary}";
        }
        public Teacher(int id, string name, double salary)
        {
            this.salary = salary;
        }
    }

}
