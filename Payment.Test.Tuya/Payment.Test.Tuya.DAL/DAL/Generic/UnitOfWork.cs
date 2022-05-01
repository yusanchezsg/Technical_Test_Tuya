using Payment.Test.Tuya.DAL.Context;
using Payment.Test.Tuya.DAL.Interfaces;

namespace Payment.Test.Tuya.DAL.Generic
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {

        public ApplicationContext context { get; }

        private GenericRepositoryDAL<T> repository;

        public UnitOfWork(ApplicationContext _context)
        {
            context = _context;
        }

        public GenericRepositoryDAL<T> GenericRepositoryDAL
        {
            get
            {
                if(this.repository==null)
                {
                    this.repository = new GenericRepositoryDAL<T>(context);
                }
                return this.repository;
            }
        }        

        public void Dispose()
        {
            context.Dispose();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
