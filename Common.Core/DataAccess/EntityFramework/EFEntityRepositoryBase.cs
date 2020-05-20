using Common.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.DataAccess.EntityFramework
{
    // This generic class is used to represent most common operations(CRUD) irrespective of entity model.
    // Helps to reduce code duplication for every single entity model being created.
    // T represents that any Entity class(here Product from the entire solution) from IEntity can be passed. TContext is for generic EF DBContext
    public class EFEntityRepositoryBase<T, TContext> : IEntityRepository<T> 
        where T:class, IEntity, new()
        where TContext:DbContext, new()
    {
        public T Add(T entity)
        {
            using (var context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using(var context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public T Update(T entity)
        {
            using (var context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }
    }
}
