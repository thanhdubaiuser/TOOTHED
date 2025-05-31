using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYWEBAPP.Migrations
{
    /// <inheritdoc />
    public partial class AddUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LiveStreams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1886), new DateTime(2025, 5, 31, 12, 52, 47, 157, DateTimeKind.Local).AddTicks(1892), null });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1898), new DateTime(2025, 5, 31, 13, 52, 47, 157, DateTimeKind.Local).AddTicks(1899), null });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1900), new DateTime(2025, 5, 31, 14, 7, 47, 157, DateTimeKind.Local).AddTicks(1901), null });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1902), new DateTime(2025, 5, 31, 14, 22, 47, 157, DateTimeKind.Local).AddTicks(1903), null });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1904), new DateTime(2025, 5, 31, 14, 32, 47, 157, DateTimeKind.Local).AddTicks(1905), null });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1906), new DateTime(2025, 5, 31, 14, 37, 47, 157, DateTimeKind.Local).AddTicks(1907), null });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1908), new DateTime(2025, 5, 30, 17, 52, 47, 157, DateTimeKind.Local).AddTicks(1911), new DateTime(2025, 5, 30, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1909), null });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt", "UserId" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1912), new DateTime(2025, 5, 29, 16, 52, 47, 157, DateTimeKind.Local).AddTicks(1914), new DateTime(2025, 5, 29, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1913), null });

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.CreateIndex(
                name: "IX_LiveStreams_UserId",
                table: "LiveStreams",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LiveStreams_Users_UserId",
                table: "LiveStreams",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiveStreams_Users_UserId",
                table: "LiveStreams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_LiveStreams_UserId",
                table: "LiveStreams");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LiveStreams");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3370), new DateTime(2025, 5, 31, 12, 33, 1, 451, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3380), new DateTime(2025, 5, 31, 13, 33, 1, 451, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3383), new DateTime(2025, 5, 31, 13, 48, 1, 451, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3385), new DateTime(2025, 5, 31, 14, 3, 1, 451, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3386), new DateTime(2025, 5, 31, 14, 13, 1, 451, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3388), new DateTime(2025, 5, 31, 14, 18, 1, 451, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3390), new DateTime(2025, 5, 30, 17, 33, 1, 451, DateTimeKind.Local).AddTicks(3393), new DateTime(2025, 5, 30, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3394), new DateTime(2025, 5, 29, 16, 33, 1, 451, DateTimeKind.Local).AddTicks(3396), new DateTime(2025, 5, 29, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3356));
        }
    }
}
