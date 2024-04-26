using System;

namespace ObjectOrientedProgramming.App2.Domains
{
    internal class Students
    {
        public string Tc { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Classroom { get; set; }

        public Students(string tc, string fullName, int age, string classroom)
        {
            Tc = tc;
            FullName = fullName;
            Age = age;
            Classroom = classroom;
        }

        public Students()
        {
        }

        public void Scholarship(int age)
        {
            if (age > 12)
            {
                Console.WriteLine("Yaşınız burs alma kriterlerine uygun");
            }
            else
            {
                Console.WriteLine("bursa uygun değil");
            }
        }
    }
}
