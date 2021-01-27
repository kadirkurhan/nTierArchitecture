using System.Collections.Generic;
using System.Threading.Tasks;
using myApiProject.Entities.Concrete;

namespace myApiProject.DataAccess.Interfaces
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        Task<List<AppRole>> GetRolesByUserName(string userName);
    }
}
