using System;

namespace ObjectOrientedProgramming.Inheritance.Domains.Customers
{
    internal class Customer
    {
        // Ortak alanlar (field) ana class (base, süper) ta tutulur

        public int customerNo;
        public string customerName;
        public string customerPhone;
        double balance;

        public double Balance // Kapsülleme
        {
            get { return balance; }
            set
            {
                if (value < 1000)
                {
                    balance = value;
                }
                else
                {
                    balance = value + 100;
                }
            }
        }

        public void BalanceMessage(double balanceValue)
        {
            if (balanceValue == 0)
            {
                Console.WriteLine("borcunuz bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("En kısa sürede borcunuzu ödeyiniz");
            }
        }
    }
}