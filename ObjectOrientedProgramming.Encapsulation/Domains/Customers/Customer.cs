using System;

namespace ObjectOrientedProgramming.Encapsulation.Domains.Customers
{
    internal class Customer
    {
        public string Name { get; set; }
        private string tc;
        int balance;
        string address;
        public string Tc
        {
            get { return tc; }

            set
            {
                if (value.Length == 11)
                {
                    tc = value;
                }
                else
                {
                    Console.WriteLine("Tc 11 haneli olmalı");
                    Console.WriteLine("Müşteri tc");
                    Tc = Console.ReadLine();
                }
            }
        }

        public int Balance
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
                    Console.WriteLine("bakiye düşük oranda ");
                    balance = value - 40;
                }
            }
        }

        public string Address { get { return address; } set { address = value; } }
    }
}
