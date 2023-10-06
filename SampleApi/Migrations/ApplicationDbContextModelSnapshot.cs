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
                            Id = new Guid("0247df4d-2900-4b1d-adfa-f3c6116ac8d5"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9912), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("d1dad27f-e641-4df6-989d-f3e8c1690d6f"),
                            Name = "Воронова Ксения Дмитриевна"
                        },
                        new
                        {
                            Id = new Guid("2e2be775-40cf-4fc2-bbbc-fb2443955837"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9917), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("66d8e6c0-7892-4e83-8079-49115f2d2e1f"),
                            Name = "Семин Денис Григорьевич"
                        },
                        new
                        {
                            Id = new Guid("f38b8b2c-f06e-4c1b-9b22-d527427ea04c"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9919), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("d1dad27f-e641-4df6-989d-f3e8c1690d6f"),
                            Name = "Муравьев Кирилл Тихонович"
                        },
                        new
                        {
                            Id = new Guid("16e43019-2224-402e-be80-7429a4790670"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9922), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("72693689-97f2-4204-9466-1ade22aa3da5"),
                            Name = "Попова Кира Кирилловна"
                        },
                        new
                        {
                            Id = new Guid("9006c780-7c41-4c75-bfda-130e186dabe3"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 7, 0, 0, 0)),
                            ManagerId = new Guid("66d8e6c0-7892-4e83-8079-49115f2d2e1f"),
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
                            Id = new Guid("d1dad27f-e641-4df6-989d-f3e8c1690d6f"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Жуков Даниил Евгеньевич"
                        },
                        new
                        {
                            Id = new Guid("66d8e6c0-7892-4e83-8079-49115f2d2e1f"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 7, 0, 0, 0)),
                            Name = "Розанов Макар Михайлович"
                        },
                        new
                        {
                            Id = new Guid("72693689-97f2-4204-9466-1ade22aa3da5"),
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 7, 0, 0, 0)),
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
                            Id = new Guid("f6da51bb-72dd-472a-b518-cf8c9cd04aca"),
                            Amount = 578m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("0247df4d-2900-4b1d-adfa-f3c6116ac8d5")
                        },
                        new
                        {
                            Id = new Guid("b902517e-8916-4216-b080-527d688d7a8c"),
                            Amount = 1203m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("2e2be775-40cf-4fc2-bbbc-fb2443955837")
                        },
                        new
                        {
                            Id = new Guid("55677acf-ae46-49b9-aea4-11c2f1a669dc"),
                            Amount = 1000m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("f38b8b2c-f06e-4c1b-9b22-d527427ea04c")
                        },
                        new
                        {
                            Id = new Guid("458739e9-ff2b-4a3f-85ad-7787f8b4290d"),
                            Amount = 999m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("16e43019-2224-402e-be80-7429a4790670")
                        },
                        new
                        {
                            Id = new Guid("2397ba58-2f56-4a57-981c-b4060fdedeee"),
                            Amount = 790m,
                            CreationDate = new DateTimeOffset(new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)),
                            CustomerId = new Guid("9006c780-7c41-4c75-bfda-130e186dabe3")
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
