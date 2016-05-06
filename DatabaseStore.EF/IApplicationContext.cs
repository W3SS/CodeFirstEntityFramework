using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseStore.EF
{
    public interface IApplicationContext<T>
    {
        int Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();
        T GetById(int Id);
    }
}
