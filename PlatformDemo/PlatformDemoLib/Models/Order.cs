using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatformDemoLib.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string OrderNo { get; set; } = string.Empty;
        public long CustomerId { get; set; }
        public decimal Amount { get; set; }

        public Customer? customer { get; set; }
    }
}
