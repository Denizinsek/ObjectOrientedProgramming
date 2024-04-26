using ObjectOrientedProgramming.Polymorphism.Domains.Peoples;
using System;

namespace ObjectOrientedProgramming.Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // virtual metotlar ana classlarda hazırlanır.
            // yavru classlarda gövdesi ovveride edilerek kullanılır.
            // virtual metodlar yavru classlarda olduğu gibide kullanılabilir.

            Turk turk = new Turk();
            turk.Salutation();
            Console.WriteLine("*********");

            British british = new British();
            british.Salutation();
            Console.WriteLine("*********");

            Scottish scottish = new Scottish();
            scottish.Salutation();
            Console.WriteLine("*********");

            Console.ReadLine();
        }
    }
}
