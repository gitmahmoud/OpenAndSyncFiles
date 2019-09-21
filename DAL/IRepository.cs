using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        IEnumerable<TEntity> GetPagedFiltered<TKProperty>(Expression<Func<TEntity, bool>> filter, int pageIndex, int pageCount, Expression<Func<TEntity, TKProperty>> orderByExpression, bool ascending);

        TEntity GetByID(object id);

        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);

        //IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);

        //void Delete(TEntity entityToDelete);
        //void Delete(object id);

    }
}



