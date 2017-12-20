using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Dapper.Models.Interfaces
{
    public interface IRepository<T> where T:class
    {
        void Create(T item);
        void Remove(int Id);
        void Update(T item);
        IEnumerable<T> GetAll();
        T Get(int Id);
    }
}
