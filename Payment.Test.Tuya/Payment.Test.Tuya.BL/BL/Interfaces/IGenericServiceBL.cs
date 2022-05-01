namespace Payment.Test.Tuya.BL.Interfaces
{
    public interface IGenericServiceBL<Model> : ICreateServiceBL<Model>, IGetServiceBL<Model>,
                                                  IUpdateServiceBL<Model>, IDeleteServiceBL<Model>
                                                  where Model : class
    {
    }
}
