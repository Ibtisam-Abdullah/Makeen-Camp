using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Day1.Models
{
    internal class Customer : User
    {
        public int OrderNombers { get; set; }
        public string PaymentType { get; set; }

        public Customer(int id, string firstName, string lastName, string address, string city, int orderNombers, string paymentType) : base(id, firstName, lastName, address, city)
        {
            OrderNombers = orderNombers;
            PaymentType = paymentType;
        }

        public override void greating()
        {
            base.greating();
            Console.WriteLine($"The number of your oreder is {OrderNombers}, payment type is {PaymentType}");
        }

    }
}
