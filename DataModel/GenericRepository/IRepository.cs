using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.GenericRepository
{
    public interface IRepository<T>
    {

        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Insert(T item);
        void Delete(int id);
        void Update(int id,T item);

    }
}

;