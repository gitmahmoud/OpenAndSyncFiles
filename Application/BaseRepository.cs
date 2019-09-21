using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ChemiCleanContext context;
        internal DbSet<TEntity> dbSet;

        public BaseRepository(ChemiCleanContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public IEnumerable<TEntity> GetPagedFiltered<TKProperty>(Expression<Func<TEntity, bool>> filter, int pageIndex, int pageCount, Expression<Func<TEntity, TKProperty>> orderByExpression,
                 bool @ascending)
        {
            if (pageIndex < 0 || pageCount <= 0)
                throw new ArgumentException(String.Format("Page Index < 0 or Page Count <= 0; PageIndex = {0}, PageCount = {1}", pageIndex, pageCount));

            IQueryable<TEntity> set = dbSet.Where(filter);
            

            if (ascending)
            {
                return set.OrderBy(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount);
            }
            return set.OrderByDescending(orderByExpression)
                .Skip(pageCount * pageIndex)
                .Take(pageCount);
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;

        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        //public virtual IEnumerable<TEntity> GetWithRawSql(string query,
        //    params object[] parameters)
        //{
        //    return dbSet.SqlQuery(query, parameters).ToList();
        //}



        //public virtual void Delete(object id)
        //{
        //    TEntity entityToDelete = dbSet.Find(id);
        //    Delete(entityToDelete);
        //}

        //public virtual void Delete(TEntity entityToDelete)
        //{
        //    if (context.Entry(entityToDelete).State == EntityState.Detached)
        //    {
        //        dbSet.Attach(entityToDelete);
        //    }
        //    dbSet.Remove(entityToDelete);
        //}


    }
}

