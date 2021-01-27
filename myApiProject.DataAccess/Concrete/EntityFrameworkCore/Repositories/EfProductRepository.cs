using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using myApiProject.DataAccess.Concrete.EntityFrameworkCore.Context;
using myApiProject.DataAccess.Interfaces;
using myApiProject.Entities.Concrete;

namespace myApiProject.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductDal
    {
       
    }
}
