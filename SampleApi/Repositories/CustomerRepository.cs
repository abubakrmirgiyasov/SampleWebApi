using Microsoft.EntityFrameworkCore;
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

    public async Task<IEnumerable<CustomerViewModel>> GetCustomersAsync(DateTimeOffset beginDate, decimal amount)
    {
        try
        {
            var customers = await _context.Orders
                .Include(x => x.Customer)
                .ThenInclude(x => x.Manager)
                // .Where(x.Amount > amount)
                //.Where(x => x.CreationDate >= beginDate && x.CreationDate <= DateTimeOffset.Now) // slower because it is filtered in the database
                .ToListAsync();

            var filteredData = customers
                .Where(x => x.Amount > amount)
                .Where(x => x.CreationDate >= beginDate && x.CreationDate <= DateTimeOffset.Now)
                .ToList(); // more faster because C# filters in work :)

            return CustomerFormingModel.FormingViewModels(filteredData);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
}
