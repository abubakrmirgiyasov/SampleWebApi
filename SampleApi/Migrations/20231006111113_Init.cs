using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SampleApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "CreationDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("8c1ef088-537d-4f86-87be-53cfcfffe523"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 7, 0, 0, 0)), "Жуков Даниил Евгеньевич", null },
                    { new Guid("da60a851-3106-4cdd-8bdf-468d82b99c03"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 7, 0, 0, 0)), "Розанов Макар Михайлович", null },
                    { new Guid("e755978a-44bd-4106-bde1-1e88bca3d0cf"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, 7, 0, 0, 0)), "Соколова Алина Никитична", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreationDate", "ManagerId", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1aef54df-6132-4d17-ab4f-c60f83d39a6e"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8c1ef088-537d-4f86-87be-53cfcfffe523"), "Муравьев Кирилл Тихонович", null },
                    { new Guid("23a4127d-7df2-4561-8ba8-5b4a08ca0229"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2050), new TimeSpan(0, 7, 0, 0, 0)), new Guid("da60a851-3106-4cdd-8bdf-468d82b99c03"), "Рыжов Даниил Кириллович", null },
                    { new Guid("7e150fb6-3aec-4df5-bf6f-e804c2b8b488"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2019), new TimeSpan(0, 7, 0, 0, 0)), new Guid("da60a851-3106-4cdd-8bdf-468d82b99c03"), "Семин Денис Григорьевич", null },
                    { new Guid("d6c6b95e-3e53-424f-92e1-6569029f4a9f"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2029), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e755978a-44bd-4106-bde1-1e88bca3d0cf"), "Попова Кира Кирилловна", null },
                    { new Guid("e6b9a17a-243f-44fe-b5fc-78bb5276c21a"), new DateTimeOffset(new DateTime(2023, 10, 6, 18, 11, 12, 845, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 7, 0, 0, 0)), new Guid("8c1ef088-537d-4f86-87be-53cfcfffe523"), "Воронова Ксения Дмитриевна", null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Amount", "CreationDate", "CustomerId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("249b5ebb-9196-4119-9b41-9c2f2a14b31d"), 1000m, new DateTimeOffset(new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("1aef54df-6132-4d17-ab4f-c60f83d39a6e"), null },
                    { new Guid("2e0eb0b7-c04f-4f2e-b60c-1c9e482fd061"), 999m, new DateTimeOffset(new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d6c6b95e-3e53-424f-92e1-6569029f4a9f"), null },
                    { new Guid("8edfe056-8943-4d70-9149-9577d4b28e4d"), 790m, new DateTimeOffset(new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("23a4127d-7df2-4561-8ba8-5b4a08ca0229"), null },
                    { new Guid("afd2c5f1-4085-404d-badc-f5341881cf70"), 1203m, new DateTimeOffset(new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e6b9a17a-243f-44fe-b5fc-78bb5276c21a"), null },
                    { new Guid("b85abd28-af4a-4bb2-a486-7ac6ff66436e"), 578m, new DateTimeOffset(new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("e6b9a17a-243f-44fe-b5fc-78bb5276c21a"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ManagerId",
                table: "Customers",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
