using GameBackendCode.Abstract;
using GameBackendCode.Entitiy;
using GameBackendCode.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
