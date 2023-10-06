using SampleApi.ViewModels;

namespace SampleApi.Repositories.Interfaces;

public interface ICustomerRepository
{
    Task<IEnumerable<CustomerViewModel>> GetCustomersAsync();

    Task<List<CustomerViewModel>> GetCustomersAsync(DateTimeOffset beginDate, decimal amount);
}
