using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Matrix.Domain.Interfaces
{
    /// <summary>
    /// Generic repository used for access to domain entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindAllNonTracked();
        IQueryable<T> FindAll(params string[] includes);
        IQueryable<T> FindAll<TProperty>(Expression<Func<T, TProperty>> include);
        IQueryable<T> FindAll<TProperty, TProperty2>(Expression<Func<T, TProperty>> include, Expression<Func<T, TProperty2>> include2);
        IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
        //void RefreshObject(T record);
    }
}
