using System;

namespace ObjectOrientedProgramming.Recursive
{
    internal class Program
    {
        public void ChangingNumber(int number)
        {
            number += 1;
            Console.WriteLine(number);
            if (number < 15)
            {
                ChangingNumber(number);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ChangingNumber(3);
            Console.ReadLine();
        }
    }
}
