using Microsoft.Extensions.DependencyInjection;
using Payment.Test.Tuya.BL.InvoiceBL;
using Payment.Test.Tuya.BL.ProductsBL;
using Payment.Test.Tuya.DAL.Generic;
using Payment.Test.Tuya.DAL.Interfaces;
using Payment.Test.Tuya.DAL.InvoiceDAL;
using Payment.Test.Tuya.DAL.ProductsDAL;
using Payment.Test.Tuya.Models;

namespace Payment.Test.Tuya.API.Extension
{
    public static class ServicesInjection
    {
        public static void AddServices(this IServiceCollection services)
        {

            services.AddTransient<IUnitOfWork<Products>, UnitOfWork<Products>>();

            services.AddTransient<IProductsServiceBL, ProductsServiceBL>();

            services.AddTransient<IProductsDAL, ProductsDAL>();

            services.AddTransient<IUnitOfWork<Invoice>, UnitOfWork<Invoice>>();

            services.AddTransient<IInvoiceServiceBL, InvoiceServiceBL>();

            services.AddTransient<IInvoiceDAL, InvoiceDAL>();

        }

    }
}
