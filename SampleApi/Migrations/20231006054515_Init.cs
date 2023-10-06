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
                    { new Guid("66d8e6c0-7892-4e83-8079-49115f2d2e1f"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9904), new TimeSpan(0, 7, 0, 0, 0)), "Розанов Макар Михайлович", null },
                    { new Guid("72693689-97f2-4204-9466-1ade22aa3da5"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 7, 0, 0, 0)), "Соколова Алина Никитична", null },
                    { new Guid("d1dad27f-e641-4df6-989d-f3e8c1690d6f"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9807), new TimeSpan(0, 7, 0, 0, 0)), "Жуков Даниил Евгеньевич", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreationDate", "ManagerId", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0247df4d-2900-4b1d-adfa-f3c6116ac8d5"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9912), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1dad27f-e641-4df6-989d-f3e8c1690d6f"), "Воронова Ксения Дмитриевна", null },
                    { new Guid("16e43019-2224-402e-be80-7429a4790670"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9922), new TimeSpan(0, 7, 0, 0, 0)), new Guid("72693689-97f2-4204-9466-1ade22aa3da5"), "Попова Кира Кирилловна", null },
                    { new Guid("2e2be775-40cf-4fc2-bbbc-fb2443955837"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9917), new TimeSpan(0, 7, 0, 0, 0)), new Guid("66d8e6c0-7892-4e83-8079-49115f2d2e1f"), "Семин Денис Григорьевич", null },
                    { new Guid("9006c780-7c41-4c75-bfda-130e186dabe3"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 7, 0, 0, 0)), new Guid("66d8e6c0-7892-4e83-8079-49115f2d2e1f"), "Рыжов Даниил Кириллович", null },
                    { new Guid("f38b8b2c-f06e-4c1b-9b22-d527427ea04c"), new DateTimeOffset(new DateTime(2023, 10, 6, 12, 45, 15, 655, DateTimeKind.Unspecified).AddTicks(9919), new TimeSpan(0, 7, 0, 0, 0)), new Guid("d1dad27f-e641-4df6-989d-f3e8c1690d6f"), "Муравьев Кирилл Тихонович", null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Amount", "CreationDate", "CustomerId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("2397ba58-2f56-4a57-981c-b4060fdedeee"), 790m, new DateTimeOffset(new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("9006c780-7c41-4c75-bfda-130e186dabe3"), null },
                    { new Guid("458739e9-ff2b-4a3f-85ad-7787f8b4290d"), 999m, new DateTimeOffset(new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("16e43019-2224-402e-be80-7429a4790670"), null },
                    { new Guid("55677acf-ae46-49b9-aea4-11c2f1a669dc"), 1000m, new DateTimeOffset(new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("f38b8b2c-f06e-4c1b-9b22-d527427ea04c"), null },
                    { new Guid("b902517e-8916-4216-b080-527d688d7a8c"), 1203m, new DateTimeOffset(new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("2e2be775-40cf-4fc2-bbbc-fb2443955837"), null },
                    { new Guid("f6da51bb-72dd-472a-b518-cf8c9cd04aca"), 578m, new DateTimeOffset(new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new Guid("0247df4d-2900-4b1d-adfa-f3c6116ac8d5"), null }
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
