using Microsoft.EntityFrameworkCore;
using PersonalApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected DbContext _dbcontext;

        private DbSet<TEntity> _dbset;

        public Repository(DbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbset = _dbcontext.Set<TEntity>();
        }


        public void Add(TEntity entity)
        {
            // For Example: _dbcontext.Set<TEntity>() => _dbcontext.Departments 

            _dbset.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {

            _dbset.AddRange(entities);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbset.ToList();
        }

        public TEntity GetById(int id)
        {
           return _dbset.Find(id);
        }

        public void Remove(int id)
        {
            _dbset.Remove(GetById(id));
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbset.RemoveRange(entities);
        }
    }
}
