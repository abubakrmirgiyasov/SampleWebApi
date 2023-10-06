#nullable disable

using SampleApi.Models.Abstracts;

namespace SampleApi.Models;

public class Customer : EntityBase<Guid>
{
    public string Name { get; set; }

    public Guid ManagerId { get; set; }

    public virtual Manager Manager { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
