using System;

namespace ObjectOrientedProgramming.App2.Domains
{
    internal class Teachers
    {
        public string Tc { get; set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
        public string Branch { get; set; }

        public Teachers(string tc, string fullName, double salary, string branch)
        {
            Tc = tc;
            FullName = fullName;
            Salary = salary;
            Branch = branch;
        }

        public Teachers()
        {
        }

        public void Salaryx(double salary)
        {
            if (salary < 30000)
            {
                Console.WriteLine("Ek ders alabilirsiniz");
            }
            else
            {
                Console.WriteLine("Ek derse ihtiyaç yok");
            }
        }

        public bool Salary1(double salary)
        {
            if (salary < 30000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
