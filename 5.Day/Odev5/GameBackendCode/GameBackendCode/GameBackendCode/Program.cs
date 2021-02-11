using GameBackendCode.Abstract;
using GameBackendCode.Entitiy;
using GameBackendCode.Concrete;
using System;

namespace GameBackendCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1, 
                BirthYear = 1994, 
                FirstName = "TAHA", 
                LastName = "BARLAK", 
                IdentityNumber = 12345 
            }
            );

            OrderManager orderManager = new OrderManager();
            orderManager.Order(new Gamer
            {
                Id = 2,
                BirthYear = 1995,
                FirstName = "MELİH",
                LastName = "OKUT",
                IdentityNumber = 1234345
            }
            );

            CompanyManager companyManager = new CompanyManager();
            companyManager.Company(new Gamer
            {
                  
                Id=3,
                BirthYear=1995,
                FirstName="YAKUP",
                LastName="KÜÇÜK",
                IdentityNumber=12312412412
            }
            );


          
        }
    }
}
