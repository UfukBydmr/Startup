using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi ornegi array = dizi

            string[] kurslar = new string[] {"Yazılım","Program",
                "Java","Python","C++" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            // foreach dizilere uygulanır

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
