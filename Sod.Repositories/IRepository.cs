using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Sod.Dba;

namespace Sod.Repositories
{
    public interface IRepository<T>
    {
        /// <summary>
        /// 根据ID查询单条数据
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        T FindById(int id);
        /// <summary>
        /// 查询所有数据(无分页,请慎用)
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> FindAll();

        /// <summary>
        /// 根据条件查询分页数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <returns></returns>
        IPagedList<T> FindPagedList( Expression<Func<T,bool>> predicate, int pageIndex = 0, int pageSize = 20);

        /// <summary>
        /// 写入实体数据
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        int Insert(T entity);

        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(T entity);

        bool Delete(T entity);

        bool Delete(Expression<Func<T,bool>> @where);

        /// <summary>
        /// 删除指定ID的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteById(object id);

        /// <summary>
        /// 删除指定ID集合的数据(批量删除)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        bool DeleteByIds(object[] ids);
    }
}
