using System;

namespace ObjectOrientedProgramming.App4.Domains.Students
{
    internal class Student
    {
        int tc;
        public string Name;
        string studentNo;
        int note;
        public int scholarShipamount;

        public int Tc
        {
            get { return tc; }
            set
            {
                if (value % 2 == 0 && value.ToString().Length == 11)
                {
                    tc = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş ");
                    Console.WriteLine("Tc nonuzu yeniden giriniz");
                    Tc = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public string StudentNo
        {
            get { return studentNo; }
            set
            {
                if (value.Length == 4)
                {
                    studentNo = value;
                }
                else
                {
                    // studentNo = "0000";
                }
            }
        }

        public int Note
        {
            get { return note; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    note = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriniz");
                    Console.WriteLine("Notu giriniz");
                    Note = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
