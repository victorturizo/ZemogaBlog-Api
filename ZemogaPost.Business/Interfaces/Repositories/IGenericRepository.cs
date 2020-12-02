using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZemogaPost.Business.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task<bool> Create(T entity);

        Task<bool> Update(T entity, int id);

        Task<bool> Delete(int id);
    }
}
