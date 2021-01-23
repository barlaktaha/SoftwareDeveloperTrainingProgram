using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager requirementCredit = new RequirementCredit();
            
            ICreditManager carCreditManager = new CarCreditManager();
            
            ICreditManager houseCreditManager = new HouseCreditManager();

            // yukarıda birini seçti müşteri aşağıdaki gibi göndeririz.

            ILogerService databaseLoggerService = new DatabaseLogerService();
            ILogerService fileLogerService = new FilebaseLogerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ApplicationMake(requirementCredit, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {carCreditManager, houseCreditManager };
            //applicationManager.CreditInformationAsk(credits);

               


        }
    }
}
