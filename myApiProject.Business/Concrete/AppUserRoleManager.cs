using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.Business.Interfaces;
using myApiProject.DataAccess.Interfaces;
using myApiProject.Entities.Concrete;

namespace myApiProject.Business.Concrete
{
    public class AppUserRoleManager : GenericManager<AppUserRole>, IAppUserRoleService
    {
        public AppUserRoleManager(IGenericDal<AppUserRole> genericDal):base(genericDal)
        {

        }
    }
}
