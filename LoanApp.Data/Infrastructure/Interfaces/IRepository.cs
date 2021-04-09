using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApp.Data.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Add(T obj);
        void Update(T obj);
        void Delete(object id);
    }
}
