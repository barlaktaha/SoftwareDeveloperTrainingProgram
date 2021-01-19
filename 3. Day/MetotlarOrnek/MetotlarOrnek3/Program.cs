using System;

namespace MetotlarOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add5(1,2,3,4,5,6,7,8,9));
            Console.ReadLine();
        }

        static int Add5(params int[] numbers)
        {

            return numbers.Sum();
            

        }
    }
}
