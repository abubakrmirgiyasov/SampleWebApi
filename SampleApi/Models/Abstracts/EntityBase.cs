#nullable disable

using System.ComponentModel.DataAnnotations;

namespace SampleApi.Models.Abstracts;

public abstract class EntityBase<TKey> : IHasKey<TKey>
{
    [Key]
    public TKey Id { get; set; }

    public DateTimeOffset? UpdateDate { get; set; }

    public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;

    //public DateTimeOffset CreationDate => DateTimeOffset.Now;
}
