using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.Entities.Interfaces;

namespace myApiProject.Entities.Dtos.ProductDtos
{
    public class ProductAddDto : IDto
    {
        public string Name { get; set; }
    }
}
