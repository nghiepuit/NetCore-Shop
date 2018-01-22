using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopOnline.Infrastructure.Interfaces
{
    public interface IRepository<T, K> where T : class
    {
        /// <summary>
        /// Tìm theo Id
        /// </summary>
        /// <param name="id">Id có thể là int, string hoặc tùy ý</param>
        /// <param name="includeProperties">Có thể kèm theo các tham số : Product -> ProductCategory</param>
        /// <returns></returns>
        T FindById(K id, params Expression<Func<T, object>>[] includeProperties);

        /// <summary>
        /// Tìm theo điều kiện
        /// </summary>
        /// <param name="predicate">Điều kiện dùng biểu thức lambda expression : true-false</param>
        /// <param name="includeProperties">Đính kèm theo</param>
        /// <returns></returns>
        T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        /// <summary>
        /// Lấy tất cả
        /// </summary>
        /// <param name="includeProperties">Đính kèm theo</param>
        /// <returns></returns>
        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);

        /// <summary>
        /// Lấy tất cả theo điều kiện
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        void Add(T Entity);

        void Update(T Entity);

        void Remove(T Entity);

        void Remove(K id);

        void RemoveMultiple(List<T> entities);
    }
}