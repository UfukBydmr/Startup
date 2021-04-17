using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs
            {
                KursAdi = "C#",
                Egitmen = "Engin",
                IzlenmeOrani = 68
            };

            Kurs kurs2 = new Kurs
            {
                KursAdi = "Java",
                Egitmen = "Kerem",
                IzlenmeOrani = 64
            };

            Kurs kurs3 = new Kurs
            {
                KursAdi = "Python",
                Egitmen = "Berkay",
                IzlenmeOrani = 80
            };

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi );

            }


           // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
