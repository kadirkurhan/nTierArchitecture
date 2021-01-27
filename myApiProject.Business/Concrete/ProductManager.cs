using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using myApiProject.Business.Interfaces;
using myApiProject.DataAccess.Interfaces;
using myApiProject.Entities.Concrete;

namespace myApiProject.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IGenericDal<Product> genericDal,
            IProductDal productDal) : base(genericDal)
        {
            _productDal = productDal;
        }

       

    }
}
