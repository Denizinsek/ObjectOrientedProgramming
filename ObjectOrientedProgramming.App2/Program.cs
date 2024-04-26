using ObjectOrientedProgramming.App2.Domains;
using System;

namespace ObjectOrientedProgramming.App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();

            Console.WriteLine("Öğrencinin adını giriniz: ");
            students.FullName = Console.ReadLine();
            Console.WriteLine("TC giriniz: ");
            students.Tc = Console.ReadLine();
            Console.WriteLine("Yaş giriniz: ");
            students.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sınıfını giriniz: ");
            students.Classroom = Console.ReadLine();

            Console.WriteLine("*****Öğrenci Bilgi Ekranı*****");
            Console.WriteLine("Ad Soyad: " + students.FullName);
            Console.WriteLine("Tc: " + students.Tc);
            Console.WriteLine("Yaş:" + students.Age);

            students.Scholarship(students.Age);

            Teachers teachers = new Teachers();
            Teachers teachers1 = new Teachers();

            Console.WriteLine("Birinci öğretmen ad giriniz: ");
            teachers.FullName = Console.ReadLine();

            Console.WriteLine("TC giriniz: ");
            teachers.Tc = Console.ReadLine();

            Console.WriteLine("Maaş giriniz: ");
            teachers.Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Branş giriniz: ");
            teachers.Branch = Console.ReadLine();

            Console.WriteLine("İkinci öğretmen ad giriniz: ");
            teachers1.FullName = Console.ReadLine();

            Console.WriteLine("TC giriniz: ");
            teachers1.Tc = Console.ReadLine();

            Console.WriteLine("Maaş giriniz: ");
            teachers1.Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Branş giriniz: ");
            teachers1.Branch = Console.ReadLine();

            Console.WriteLine("*****Öğretmen Kayıt Ekranı*****");
            Console.WriteLine("ad soyad: " + teachers.FullName);
            Console.WriteLine("tc: " + teachers.Tc);
            Console.WriteLine("maaş: " + teachers.Salary);
            Console.WriteLine("branş:" + teachers.Branch);

            Console.WriteLine("ad soyad: " + teachers1.FullName);
            Console.WriteLine("tc: " + teachers1.Tc);
            Console.WriteLine("maaş: " + teachers1.Salary);
            Console.WriteLine("branş:" + teachers1.Branch);

            Console.WriteLine("Birinci öğretmen ");
            teachers.Salaryx(teachers.Salary);
            Console.WriteLine("İkinci öğretmen ");
            teachers1.Salaryx(teachers1.Salary);

            Console.WriteLine("*********");

            bool result = teachers.Salary1(teachers.Salary);
            if (result == true)
            {
                Console.WriteLine("birinci öğrenme ek ders alabilir");
            }
            else
            {
                Console.WriteLine("birinci öğrenme ek ders alamaz");
            }
            Console.ReadLine();
        }
    }
}
