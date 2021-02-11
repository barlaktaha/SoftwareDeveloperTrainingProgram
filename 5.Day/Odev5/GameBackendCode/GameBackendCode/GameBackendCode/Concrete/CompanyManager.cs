using GameBackendCode.Abstract;
using GameBackendCode.Entitiy;
using GameBackendCode.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Concrete
{
    public class CompanyManager : ICompanyService
    {
        public void Company(Gamer gamer)
        {
            Console.WriteLine("Kampanya Uygulandı." + gamer.FirstName);
        }
    }
}
