using Microsoft.EntityFrameworkCore;
using SampleApi.Models;
using SampleApi.Repositories.Interfaces;
using SampleApi.Services;
using SampleApi.ViewModels;

namespace SampleApi.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    public CustomerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CustomerViewModel>> GetCustomersAsync()
    {
        try
        {
            var customers = await _context.Orders
                .Include(x => x.Customer)
                .ThenInclude(x => x.Manager)
                .ToListAsync();

            return CustomerFormingModel.FormingViewModels(customers);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }

    public async Task<List<CustomerViewModel>> GetCustomersAsync(DateTimeOffset beginDate, decimal amount)
    {
        try
        {
            var customers = await _context.Orders
                .Include(x => x.Customer)
                .ThenInclude(x => x.Manager)
                .GroupBy(x => x.Customer.Id)
                .ToListAsync();

            var viewModels = new List<CustomerViewModel>();

            for (int i = 0; i < customers.Count; i++)
            {
                viewModels.Add(new CustomerViewModel()
                {
                    Amount = customers[i].Sum(x => x.Amount),
                    CustomerName = customers[i].First().Customer.Name,
                    ManagerName = customers[i].First().Customer.Manager.Name,
                    CreationDate = customers[i].First().CreationDate,
                });
            }

            return viewModels.Where(x => x.Amount > amount && x.CreationDate >= beginDate && x.CreationDate <= DateTimeOffset.Now).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
}
