using GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepository.DAL
{
    public class AllRepository<T> : _IAllRepository<T> where T : class
    {
        private TestEntities _context;
        private IDbSet<T> dbEntity;

        public AllRepository()
        {
            _context = new TestEntities();
            dbEntity = _context.Set<T>();
        }
        public IEnumerable<T> GetModelList()
        {
            return dbEntity.ToList();
        }

        public void InsertModel(T model)  
        {
            throw new NotImplementedException();
        }
    }
}