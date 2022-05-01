namespace Payment.Test.Tuya.BL.Interfaces
{
    public interface IUpdateServiceBL<T> where T :class
    {
        void Update(T entity);
    }
}
