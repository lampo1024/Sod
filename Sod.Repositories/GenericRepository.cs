using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ServiceStack.OrmLite;
using Sod.Dba;
using Sod.IoC;

namespace Sod.Repositories
{
    public class GenericRepository<T> : IRepository<T>, IDependency
    {
        public T FindById(int id)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                var entity = db.SingleById<T>(id);
                return entity;
            }
        }

        public IEnumerable<T> FindAll()
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                var list = db.Select<T>();
                return list;
            }
        }

        public IPagedList<T> FindPagedList(Expression<Func<T, bool>> predicate, int pageIndex = 0, int pageSize = 20)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                var entities = db.Select<T>(predicate);
                var totalCount = db.Count<T>(predicate);
                var list = new PagedList<T>(entities, pageIndex, pageSize, (int)totalCount);
                return list;
            }
        }

        public int Insert(T entity)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                return (int)db.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                return db.Update(entity) > 0;
            }
        }

        public bool Delete(T entity)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                return db.Delete(entity) > 0;
            }
        }

        public bool Delete(Expression<Func<T, bool>> @where)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                return db.Delete(@where) > 0;
            }
        }

        public bool DeleteById(object id)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                return db.DeleteById<T>(id) > 0;
            }
        }

        public bool DeleteByIds(object[] ids)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                return db.DeleteByIds<T>(ids) > 0;
            }
        }
    }
}
