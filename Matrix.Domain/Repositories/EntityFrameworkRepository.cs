using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.SqlClient;
using Matrix.Domain.Extensions;
using Matrix.Domain.Interfaces;

namespace ResMan.Domain.Repositories.EntityFramework
{
    /// <summary>
    /// Generic entity framework repository used to access entities using the Entity Framework
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityFrameworkRepository<T> : IRepository<T> where T : class
    {
        private DbContext context;
        private DbSet<T> dbSet;

        public DbSet<T> DbSet { get { return this.dbSet; } }
        public DbContext Context { get { return this.context; } }

        public EntityFrameworkRepository(DbContext context)
        {
            if (context == null)
            { throw new ArgumentNullException("context"); }

            this.context = context;
            this.dbSet = this.context.Set<T>();
        }

        #region IRepository<T> Members

        public IQueryable<T> FindAll()
        {
            return dbSet;
        }

        public IQueryable<T> FindAllNonTracked()
        {
            return this.DbSet.AsNoTracking();
        }

        public IQueryable<T> FindAll(params string[] includes)
        {
            IQueryable<T> set = dbSet;

            foreach (string include in includes)
                set = set.Include(include);

            return set;
        }

        public IQueryable<T> FindAll<TProperty>(Expression<Func<T, TProperty>> include)
        {
            return dbSet.Include(include);
        }

        public IQueryable<T> FindAll<TProperty, TProperty2>(Expression<Func<T, TProperty>> include, Expression<Func<T, TProperty2>> include2)
        {
            return dbSet.Include(include).Include(include2);
        }

        public IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            this.dbSet.AddRange(entities);
        }

        public void Update(T entity)
        {
            this.dbSet.Attach(entity);
            this.context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        //public void Remove(T entity)
        public void Delete(T entity)
        {
            // Check to see if the entity is already attached to
            // the context
            if (!this.Context.IsAttached(ref entity))
            {
                this.DbSet.Attach(entity);
            }

            dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            List<T> entityList = entities.ToList();

            // Check to see if the entity is already attached to
            // the context
            for (int i = 0; i < entityList.Count(); i++)
            {
                T entity = entityList[i];
                if (!this.Context.IsAttached(ref entity))
                {
                    this.DbSet.Attach(entity);
                }
            }

            dbSet.RemoveRange(entities);
        }

        //public IEnumerable<T> ExecuteStoredProcedure<T>(string procedureName, params object[] parameters)
        //{
        //    return this.context.ExecuteStoredProcedure<T>(procedureName, parameters);
        //}

        //public IEnumerable<T> ExecuteStoredProcedure<T>(string procedureName, params SqlParameter[] parameters)
        //{
        //    return this.context.ExecuteStoredProcedure<T>(procedureName, parameters);
        //}

        ////public IEnumerable<T> ExecuteStoredProcedureWithSqlParameters<T>(string procedureName, params object[] parameters)
        ////{
        ////    return this.context.ExecuteStoredProcedureWithSqlParameters<T>(procedureName, parameters);
        ////}

        //public int ExecuteStoredProcedure(string procedureName, params object[] parameters)
        //{
        //    return this.context.ExecuteStoredProcedure(procedureName, parameters);
        //}

        //public void RefreshObject(T record)
        //{
        //    this.context.ObjectContext().Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, record);
        //}

        #endregion

    }
}
