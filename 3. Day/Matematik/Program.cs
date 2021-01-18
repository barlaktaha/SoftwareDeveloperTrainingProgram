using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem();
            Console.WriteLine("4 ve 2 Sayısını \n \n");
            Console.WriteLine("----Bölme----");
            dortislem.Bolme(4, 2);
            Console.WriteLine("----Çarpma----");
            dortislem.Carpma(4, 2);
            Console.WriteLine("----Çıkarma----");
            dortislem.Cikar(4, 2);
            Console.WriteLine("----Toplama----");
            dortislem.Topla(4, 2);
        }
    }
}
