using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.Entities.Interfaces;

namespace myApiProject.Entities.Token
{
    public class JwtAccessToken : IToken
    {
        public string Token { get; set; }
    }
}
