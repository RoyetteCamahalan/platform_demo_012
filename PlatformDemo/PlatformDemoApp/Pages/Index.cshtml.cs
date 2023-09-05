using Microsoft.AspNetCore.Mvc.RazorPages;
using PlatformDemoLib.Dto;
using PlatformDemoLib.Services.Interface;

namespace PlatformDemoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerService _customerService;

        public ICollection<CustomerDto> customers { get; set; } = new List<CustomerDto>();
        public IndexModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task OnGet()
        {
            customers = await _customerService.GetCustomerOrders();
        }
    }
}