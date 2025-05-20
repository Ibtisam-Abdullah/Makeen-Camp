namespace PhoneBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phone = new PhoneBook(5);
            phone.addEntry(0, "Khawla", 95185341);
            phone.addEntry(1, "Saif", 99337391);
            phone.addEntry(2, "Khalsa", 99589431);

            phone.getRecord("Khawla");
            phone.getRecord("Saif");

            //--------------------------------

            PhoneBook1 phoneBook = new PhoneBook1(3);
            phoneBook["Alice"] = 1234;
            phoneBook["Bob"] = 5678;

            Console.WriteLine(phoneBook["Alice"]); // 1234
            Console.WriteLine(phoneBook["Charlie"]); // -1 (not found)

            phoneBook["Alice"] = 4321; // Update
            Console.WriteLine(phoneBook["Alice"]); // 4321

        }
    }
}
