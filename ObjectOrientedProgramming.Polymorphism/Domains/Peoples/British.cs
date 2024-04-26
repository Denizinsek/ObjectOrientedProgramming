using System;

namespace ObjectOrientedProgramming.Polymorphism.Domains.Peoples
{
    internal class British : People
    {
        public override void Salutation()
        {
            Console.WriteLine("Hello");
        }
    }
}
