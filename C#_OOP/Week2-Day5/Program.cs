namespace Week2_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier(new Debit());
            cashier.chechout(300);
            Igrate grate = new Cash();
            grate.sayHi();
        }

        class Cashier
        {
            private Ipay ipay;
            public Cashier(Ipay ipay)
            {
                this.ipay = ipay;

            }

            public void chechout(double amount)
            {
                Console.WriteLine(ipay.getPay(amount));
            }
        }
        // this is an intrface <<like parents>> contains method without body. tese methods will be implemented in the sub-classes
        public interface Ipay
        {
            public string getPay(double amount);
        }

        public interface Igrate
        {
            public void sayHi(); // no need to implement in the interface implement in the Cash class
        }

        class Cash : Ipay, Igrate
        {
            public string getPay(double amount)
            {
                return $"Total cash amount is: {amount}";
            }

            public void sayHi()
            {
                Console.WriteLine("Hi, user!");
            }
        }

        class Debit : Ipay
        {
            public string getPay(double amount)
            {
                return $"Total debit amount is: {amount}";
            }
        }

        class Visa : Ipay
        {
            public string getPay(double amount)
            {
                return $"Total visa amount is: {amount}";
            }
        }

    }

}
