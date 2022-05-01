using System.Collections.Generic;

namespace Payment.Test.Tuya.DAL.Interfaces
{
    public interface IGetEntity<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        List<TEntity> Get();
    }
}
