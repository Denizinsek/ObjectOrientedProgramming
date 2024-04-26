using System;

namespace ObjectOrientedProgramming.Abstract.Domains.Shoes
{
    abstract internal class Shoe
    {
        public string Brand;

        public void Hello()
        {
            Console.WriteLine("Hoş geldiniz");
        }

        public abstract void Salutation();
    }
}
