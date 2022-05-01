using Payment.Test.Tuya.DAL.Context;
using Payment.Test.Tuya.DAL.Interfaces;

namespace Payment.Test.Tuya.DAL.Generic
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {

        public ApplicationContext _context { get; }

        public GenericRepositoryDAL<T> repository;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public GenericRepositoryDAL<T> GenericRepositoryDAL
        {
            get
            {
                if(this.repository==null)
                {
                    this.repository = new GenericRepositoryDAL<T>(_context);
                }
                return this.repository;
            }
        }

        public ApplicationContext Context => throw new System.NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
