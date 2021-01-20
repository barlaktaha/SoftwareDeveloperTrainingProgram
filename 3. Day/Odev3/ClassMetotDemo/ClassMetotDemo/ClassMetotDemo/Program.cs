using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAdi = "Taha";
            musteri.MusteriId = 123456;
            musteri.HesapTuru = "vadeli";

            Console.WriteLine(musteri.MusteriAdi + "\n" + musteri.MusteriId + "\n" + musteri.HesapTuru);

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Silme(musteri);

        }
    }
    class Musteri
    {
        public string MusteriAdi { get; set; }
        public int MusteriId { get; set; }
        public string HesapTuru { get; set; }
    }

    class MusteriManager
    {
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Hesabınız Silindi: " + musteri.MusteriAdi + " Bey ");
        }
    }
}
