using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using myApiProject.Business.Concrete;
using myApiProject.Business.Interfaces;
using myApiProject.Business.ValidationRules.FluentValidation;
using myApiProject.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using myApiProject.DataAccess.Interfaces;
using myApiProject.Entities.Dtos.AppUserDtos;
using myApiProject.Entities.Dtos.ProductDtos;

namespace myApiProject.Business.Containers.MicrosoftIoc
{
    public static class CustomExtension
    {

        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
            services.AddScoped<IAppRoleService, AppRoleManager>();

            services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepository>();
            services.AddScoped<IAppUserRoleService, AppUserRoleManager>();

            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();

            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddDtoValidator>();
        }
    }

}
