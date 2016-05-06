using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DatabaseStore.EF
{
    public class DbContextQueryManager<T> : IApplicationContext<T>
        where T : class
    {
        private readonly ApplicationData _dbManager = new ApplicationData();
        private DbSet<T> _entityModel;
        public DbContextQueryManager()
        {
            _entityModel = _dbManager.Set<T>();
        }

        public int Add(T entity)
        {

            _entityModel.Add(entity);
            return _dbManager.SaveChanges();
            //throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
     
            _entityModel.Remove(entity);
           return _dbManager.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entityModel.ToList();        
        }

        public T GetById(int id)
        {
            return _entityModel.Find(id);          
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
