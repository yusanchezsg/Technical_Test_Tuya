using System.ComponentModel.DataAnnotations.Schema;

namespace Payment.Test.Tuya.Models
{
    [Table("CLIENT")]
    public class Client
    {
        [Column("DOCUMENT", Order = 0)]
        public int DocumentId { get; set; }

        [Column("FULLNAME", Order = 1)]
        public string FullName { get; set; }

        [Column("ADDRESS", Order = 2)]
        public string Address { get; set; }

        [Column("PHONENUMBER", Order = 3)]
        public string PhoneNumber { get; set; }
    }
}
