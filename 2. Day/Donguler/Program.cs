using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = dizi

            string[] kurslar = new string[]{ "Yazılım Geliştirici Yetiştirme Kampı","Programlama Başlangıç İçin Temel Kurs","Java Kursu","Python Kursu","C++ Kursu"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Dongu Sonu");
        }
    }
}
