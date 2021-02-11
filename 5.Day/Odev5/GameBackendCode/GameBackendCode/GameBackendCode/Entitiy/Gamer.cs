using GameBackendCode.Abstract;
using GameBackendCode.Entitiy;
using GameBackendCode.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCode.Entitiy
{
    public class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }
        public int BirthYear { get; set; } 

    }
}
