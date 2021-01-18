using System;

namespace Ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.IndirimOrani = 0.67;
            urun1.KargoBilgisi = "Ücretsiz Kargo";
            urun1.MagazaAdi = "BGS Giyim";
            urun1.UrunAciklamasi = "%100 Coton";
            urun1.UrunAdi = "Eşorfman Altı";
            urun1.UrunFiyati= 79.90;
            Product urun2 = new Product();
            urun2.IndirimOrani = 0.25;
            urun2.KargoBilgisi = "Kargo Ücreti: 9.90 TL";
            urun2.MagazaAdi = "BGS Giyim";
            urun2.UrunAciklamasi = "%30 Polyester, %70 Coton";
            urun2.UrunAdi = "T-shirt";
            urun2.UrunFiyati = 59.90 ;

            Product[] UrunListesi = new Product[] { urun1, urun2 };

            foreach (var Sırala in UrunListesi)
            {
                Console.WriteLine("Ürün Adı: " + Sırala.UrunAdi + "\n" + "Ürün Açıklaması: " + Sırala.UrunAciklamasi + "\n" + "Ürün Fiyatı: " + Sırala.UrunFiyati + "TL \n" + "Kargo Bilgisi: " + Sırala.KargoBilgisi + "\n" + "İndirim Oranı: " + Sırala.IndirimOrani + "\n" + "Mağaza Adı: " + Sırala.MagazaAdi);

            }
            

        }
    }
    class Product
    {
        public string UrunAdi { get; set; }
        public string UrunAciklamasi { get; set; }
        public double UrunFiyati { get; set; }
        public string KargoBilgisi { get; set; }
        public double IndirimOrani { get; set; }
        public string MagazaAdi { get; set; }

    }
}
