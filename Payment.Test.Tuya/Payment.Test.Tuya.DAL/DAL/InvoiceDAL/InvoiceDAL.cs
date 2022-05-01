using Payment.Test.Tuya.DAL.Context;
using Payment.Test.Tuya.DAL.Generic;
using Payment.Test.Tuya.Models;

namespace Payment.Test.Tuya.DAL.InvoiceDAL
{
    public class InvoiceDAL : GenericRepositoryDAL<Invoice>, IInvoiceDAL
    {
        public InvoiceDAL(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}
