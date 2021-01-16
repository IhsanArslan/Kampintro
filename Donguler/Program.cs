using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Proglamlamaya baslangic icin temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi",
                "Proglamlamaya baslangic icin temel kurs", "Java"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
