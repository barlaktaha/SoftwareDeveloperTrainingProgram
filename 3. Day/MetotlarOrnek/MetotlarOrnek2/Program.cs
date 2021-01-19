using System;

namespace MetotlarOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 8));

            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadLine();
        }
        static int Add(int out number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3; 
        }
    }  
}
