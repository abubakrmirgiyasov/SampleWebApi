﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleApi.Services;

#nullable disable

namespace SampleApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SampleApi.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e6b9a17a-243f-44fe-b5fc-78bb5276c21a"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("8c1ef088-537d-4f86-87be-53cfcfffe523"),
                            Name = "Воронова Ксения Дмитриевна"
                        },
                        new
                        {
                            Id = new Guid("7e150fb6-3aec-4df5-bf6f-e804c2b8b488"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2019), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("da60a851-3106-4cdd-8bdf-468d82b99c03"),
                            Name = "Семин Денис Григорьевич"
                        },
                        new
                        {
                            Id = new Guid("1aef54df-6132-4d17-ab4f-c60f83d39a6e"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("8c1ef088-537d-4f86-87be-53cfcfffe523"),
                            Name = "Муравьев Кирилл Тихонович"
                        },
                        new
                        {
                            Id = new Guid("d6c6b95e-3e53-424f-92e1-6569029f4a9f"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2029), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("e755978a-44bd-4106-bde1-1e88bca3d0cf"),
                            Name = "Попова Кира Кирилловна"
                        },
                        new
                        {
                            Id = new Guid("23a4127d-7df2-4561-8ba8-5b4a08ca0229"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2050), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("da60a851-3106-4cdd-8bdf-468d82b99c03"),
                            Name = "Рыжов Даниил Кириллович"
                        });
                });

            modelBuilder.Entity("SampleApi.Models.Manager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8c1ef088-537d-4f86-87be-53cfcfffe523"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Жуков Даниил Евгеньевич"
                        },
                        new
                        {
                            Id = new Guid("da60a851-3106-4cdd-8bdf-468d82b99c03"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Розанов Макар Михайлович"
                        },
                        new
                        {
                            Id = new Guid("e755978a-44bd-4106-bde1-1e88bca3d0cf"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Соколова Алина Никитична"
                        });
                });

            modelBuilder.Entity("SampleApi.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b85abd28-af4a-4bb2-a486-7ac6ff66436e"),
                            Amount = 578m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("e6b9a17a-243f-44fe-b5fc-78bb5276c21a")
                        },
                        new
                        {
                            Id = new Guid("afd2c5f1-4085-404d-badc-f5341881cf70"),
                            Amount = 1203m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("e6b9a17a-243f-44fe-b5fc-78bb5276c21a")
                        },
                        new
                        {
                            Id = new Guid("249b5ebb-9196-4119-9b41-9c2f2a14b31d"),
                            Amount = 1000m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("1aef54df-6132-4d17-ab4f-c60f83d39a6e")
                        },
                        new
                        {
                            Id = new Guid("2e0eb0b7-c04f-4f2e-b60c-1c9e482fd061"),
                            Amount = 999m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("d6c6b95e-3e53-424f-92e1-6569029f4a9f")
                        },
                        new
                        {
                            Id = new Guid("8edfe056-8943-4d70-9149-9577d4b28e4d"),
                            Amount = 790m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("23a4127d-7df2-4561-8ba8-5b4a08ca0229")
                        });
                });

            modelBuilder.Entity("SampleApi.Models.Customer", b =>
                {
                    b.HasOne("SampleApi.Models.Manager", "Manager")
                        .WithMany("Customers")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("SampleApi.Models.Order", b =>
                {
                    b.HasOne("SampleApi.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SampleApi.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SampleApi.Models.Manager", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
