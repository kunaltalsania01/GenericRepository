using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL
{
   public interface _IAllRepository<T> where T :class
    {
        IEnumerable<T> GetModelList();
        void InsertModel(T model);
    }
}
