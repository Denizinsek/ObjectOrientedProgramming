using System;

namespace ObjectOrientedProgramming.Constructor.Domains.Teachers
{
    internal class Teacher
    {
        ~Teacher()
        {
            Console.WriteLine("Öğretmen classından nesne üretilmedi");
        }

    }
}
