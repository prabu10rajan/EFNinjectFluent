using Common.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.DataAccess
{
    //T represents the entity class being passed.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //IEntityRepository will consume IEntity interface.
        //Common Methods
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
