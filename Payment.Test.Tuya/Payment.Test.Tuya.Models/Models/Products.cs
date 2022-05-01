using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payment.Test.Tuya.Models
{
    [Table("PRODUCTS")]
    public class Products
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int ProductId { get; set; }

        [Column("PL", Order = 1)]
        public string ProductPL { get; set; }

        [Column("NAME", Order = 2)]
        public string ProductName { get; set; }

        [Column("AMOUNT", Order = 3)]
        public float ProductValue { get; set; }
    }
}
