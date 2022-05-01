using System;

namespace Payment.Test.Tuya.Models
{
    public class Invoice
    {        
        public Guid ID { get; set; }
     
        public double Total { get; set; }

        public Orders Orders { get; set; }

        public DateTime OrderDate  { get; set; }

        public string Comments { get; set; }

    }
}
