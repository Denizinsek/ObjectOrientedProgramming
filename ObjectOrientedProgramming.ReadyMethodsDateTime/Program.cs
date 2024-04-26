using System;

namespace ObjectOrientedProgramming.ReadyMethodsDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text1 = "deniz inan";
            string text2 = "deniz";

            int result = String.Compare(text1, text2);
            Console.WriteLine(result);

            string text3 = String.Copy(text2);
            Console.WriteLine(text3);

            Console.WriteLine(String.Concat(text1, " ", text2));
            Console.WriteLine(text1);
            Console.WriteLine(String.Format("{0,11}", text2));

            int x = 15;
            Console.WriteLine(String.Format("{0:0000}", x));
            Console.WriteLine(String.Format("{0,11}", x));
            Console.WriteLine(String.Format("{0,11:0000}", x));

            int length = text1.Length;


            // CopyTo

            string expression = "Ben kodlama öğreniyorum yuppi";
            char[] ch = new char[50];
            expression.CopyTo(4, ch, 0, 10);
            text1.CopyTo(1, ch, 0, 2);
            Console.WriteLine(ch[1]);

            Console.WriteLine(text1.ToLower());
            Console.WriteLine(text1.ToUpper());
            Console.WriteLine(x.ToString().Length);
            Console.WriteLine(text1.Insert(3, "merhaba"));
            Console.WriteLine(text1.Insert(3, x.ToString()));


            // Matematik fonksiyonları

            int a = -15;
            int b = 20;

            Console.WriteLine(Math.Abs(b));

            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Pow(a, 3));

            float c = 10.56f;
            Console.WriteLine(Math.Round(c, 1));


            // Tarih Saat

            DateTime birthdate = new DateTime(2003, 02, 01);
            Console.WriteLine(birthdate);

            DateTime now = new DateTime();
            now = DateTime.Now;

            DateTime now1 = DateTime.Now.Date;
            Console.WriteLine(now1);

            int date = DateTime.Now.Year;
            Console.WriteLine(date);

            DateTime date2 = new DateTime(2010, 10, 03);

            Console.WriteLine(date2.Year);

            Console.ReadLine();

        }
    }
}
