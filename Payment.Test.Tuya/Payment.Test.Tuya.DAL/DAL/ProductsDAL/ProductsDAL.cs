using Payment.Test.Tuya.DAL.Context;
using Payment.Test.Tuya.DAL.Generic;
using Payment.Test.Tuya.Models;

namespace Payment.Test.Tuya.DAL.ProductsDAL
{
    public class ProductsDAL: GenericRepositoryDAL<Products>, IProductsDAL
    {
        public ProductsDAL(ApplicationContext applicationContext): base(applicationContext)
        {
        }
    }
}
