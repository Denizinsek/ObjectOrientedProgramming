using ObjectOrientedProgramming.Inheritance.Domains.Customers;
using System;

namespace ObjectOrientedProgramming.Inheritance.Domains.Personal
{
    internal class Personal : Customer // Müşteriler clasından miras (kalıtım alındı)
    {
        public int score;

        public void ScoreStatus(int score)
        {
            if (score > 1000)
            {
                Console.WriteLine("Müşteriye hediye verilsin");
            }
        }
    }
}
