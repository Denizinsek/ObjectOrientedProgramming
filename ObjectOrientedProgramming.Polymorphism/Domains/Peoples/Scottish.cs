using System;

namespace ObjectOrientedProgramming.Polymorphism.Domains.Peoples
{
    internal class Scottish : People
    {
        public override void Salutation()
        {
            base.Salutation();
            Console.WriteLine("hollo");
        }
    }
}
