namespace Week2_Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create objects from the class 
            Person person1 = new Person("Khawla", 23, "Al Qabil");
            Person person2 = new Person("Na'ma", 19, "Al Qabil");
            Person person3 = new Person("Aisha", 7, "Al Qabil");

            Person[] people = { person1, person2, person3 }; // array to save all person

            // for each person in array print information
            foreach (Person person in people)
            {
                //print person information
                Console.WriteLine(person.getInfo());
            }

            Person person4 = new Students("Maryam", 14, "Al Qabil", 3.5);
            Console.WriteLine(person4.getInfo());
        }
    }

    // class person
    class Person
    {
        // person atrributes 
        public string name;
        public int age;
        public string address;

        // constructor
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // method to print person information
        public virtual string getInfo()
        {
            return $"her name is {name} she is {age} years old, she is from {address}";
        }
    }

    class Students : Person
    {
        public double grade;

        public Students(string name, int age, string address, double grade) : base(name, age, address)
        {
            this.grade = grade;
        }

        public override string getInfo()
        {
            return base.getInfo() + $"Student grade {grade}";
        }

    }
}
