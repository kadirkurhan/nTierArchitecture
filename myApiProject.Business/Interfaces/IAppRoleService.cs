using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using myApiProject.Entities.Concrete;

namespace myApiProject.Business.Interfaces
{
    public interface IAppRoleService : IGenericService<AppRole>
    {
        Task<AppRole> FindByName(string roleName);
    }
}
