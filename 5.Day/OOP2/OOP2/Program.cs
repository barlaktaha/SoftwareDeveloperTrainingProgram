using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "taha";
            customer1.CustomerLastName = "brlk";
            customer1.TrIdentityNumber = "461...";
            customer1.Id = 132;

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "BGS";
            customer2.CustomerNumber = "123";
            customer2.TaxNumber = "1234";

            //SOLID

            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new IndividualCustomer();

            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(customer1);
            customermanager.Add(customer2);





        }
    }
}
