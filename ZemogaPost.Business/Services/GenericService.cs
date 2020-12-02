using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZemogaPost.Business.Interfaces.Repositories;
using ZemogaPost.Business.Interfaces.Services;

namespace ZemogaPost.Business.Services
{
    public class GenericService<T> : IGenericService<T>
        where T : class
    {
        private readonly IGenericRepository<T> _genericRepository;


        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Task<bool> Create(T entity)
        {
            return _genericRepository.Create(entity);
        }

        public Task<bool> Delete(int id)
        {
            return _genericRepository.Delete(id);
        }

        public Task<List<T>> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public Task<T> GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public Task<bool> Update(T entity, int Id)
        {
            return _genericRepository.Update(entity, Id);
        }

    }
}
