using ObjectOrientedProgramming.App3.Domains.Personnels;
using ObjectOrientedProgramming.App3.Domains.Products;
using System;

namespace ObjectOrientedProgramming.App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ürün kodu: ");
            Product product = new Product();
            product.ProductNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürün adı: ");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Fiyat: ");
            product.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marka: ");
            product.Brand = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("***** Kayıt Ekranı *****");
            Console.WriteLine("Ürün no: " + product.ProductNo);
            Console.WriteLine("Ürün adı: " + product.ProductName);
            Console.WriteLine("Ürün fiyat: " + product.Price);
            Console.WriteLine("Ürün marka: " + product.Brand);

            Console.WriteLine("Kaç adet fiş kesilsin ");
            int piece = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fatura tutarı: " + product.Plug(product.Price, piece));

            Console.WriteLine("Personel adı: ");
            Personnel.FullName = Console.ReadLine();
            Console.WriteLine("Personel Tc: ");
            Personnel.Tc = Console.ReadLine();

            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
