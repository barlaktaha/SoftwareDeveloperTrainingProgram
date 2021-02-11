using GameBackendCode.Abstract;
using GameBackendCode.Entitiy;
using GameBackendCode.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "TAHA" && gamer.LastName == "BARLAK" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
