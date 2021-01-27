using System;
using System.Collections.Generic;
using System.Text;

namespace myApiProject.Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost";
        public const string Audience = "http://localhost";
        public const string SecurityKey = "testtesttesttest";
        public const double TokenExpiration = 30;
    }
}
