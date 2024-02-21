using Microsoft.AspNetCore.Mvc;

namespace InterviuPam.Web.Controllers;
[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase {
    private readonly IConfiguration _configuration;

    public CustomerController(
        IConfiguration configuration) {
        _configuration = configuration;
    }

    [HttpGet]
    public object GetCustomer(int customerId) {
        var context = new AdventureWorksContext(_configuration.GetConnectionString("AdventureWorks"));
        context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

        var customer = context.Customers.Where(c=>c.CustomerID == customerId);

        return customer;
    }
}
