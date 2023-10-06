using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SampleApi.Constants;
using SampleApi.Models;

namespace SampleApi.Services;

/// <summary>
/// Application Db Service
/// </summary>
public class ApplicationDbContext : DbContext
{
    private readonly AppSettings _appSettings;

    /// <summary>
    /// Application Db Constructor
    /// </summary>
    /// <param name="appSettings"></param>
    public ApplicationDbContext(IOptions<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }

    /// <summary>
    /// Customers Table
    /// </summary>
    public DbSet<Customer> Customers { get; set; }

    /// <summary>
    /// Orders Table
    /// </summary>
    public DbSet<Order> Orders { get; set; }

    /// <summary>
    /// Managers Table
    /// </summary>
    public DbSet<Manager> Managers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_appSettings.ConnectionStrings.SqlServerConnection);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Customer>()
            .HasOne(x => x.Manager)
            .WithMany(x => x.Customers)
            .HasForeignKey(x => x.ManagerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Order>()
            .HasOne(x => x.Customer)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        var managers = new List<Manager>()
        {
            new Manager()
            {
                Id = Guid.NewGuid(),
                Name = "Жуков Даниил Евгеньевич",
            },
            new Manager()
            {
                Id = Guid.NewGuid(),
                Name = "Розанов Макар Михайлович",
            },
            new Manager()
            {
                Id = Guid.NewGuid(),
                Name = "Соколова Алина Никитична",
            },
        };

        var customers = new List<Customer>()
        {
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Воронова Ксения Дмитриевна",
                ManagerId = managers[0].Id,
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Семин Денис Григорьевич",
                ManagerId = managers[1].Id,
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Муравьев Кирилл Тихонович",
                ManagerId = managers[0].Id,
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Попова Кира Кирилловна",
                ManagerId = managers[2].Id,
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Рыжов Даниил Кириллович",
                ManagerId = managers[1].Id,
            }
        };

        var orders = new List<Order>()
        {
            new Order()
            {
                Id = Guid.NewGuid(),
                Amount = 578,
                CustomerId = customers[0].Id,
                CreationDate = DateTime.Parse("06.10.2023"),
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                Amount = 1203,
                CustomerId = customers[1].Id,
                CreationDate = DateTime.Parse("03.10.2023"),
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                Amount = 1000,
                CustomerId = customers[2].Id,
                CreationDate = DateTime.Parse("01.10.2023"),
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                Amount = 999,
                CustomerId = customers[3].Id,
                CreationDate = DateTime.Parse("29.09.2023"),
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                Amount = 790,
                CustomerId = customers[4].Id,
                CreationDate = DateTime.Parse("30.09.2023"),
            }
        };

        builder.Entity<Customer>().HasData(customers);
        builder.Entity<Order>().HasData(orders);
        builder.Entity<Manager>().HasData(managers);
    }
}
