namespace SampleApi.Models.Abstracts;

public interface IHasKey<TKey>
{
    TKey Id { get; set; }
}
