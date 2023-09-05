using Microsoft.EntityFrameworkCore;
using PlatformDemoLib.Models;

namespace PlatformDemoLib.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>().HasOne(o => o.customer).WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Michael Curry", ContactNo = "6543210" },
                new Customer { Id = 2, Name = "Stephen Jordan", ContactNo = "0654321" },
                new Customer { Id = 3, Name = "Kobe Durant", ContactNo = "1065432" },
                new Customer { Id = 4, Name = "Kevin Bryant", ContactNo = "2106543" },
                new Customer { Id = 5, Name = "Derrick Nowitzki", ContactNo = "3210654" },
                new Customer { Id = 6, Name = "Dirk Rose", ContactNo = "4321065" },
                new Customer { Id = 7, Name = "Jordan Green", ContactNo = "5432106" },
                new Customer { Id = 8, Name = "Jeff Clarkson", ContactNo = "1234560" },
                new Customer { Id = 9, Name = "Ben Tatum", ContactNo = "234501" },
                new Customer { Id = 10, Name = "Jason Simmons", ContactNo = "345012" },
                new Customer { Id = 11, Name = "Luka Kidd", ContactNo = "450123" },
                new Customer { Id = 12, Name = "Jason Doncic", ContactNo = "501234" },
                new Customer { Id = 13, Name = "Kyrie George", ContactNo = "01235" }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, OrderNo = "001", CustomerId = 1, Amount = 100 },
                new Order { Id = 2, OrderNo = "002", CustomerId = 1, Amount = 200 },
                new Order { Id = 3, OrderNo = "003", CustomerId = 1, Amount = 300 },
                new Order { Id = 4, OrderNo = "004", CustomerId = 1, Amount = 400 },
                new Order { Id = 5, OrderNo = "005", CustomerId = 2, Amount = 500 },
                new Order { Id = 6, OrderNo = "006", CustomerId = 2, Amount = 600 },
                new Order { Id = 7, OrderNo = "007", CustomerId = 3, Amount = 700 },
                new Order { Id = 8, OrderNo = "008", CustomerId = 3, Amount = 800 },
                new Order { Id = 9, OrderNo = "009", CustomerId = 3, Amount = 900 },
                new Order { Id = 10, OrderNo = "010", CustomerId = 4, Amount = 1000 },
                new Order { Id = 11, OrderNo = "011", CustomerId = 4, Amount = 1100 },
                new Order { Id = 12, OrderNo = "012", CustomerId = 5, Amount = 1200 },
                new Order { Id = 13, OrderNo = "013", CustomerId = 5, Amount = 1300 },
                new Order { Id = 14, OrderNo = "014", CustomerId = 8, Amount = 1400 },
                new Order { Id = 15, OrderNo = "015", CustomerId = 8, Amount = 1500 },
                new Order { Id = 16, OrderNo = "016", CustomerId = 11, Amount = 1600 },
                new Order { Id = 17, OrderNo = "017", CustomerId = 11, Amount = 1700 },
                new Order { Id = 18, OrderNo = "018", CustomerId = 12, Amount = 1800 },
                new Order { Id = 19, OrderNo = "019", CustomerId = 13, Amount = 1900 },
                new Order { Id = 20, OrderNo = "020", CustomerId = 6, Amount = 2000 },
                new Order { Id = 21, OrderNo = "021", CustomerId = 6, Amount = 2100 },
                new Order { Id = 22, OrderNo = "022", CustomerId = 6, Amount = 2200 },
                new Order { Id = 23, OrderNo = "023", CustomerId = 6, Amount = 2300 },
                new Order { Id = 24, OrderNo = "024", CustomerId = 6, Amount = 2400 },
                new Order { Id = 25, OrderNo = "025", CustomerId = 6, Amount = 2500 }
                );
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
