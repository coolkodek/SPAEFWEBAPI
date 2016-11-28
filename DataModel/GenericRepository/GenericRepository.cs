using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataModel.GenericRepository
{
    /// <summary>
    /// Generic Repository class for Entity Operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T>:IRepository<T> where T : class
    {
        private CustomerDBContext Context;
        private DbSet<T> DbSet;

        public GenericRepository(CustomerDBContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList<T>();
        }

        public T GetByID(int id)
        {
            return DbSet.Find(id);
        }

        public void Insert(T item)
        {
            DbSet.Add(item);
        }

        public void Delete(int id)
        {
            T item = DbSet.Find(id);
            DbSet.Remove(item);
        }

        public void Update(int id,T item)
        {
            T itemToRemove = DbSet.Find(id);
            DbSet.Remove(itemToRemove);
            DbSet.Add(item);
        }

        //public void Save()
        //{
        //    Context.SaveChanges();
        //}

        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            Context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
       // }

        //public virtual List<T> GetAll()
        //{
        //    return DbSet.ToList<T>();
        //}

        //public virtual object Add(T item)
        //{
        //    DbSet.Add(item);
        //    Context.SaveChanges();
        //    return item;
        //}

        //public virtual object Update(int key,T Item)
        //{
        //    //CustomerDBContext customersdb = new CustomerDBContext();
        //    //Customer customerToRemove = customersdb.Customers.Find(customer.id);

        //    //customersdb.Customers.Remove(customerToRemove);
        //    //Custsomer updatedCustomer = customer;
        //    //customersdb.Customers.Add(updatedCustomer);
        //    DbSet.Remove();
        //    DbSet.Add(Item);
        //    Context.SaveChanges();
        //    return item;
        //}

        ///// <summary>
        ///// generic Get method for Entities
        ///// </summary>
        ///// <returns></returns>
        //public virtual IEnumerable<T> Get()
        //{
        //    IQueryable<T> query = DbSet;
        //    return query.ToList();
        //}

        ///// <summary>
        ///// Generic get method on the basis of id for Entities.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public virtual T GetByID(object id)
        //{
        //    return DbSet.Find(id);
        //}

        ///// <summary>
        ///// generic Insert method for the entities
        ///// </summary>
        ///// <param name="entity"></param>
        //public virtual void Insert(T entity)
        //{
        //    DbSet.Add(entity);
        //}

        ///// <summary>
        ///// Generic Delete method for the entities
        ///// </summary>
        ///// <param name="id"></param>
        //public virtual void Delete(object id)
        //{
        //    T entityToDelete = DbSet.Find(id);
        //    Delete(entityToDelete);
        //}

        ///// <summary>
        ///// Generic Delete method for the entities
        ///// </summary>
        ///// <param name="entityToDelete"></param>
        //public virtual void Delete(T entityToDelete)
        //{
        //    if (Context.Entry(entityToDelete).State == EntityState.Detached)
        //    {
        //        DbSet.Attach(entityToDelete);
        //    }
        //    DbSet.Remove(entityToDelete);
        //}

        ///// <summary>
        ///// Generic update method for the entities
        ///// </summary>
        ///// <param name="entityToUpdate"></param>
        //public virtual void Update(T entityToUpdate)
        //{
        //    DbSet.Attach(entityToUpdate);
        //    Context.Entry(entityToUpdate).State = EntityState.Modified;
        //}

        ///// <summary>
        ///// generic method to get many record on the basis of a condition.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public virtual IEnumerable<T> GetMany(Func<T, bool> where)
        //{
        //    return DbSet.Where(where).ToList();
        //}

        ///// <summary>
        ///// generic method to get many record on the basis of a condition but query able.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public virtual IQueryable<T> GetManyQueryable(Func<T, bool> where)
        //{
        //    return DbSet.Where(where).AsQueryable();
        //}

        ///// <summary>
        ///// generic get method , fetches data for the entities on the basis of condition.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public T Get(Func<T, Boolean> where)
        //{
        //    return DbSet.Where(where).FirstOrDefault<T>();
        //}

        ///// <summary>
        ///// generic delete method , deletes data for the entities on the basis of condition.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public void Delete(Func<T, Boolean> where)
        //{
        //    IQueryable<T> objects = DbSet.Where<T>(where).AsQueryable();
        //    foreach (T obj in objects)
        //        DbSet.Remove(obj);
        //}

        ///// <summary>
        ///// generic method to fetch all the records from db
        ///// </summary>
        ///// <returns></returns>
        //public virtual IEnumerable<T> GetAll()
        //{
        //    return DbSet.ToList();
        //}

        ///// <summary>
        ///// Inclue multiple
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <param name="include"></param>
        ///// <returns></returns>
        //public IQueryable<T> GetWithInclude(
        //    System.Linq.Expressions.Expression<Func<T,
        //    bool>> predicate, params string[] include)
        //{
        //    IQueryable<T> query = this.DbSet;
        //    query = include.Aggregate(query, (current, inc) => current.Include(inc));
        //    return query.Where(predicate);
        //}

        ///// <summary>
        ///// Generic method to check if entity exists
        ///// </summary>
        ///// <param name="primaryKey"></param>
        ///// <returns></returns>
        //public bool Exists(object primaryKey)
        //{
        //    return DbSet.Find(primaryKey) != null;
        //}

        ///// <summary>
        ///// Gets a single record by the specified criteria (usually the unique identifier)
        ///// </summary>
        ///// <param name="predicate">Criteria to match on</param>
        ///// <returns>A single record that matches the specified criteria</returns>
       
    }
}
