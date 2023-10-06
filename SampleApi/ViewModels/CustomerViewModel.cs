#nullable disable

using SampleApi.Models;

namespace SampleApi.ViewModels;

public class CustomerViewModel
{
    public string CustomerName { get; set; }

    public string ManagerName { get; set; }

    public decimal Amount { get; set; }
}

/// <summary>
/// Customer class for extracting model to view model
/// </summary>
public class CustomerFormingModel
{
    /// <summary>
    /// Extracting Customers to Customers view models
    /// </summary>
    /// <param name="models"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static IEnumerable<CustomerViewModel> FormingViewModels(List<Order> models)
	{
		try
		{
			var customers = new List<CustomerViewModel>();

            foreach (var customer in models)
            {
                customers.Add(new CustomerViewModel
                {
                    Amount = customer.Amount,
                    CustomerName = customer.Customer.Name,
                    ManagerName = customer.Customer.Manager.Name,
                });
            }

            return customers;
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message, ex);
		}
    }
}