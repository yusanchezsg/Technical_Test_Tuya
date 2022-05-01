using Payment.Test.Tuya.BL.Interfaces;
using Payment.Test.Tuya.Models;
using System.Collections.Generic;

namespace Payment.Test.Tuya.BL.InvoiceBL
{
    public interface IInvoiceServiceBL: IGenericServiceBL<Invoice>
    {
        double TotalInvoice(List<Products> products);

        Invoice InvoiceDetail(Orders orders);
    }
}
