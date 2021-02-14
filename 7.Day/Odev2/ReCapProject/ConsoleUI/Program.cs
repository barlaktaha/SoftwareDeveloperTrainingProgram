using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Abstract;
using Business.Concrete;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
               Console.WriteLine(car.Description);
            }

        }
    }
}
