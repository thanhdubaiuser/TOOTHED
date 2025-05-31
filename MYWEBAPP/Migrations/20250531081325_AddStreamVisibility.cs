using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYWEBAPP.Migrations
{
    /// <inheritdoc />
    public partial class AddStreamVisibility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Visibility",
                table: "LiveStreams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2324), new DateTime(2025, 5, 31, 13, 13, 24, 802, DateTimeKind.Local).AddTicks(2327), 0 });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2333), new DateTime(2025, 5, 31, 14, 13, 24, 802, DateTimeKind.Local).AddTicks(2334), 0 });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2335), new DateTime(2025, 5, 31, 14, 28, 24, 802, DateTimeKind.Local).AddTicks(2336), 0 });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2337), new DateTime(2025, 5, 31, 14, 43, 24, 802, DateTimeKind.Local).AddTicks(2339), 0 });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2339), new DateTime(2025, 5, 31, 14, 53, 24, 802, DateTimeKind.Local).AddTicks(2341), 0 });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2341), new DateTime(2025, 5, 31, 14, 58, 24, 802, DateTimeKind.Local).AddTicks(2343), 0 });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2343), new DateTime(2025, 5, 30, 18, 13, 24, 802, DateTimeKind.Local).AddTicks(2346), new DateTime(2025, 5, 30, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2345), 0 });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt", "Visibility" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2347), new DateTime(2025, 5, 29, 17, 13, 24, 802, DateTimeKind.Local).AddTicks(2349), new DateTime(2025, 5, 29, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2348), 0 });

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Streamers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2310));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "LiveStreams");

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
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1886), new DateTime(2025, 5, 31, 12, 52, 47, 157, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1898), new DateTime(2025, 5, 31, 13, 52, 47, 157, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1900), new DateTime(2025, 5, 31, 14, 7, 47, 157, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1902), new DateTime(2025, 5, 31, 14, 22, 47, 157, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1904), new DateTime(2025, 5, 31, 14, 32, 47, 157, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1906), new DateTime(2025, 5, 31, 14, 37, 47, 157, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1908), new DateTime(2025, 5, 30, 17, 52, 47, 157, DateTimeKind.Local).AddTicks(1911), new DateTime(2025, 5, 30, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "LiveStreams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndedAt", "StartedAt" },
                values: new object[] { new DateTime(2025, 5, 31, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1912), new DateTime(2025, 5, 29, 16, 52, 47, 157, DateTimeKind.Local).AddTicks(1914), new DateTime(2025, 5, 29, 14, 52, 47, 157, DateTimeKind.Local).AddTicks(1913) });

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
        }
    }
}
