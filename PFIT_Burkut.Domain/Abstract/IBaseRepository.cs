using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFIT_Burkut.Domain.Abstract
{
   public interface IBaseRepository<T> where T:class
    {
        IEnumerable<T> getAll();
        T get(int id);
        void remove(T item);
        void create(T item);
    }
}
