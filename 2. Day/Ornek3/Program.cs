using System;

namespace Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araç Türünü Giriniz: ");
            string AracTuru = Console.ReadLine();
            Console.WriteLine("Zamanı Giriniz: ");
            float Zaman = float.Parse(Console.ReadLine());

            if (AracTuru == "taksi")
            {
                int A = Math.Round(Zaman);
                
                double ucret = 5;
                double ToplamUcret = 0;
                for (int i = 0; i <= A ; i++)
                {
                    
                    ucret = ucret + ucret * (0.2)*i;
                    ucret = ucret; 
                    ToplamUcret = ToplamUcret + ucret;
                    i++;
                    
                }
                
                Console.WriteLine("Ücret:" + ToplamUcret + "TL");
            }
            else if (AracTuru == "minibus")
            {
                int A = Math.Round(Zaman);
                double ucret = 6;
                for (int i = 1; i <= A + 1; i++)
                {

                    ucret = ucret + ucret * (0.215);
                    i++;
                }
                Console.WriteLine("Ücret:" + ucret + "TL");
            }
            else if (AracTuru == "ticariarac")
            {
                int A = Math.Round(Zaman);
                double ucret = 6.5;
                for (int i = 1; i <= A + 1; i++)
                {

                    ucret = ucret + ucret * (0.25);
                    i++;
                }
                Console.WriteLine("Ücret:" + ucret + "TL");
            }
            else
            {
                Console.WriteLine("Böyle Bir Araç Türü Yoktur. Manuel Hesaplayınız.");
            }

            
        }
    }
}
