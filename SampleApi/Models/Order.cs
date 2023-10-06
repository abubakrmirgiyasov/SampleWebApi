#nullable disable

using SampleApi.Models.Abstracts;

namespace SampleApi.Models;

public class Order : EntityBase<Guid>
{
    public decimal Amount { get; set; }

    public Guid CustomerId { get; set; }

    public virtual Customer Customer { get; set; }
}
