using ObjectOrientedProgramming.Encapsulation.Domains.Customers;
using System;

namespace ObjectOrientedProgramming.Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kapsülleme: Class ta tanımlanan private alanların kontrollü bir şekilde kullanıcıya açılmasını 
            // sağlayan ve koruma altına aldığımız sisteme denir.

            // iki anahtar kelime vardır Get: oku, getir Set: atama, yazdırma

            Customer customer = new Customer();
            Console.WriteLine("Müşteri adı: ");
            customer.Name = Console.ReadLine();

            Console.WriteLine("Müşteri Tc: ");
            customer.Tc = Console.ReadLine(); // burada set metodu çalıştı
            Console.WriteLine("Müşteri Bakiye: ");
            customer.Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adres: ");
            customer.Address = Console.ReadLine();

            Console.WriteLine("*** Çıktı Ekranı ***");
            Console.WriteLine("Müşteri adı: " + customer.Name);
            Console.WriteLine("Müşteri Tc: " + customer.Tc); // Get metodu çalışır
            Console.WriteLine("Bakiye: " + customer.Balance);
            Console.WriteLine("Adres: " + customer.Address);

            Console.ReadLine();
        }
    }
}
