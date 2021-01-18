using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);

        }

        //encapsulation-kapsülleme

        //alttaki kullanışsız bir durum.
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
