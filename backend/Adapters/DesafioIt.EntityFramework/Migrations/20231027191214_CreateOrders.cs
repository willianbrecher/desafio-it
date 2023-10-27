using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioIt.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class CreateOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "OrderNumbers",
                schema: "application");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                schema: "application",
                table: "Dishes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "OrderEntity",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "NEXT VALUE FOR OrderNumbers"),
                    ClientName = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Observation = table.Column<string>(type: "text", nullable: false),
                    TotalPrice = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemEntity",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    DishId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    OrderEntityId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemEntity_OrderEntity_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalSchema: "application",
                        principalTable: "OrderEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderEntity_CreatedAt",
                schema: "application",
                table: "OrderEntity",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_OrderEntity_IsDeleted",
                schema: "application",
                table: "OrderEntity",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_OrderEntity_UpdatedAt",
                schema: "application",
                table: "OrderEntity",
                column: "UpdatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemEntity_CreatedAt",
                schema: "application",
                table: "OrderItemEntity",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemEntity_IsDeleted",
                schema: "application",
                table: "OrderItemEntity",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemEntity_OrderEntityId",
                schema: "application",
                table: "OrderItemEntity",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemEntity_UpdatedAt",
                schema: "application",
                table: "OrderItemEntity",
                column: "UpdatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItemEntity",
                schema: "application");

            migrationBuilder.DropTable(
                name: "OrderEntity",
                schema: "application");

            migrationBuilder.DropColumn(
                name: "Photo",
                schema: "application",
                table: "Dishes");

            migrationBuilder.DropSequence(
                name: "OrderNumbers",
                schema: "application");
        }
    }
}
