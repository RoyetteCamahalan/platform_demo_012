using PlatformDemoLib.Dto;

namespace PlatformDemoLib.Services.Interface
{
    public interface ICustomerService
    {
        public Task<ICollection<CustomerDto>> GetCustomerOrders();
    }
}
