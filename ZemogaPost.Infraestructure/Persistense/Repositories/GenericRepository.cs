using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZemogaPost.Business.Interfaces.Repositories;
using ZemogaPost.Infraestructure.Persistense.Context;

namespace ZemogaPost.Infraestructure.Persistense.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
         where T : class

    {
        private readonly BlogDbContext _context;
        //private readonly IMapper _mapper;


        public GenericRepository(BlogDbContext context)
        {
            this._context = context;

        }

        public Task<List<T>> GetAll()
        {
            return this._context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await this._context.Set<T>().FindAsync(id);
        }

        public async Task<bool> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var obj = await this._context.Set<T>().FindAsync(id);

            if (obj != null)
                this._context.Set<T>().Remove(obj);

            return await this._context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(T entity, int Id)
        {
            T existing = this._context.Set<T>().Find(Id);
            this._context.Entry(existing).CurrentValues.SetValues(entity);
            //_context.Set<T>().Update(entity);
            //_context.Entry(entity).State = EntityState.Modified;            
                      
            return await this._context.SaveChangesAsync() > 0;
        }

    }
}
