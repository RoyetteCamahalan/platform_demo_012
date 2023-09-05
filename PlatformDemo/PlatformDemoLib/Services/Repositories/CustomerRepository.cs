using Microsoft.EntityFrameworkCore;
using PlatformDemoLib.Data;
using PlatformDemoLib.Dto;
using PlatformDemoLib.Services.Interface;

namespace PlatformDemoLib.Services.Repositories
{
    public class CustomerRepository : ICustomerService
    {
        private readonly DataContext _dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //Gets Customer with their total order amount
        public async Task<ICollection<CustomerDto>> GetCustomerOrders()
        {
            return await (from c in _dataContext.customers
                          join o in _dataContext.orders on c.Id equals o.CustomerId into cotemp
                          from co in cotemp.DefaultIfEmpty()
                          group co by c into gp
                          select new CustomerDto
                          {
                              Id = gp.Key.Id,
                              Name = gp.Key.Name,
                              ContactNo = gp.Key.ContactNo,
                              TotalOrder = gp.Sum(x => x.Amount)
                          }).ToListAsync();
        }
    }
}
