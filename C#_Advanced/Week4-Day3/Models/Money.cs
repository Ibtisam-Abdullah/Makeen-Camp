using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Day3.Models
{
    internal class Money
    {
        public double amount;

        public Money(double amount)
        {
            this.amount = amount;
        }

        //operator overloading
        public static Money operator +(Money m1, Money m2)
        {
            double m3 = m1.amount + m2.amount;
            return new Money(m3);
        }
        public static Money operator -(Money m1, Money m2)
        {
            double m3 = m1.amount - m2.amount;
            return new Money(m3);
        }

        //operator overloading using lambda
        public static bool operator >(Money m1, Money m2) => m1 >  m2;
        public static bool operator <(Money m1, Money m2) => m1 <  m2;

    }
}
