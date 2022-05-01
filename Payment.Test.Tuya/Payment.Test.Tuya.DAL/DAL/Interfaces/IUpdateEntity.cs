namespace Payment.Test.Tuya.DAL.Interfaces
{
    public interface IUpdateEntity<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
    }
}
