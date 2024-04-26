using System;

namespace ObjectOrientedProgramming.app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people = new People(); // classtan nesne ürettik
            people.FullName = "Deniz İnan Şimşek";
            People people1 = new People();
            people.FullName = "İdil Bilge Şimşek";
            People people2 = new People();
            people.FullName = "Doğa Kayra Şimşek";
            Console.ReadLine();
        }
    }
}
