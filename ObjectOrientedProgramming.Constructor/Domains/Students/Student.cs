using System;

namespace ObjectOrientedProgramming.Constructor.Domains.Students
{
    internal class Student
    {
        public int studentNumber;
        public Student()
        {
            Console.WriteLine("Merhaba öğrenciler");
            studentNumber = 0;
        }

        ~Student()
        {
            Console.WriteLine("Nesne oluşmadan çalıştı");
        }
    }
}
