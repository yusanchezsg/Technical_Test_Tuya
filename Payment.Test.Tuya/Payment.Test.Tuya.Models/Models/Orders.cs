using System.Collections.Generic;

namespace Payment.Test.Tuya.Models
{
    public class Orders
    {
        public List<Products> Products { get; set; } = new List<Products>();

        public Client Client { get; set; }
    }
}
