#nullable disable

using SampleApi.Models.Abstracts;

namespace SampleApi.Models;

public class Manager : EntityBase<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<Customer> Customers { get; set; }
}
