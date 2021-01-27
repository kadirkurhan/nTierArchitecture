using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.Entities.Concrete;

namespace myApiProject.Business.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwt(AppUser appUser, List<AppRole> roles);
    }
}
