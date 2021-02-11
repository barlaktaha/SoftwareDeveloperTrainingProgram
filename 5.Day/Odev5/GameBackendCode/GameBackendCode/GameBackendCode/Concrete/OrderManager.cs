using GameBackendCode.Abstract;
using GameBackendCode.Entitiy;
using GameBackendCode.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Order(Gamer gamer)
        {
            Console.WriteLine("Satış Yapıldı" + gamer.FirstName);
        }
    }
}
