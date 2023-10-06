using SampleApi.ViewModels;

namespace SampleApi.Repositories.Interfaces;

public interface ICustomerRepository
{
    Task<IEnumerable<CustomerViewModel>> GetCustomersAsync();

    Task<IEnumerable<CustomerViewModel>> GetCustomersAsync(DateTimeOffset beginDate, decimal amount);
}
