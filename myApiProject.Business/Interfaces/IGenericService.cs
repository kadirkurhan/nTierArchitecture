using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using myApiProject.Entities.Interfaces;

namespace myApiProject.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAll();       
        Task<TEntity> GetById(int id);     
        Task Update(TEntity entity);
        Task Add(TEntity entity);
        Task Remove(TEntity entity);
    }
}
