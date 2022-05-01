using Payment.Test.Tuya.BL.Generic;
using Payment.Test.Tuya.DAL.Interfaces;
using Payment.Test.Tuya.Models;
using System.Collections.Generic;

namespace Payment.Test.Tuya.BL.ProductsBL
{
    public class ProductsServiceBL : GenericServiceBL<Products>, IProductsServiceBL
    {
        public ProductsServiceBL(IUnitOfWork<Products> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
