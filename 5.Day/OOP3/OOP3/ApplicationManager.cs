using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        // Method injection
        public void ApplicationMake(ICreditManager creditManager, ILogerService logerService)
        {
            creditManager.Calculate();
            logerService.Log();
        }
        public void CreditInformationAsk(List<ICreditManager> credits)
        {
            foreach(var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
