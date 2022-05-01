using Payment.Test.Tuya.DAL.Context;
using Payment.Test.Tuya.DAL.Generic;
using System;

namespace Payment.Test.Tuya.DAL.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        ApplicationContext context { get; }

        GenericRepositoryDAL<T> GenericRepositoryDAL { get; }

        void Save();
    }
}
