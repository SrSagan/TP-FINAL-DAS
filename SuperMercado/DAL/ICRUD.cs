using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal interface ICRUD<T>
    {
        int Create(T entity);
        T GetById(int id);
        int Update(T entity);
        int Delete(int id);
        List<T> GetAll();
    }
}
