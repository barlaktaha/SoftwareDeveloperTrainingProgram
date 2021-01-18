using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Taha";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Taha";
            kurs1.IzlenmeOrani = 5500;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.KursunEgitmeni = "Taha";
            kurs2.IzlenmeOrani = 3500;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursunEgitmeni = "Taha";
            kurs3.IzlenmeOrani = 7500;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Python";
            kurs4.KursunEgitmeni = "Harun";
            kurs4.IzlenmeOrani = 1500;


            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni + " : " + kurs.IzlenmeOrani);

            }
            
           
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
