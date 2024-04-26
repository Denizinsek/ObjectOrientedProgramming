using ObjectOrientedProgramming.App4.Domains.Students;
using System;

namespace ObjectOrientedProgramming.App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Adı:");
            Student student = new Student();
            student.Name = Console.ReadLine();

            Console.WriteLine("Tc: ");
            student.Tc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrenci No: ");
            student.StudentNo = Console.ReadLine();
            Console.WriteLine("Not: ");
            student.Note = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Burs miktarı: ");
            student.scholarShipamount = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("*** Çıktı Ekranı ***");
            Console.WriteLine("Ad: " + student.Name);
            Console.WriteLine("Tc: " + student.Tc);
            Console.WriteLine("No: " + student.StudentNo);
            Console.WriteLine("Not: " + student.Note);
            Console.WriteLine("Burs: " + student.scholarShipamount);

            Console.ReadLine();
        }
    }
}
