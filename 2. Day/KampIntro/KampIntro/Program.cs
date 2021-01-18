 using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // do not repeat yourself - Kendini Tekrarlama
            //type safety - tip güvenliği

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Ok Aşağı");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("OK YUKARI");
            }
            else
            {
                Console.WriteLine("SABİT OK");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            // Console.WriteLine("Kategori"); // yazsaydım ayrı ayrı yazmam gerekirdi.
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
