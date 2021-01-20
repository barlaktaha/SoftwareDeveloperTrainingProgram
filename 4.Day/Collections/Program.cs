using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);

            // Yukarıda ki kodu çalıştırdığımızda 
            // dizinin dışına çıkmak uyarısı verir.
            // bu şekilde 4.karakteri ekleyemeyiz.
            // bu yüzden koleksiyonları kullanırız.

            List<string> isimler = new List<string>{"Engin","Murat","Kerem","Halil";

            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            
            // yeni eleman eklemek için

            isimler.Add("İlker");
            Console.WriteLine(isimler[4]);




        }
    }
}
