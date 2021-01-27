using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myApiProject.Business.Interfaces;
using myApiProject.Business.StringInfos;
using myApiProject.Entities.Concrete;

namespace myApiProject.WebApi
{
    public static class JwtIdentityInitializer
    {
        public static async Task Seed(IAppUserService appUserService, IAppUserRoleService appUserRoleService, IAppRoleService appRoleService)
        {
            //ilgili rol varmı?
            var adminRole = await appRoleService.FindByName(RoleInfo.Admin);
            if (adminRole == null)
            {
                await appRoleService.Add(new AppRole
                {
                    Name = RoleInfo.Admin
                });
            }

            var memberRole = await appRoleService.FindByName(RoleInfo.Member);
            if (memberRole == null)
            {
                await appRoleService.Add(new AppRole
                {
                    Name = RoleInfo.Member
                });
            }

            var adminUser = await appUserService.FindByUserName("kadir");
            if (adminUser == null)
            {
                await appUserService.Add(new AppUser
                {
                    FullName = "kadir kurhan",
                    UserName = "kadir",
                    Password = "1"
                });

                var role = await appRoleService.FindByName(RoleInfo.Admin);
                var admin = await appUserService.FindByUserName("kadir");

                await appUserRoleService.Add(new AppUserRole
                {
                    AppUserId = admin.Id,
                    AppRoleId = role.Id
                });
            }
        }
    }
}
