using System.ComponentModel.DataAnnotations;

namespace PlatformDemoLib.Models
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public ICollection<Order>? Orders { get; set; }
    }
}
