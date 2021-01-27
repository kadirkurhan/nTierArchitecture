using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.DataAccess.Interfaces;
using myApiProject.Entities.Concrete;

namespace myApiProject.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppRoleRepository : EfGenericRepository<AppRole>, IAppRoleDal
    {
    }
}
