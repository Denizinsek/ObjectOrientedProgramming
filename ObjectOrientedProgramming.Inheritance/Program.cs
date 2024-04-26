using ObjectOrientedProgramming.Inheritance.Domains.Corporate;
using ObjectOrientedProgramming.Inheritance.Domains.Personal;
using System;

namespace ObjectOrientedProgramming.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1) Kurumsal\n 2) Bireysel");
            byte choice = Convert.ToByte(Console.ReadLine());
            if (choice == 1)
            {
                Corporate corporate = new Corporate();
                Console.WriteLine("Müşteri Adı: ");
                corporate.customerName = Console.ReadLine();
                Console.WriteLine("Müşteri No: ");
                corporate.customerNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Telefon No: ");
                corporate.customerPhone = Console.ReadLine();
                Console.WriteLine("Bakiye: ");
                corporate.Balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ÇalışmaYılı: ");
                corporate.workYear = Convert.ToInt32(Console.ReadLine());
                corporate.BalanceMessage(corporate.Balance);
            }
            else if (choice == 2)
            {
                Personal personal = new Personal();
                Console.WriteLine("Müşteri Adı: ");
                personal.customerName = Console.ReadLine();
                Console.WriteLine("Müşteri No: ");
                personal.customerNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Telefon No: ");
                personal.customerPhone = Console.ReadLine();
                Console.WriteLine("Bakiye: ");
                personal.Balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Müşteri Puanı: ");
                personal.score = Convert.ToInt32(Console.ReadLine());

                personal.ScoreStatus(personal.score);
                personal.BalanceMessage(personal.Balance);
            }

            //SubCorporate subCorporate = new SubCorporate();
            //Console.WriteLine("Ad giriniz");
            //subCorporate.customerName = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
