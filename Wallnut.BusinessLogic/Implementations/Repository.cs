using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Wallnut.BusinessLogic.Interfaces;

namespace Wallnut.BusinessLogic.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }
        
        public TEntity Get(params object[] KeyValues)
        {
            return Context.Set<TEntity>().Find(KeyValues);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            //Context.Set<TEntity>().AddRange(entities);
            
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
          //  Context.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity) 
    {
        (Context as DbContext).Entry(entity).State = System.Data.EntityState.Modified;
    }
    }
}
