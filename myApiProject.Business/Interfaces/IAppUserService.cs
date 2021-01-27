using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using myApiProject.Entities.Concrete;
using myApiProject.Entities.Dtos.AppUserDtos;

namespace myApiProject.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> FindByUserName(string userName);
        Task<bool> CheckPassword(AppUserLoginDto appUserLoginDto);
        Task<List<AppRole>> GetRolesByUserName(string userName);
    }
}
