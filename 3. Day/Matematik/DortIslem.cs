using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine(cikarma);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            float bolum = sayi1 / sayi2;
            Console.WriteLine(bolum);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine(carpim);
            
        }
    }
}
