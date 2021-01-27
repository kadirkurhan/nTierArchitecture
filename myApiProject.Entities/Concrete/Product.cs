using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.Entities.Interfaces;

namespace myApiProject.Entities.Concrete
{
    public class Product : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
