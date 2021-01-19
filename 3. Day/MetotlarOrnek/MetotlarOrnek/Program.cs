using System;

namespace MetotlarOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add2(2,3);
            Add();
            Console.ReadLine();
            Console.WriteLine(result);
        }
        static void Add() 
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
            
        }
    }
}
