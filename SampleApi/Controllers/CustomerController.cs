using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Repositories.Interfaces;
using SampleApi.ViewModels;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerRepository _customer;

    public CustomerController(ICustomerRepository customer)
    {
        _customer = customer;
    }

    [HttpGet]
    public async Task<IActionResult> GetCustomers()
    {
        try
        {
            var customers = await _customer.GetCustomersAsync();
            return Ok(customers);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpGet("{beginDate}&{amount}")]
    public async Task<IActionResult> GetCustomers(string beginDate, decimal amount)
    {
        try
        {
            var customers = await _customer.GetCustomersAsync(DateTime.Parse(beginDate), amount);
            return Ok(customers);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}
