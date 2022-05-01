using Microsoft.EntityFrameworkCore;
using Payment.Test.Tuya.DAL.Context;
using Payment.Test.Tuya.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Payment.Test.Tuya.DAL.Generic
{
    public class GenericRepositoryDAL<TEntity> : IGenericRepositoryDAL<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _applicationContext;

        public GenericRepositoryDAL(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public TEntity Create(TEntity entity)
        {
            _applicationContext.Set<TEntity>().Add(entity);
            return entity;
        }

        public TEntity Get(int Id)
        {
            return _applicationContext.Set<TEntity>().FirstOrDefault();
        }

        public List<TEntity> Get()
        {
            return _applicationContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            TEntity exists = _applicationContext.Set<TEntity>().Find(entity);
            if (exists != null)
                _applicationContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _applicationContext.Entry(entity).State = EntityState.Modified;
            _applicationContext.Set<TEntity>().Attach(entity);
        }
    }
}
