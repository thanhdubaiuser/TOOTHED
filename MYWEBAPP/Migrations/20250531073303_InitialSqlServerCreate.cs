using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MYWEBAPP.Migrations
{
    /// <inheritdoc />
    public partial class InitialSqlServerCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Streamers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FollowerCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streamers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    SoldCount = table.Column<int>(type: "int", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiveStreams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StreamUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ViewerCount = table.Column<int>(type: "int", nullable: false),
                    TotalViews = table.Column<int>(type: "int", nullable: false),
                    IsLive = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    StreamerId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveStreams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LiveStreams_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LiveStreams_Streamers_StreamerId",
                        column: x => x.StreamerId,
                        principalTable: "Streamers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3257), "Game livestreams và esports", "Gaming" },
                    { 2, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3268), "Nhạc live và performances", "Music" },
                    { 3, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3269), "Nấu ăn và ẩm thực", "Cooking" },
                    { 4, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3269), "Just chatting và tán gẫu", "Chat" },
                    { 5, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3270), "Thể thao và fitness", "Sports" },
                    { 6, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3271), "Giáo dục và học tập", "Education" },
                    { 7, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3272), "Du lịch và khám phá", "Travel" },
                    { 8, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3273), "Nghệ thuật và sáng tạo", "Art" }
                });

            migrationBuilder.InsertData(
                table: "Streamers",
                columns: new[] { "Id", "AvatarUrl", "Bio", "CreatedAt", "FollowerCount", "IsActive", "IsVerified", "Name" },
                values: new object[,]
                {
                    { 1, "/images/avatars/gamemaster.jpg", "Professional gamer và streamer hàng đầu Việt Nam", new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3348), 15000, true, true, "GameMaster_VN" },
                    { 2, "/images/avatars/musicstudio.jpg", "Studio âm nhạc live hàng ngày", new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3351), 8500, true, true, "MusicLive_Studio" },
                    { 3, "/images/avatars/chefalex.jpg", "Đầu bếp chuyên nghiệp chia sẻ món ngon", new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3353), 12000, true, true, "ChefAlex_Kitchen" },
                    { 4, "/images/avatars/talkshow.jpg", "Talkshow hàng ngày về cuộc sống", new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3354), 6500, true, false, "TalkShow_Daily" },
                    { 5, "/images/avatars/fitness.jpg", "HLV thể hình và yoga", new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3356), 9200, true, false, "Fitness_Coach" }
                });

            migrationBuilder.InsertData(
                table: "LiveStreams",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Duration", "EndedAt", "IsFeatured", "IsLive", "StartedAt", "StreamUrl", "StreamerId", "ThumbnailUrl", "Title", "TotalViews", "ViewerCount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3370), "Stream VALORANT ranked với gameplay chất lượng cao", 0, null, true, true, new DateTime(2025, 5, 31, 12, 33, 1, 451, DateTimeKind.Local).AddTicks(3374), null, 1, "/images/streams/valorant-stream.jpg", "VALORANT Ranked - Hành trình lên Radiant", 15600, 1250 },
                    { 2, 1, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3380), "Leo rank Challenger với gameplay chuyên nghiệp", 0, null, false, true, new DateTime(2025, 5, 31, 13, 33, 1, 451, DateTimeKind.Local).AddTicks(3382), null, 1, "/images/streams/lol-stream.jpg", "League of Legends - Solo Queue Challenger", 12400, 890 },
                    { 3, 2, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3383), "Đêm nhạc acoustic với những ca khúc được yêu thích", 0, null, true, true, new DateTime(2025, 5, 31, 13, 48, 1, 451, DateTimeKind.Local).AddTicks(3384), null, 2, "/images/streams/acoustic-night.jpg", "Acoustic Night - Những bài hát hay nhất", 8900, 650 },
                    { 4, 3, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3385), "Hướng dẫn nấu phở bò truyền thống từ A-Z", 0, null, false, true, new DateTime(2025, 5, 31, 14, 3, 1, 451, DateTimeKind.Local).AddTicks(3386), null, 3, "/images/streams/pho-cooking.jpg", "Học nấu Phở Bò chuẩn vị Hà Nội", 6700, 420 },
                    { 5, 4, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3386), "Cùng tán gẫu về cuộc sống, công việc và những câu chuyện thú vị", 0, null, false, true, new DateTime(2025, 5, 31, 14, 13, 1, 451, DateTimeKind.Local).AddTicks(3387), null, 4, "/images/streams/weekend-chat.jpg", "Tán gẫu cuối tuần - Chia sẻ cuộc sống", 4200, 280 },
                    { 6, 5, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3388), "Bài tập yoga nhẹ nhàng để bắt đầu ngày mới", 0, null, true, true, new DateTime(2025, 5, 31, 14, 18, 1, 451, DateTimeKind.Local).AddTicks(3389), null, 5, "/images/streams/morning-yoga.jpg", "Yoga buổi sáng - Thư giãn cơ thể", 5800, 320 },
                    { 7, 1, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3390), "Giải đấu FIFA 24 với prize pool hấp dẫn", 180, new DateTime(2025, 5, 30, 17, 33, 1, 451, DateTimeKind.Local).AddTicks(3393), false, false, new DateTime(2025, 5, 30, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3391), null, 1, "/images/streams/fifa-tournament.jpg", "FIFA 24 Tournament", 25600, 0 },
                    { 8, 2, new DateTime(2025, 5, 31, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3394), "Cover những bài hit 2024 bằng piano", 120, new DateTime(2025, 5, 29, 16, 33, 1, 451, DateTimeKind.Local).AddTicks(3396), false, false, new DateTime(2025, 5, 29, 14, 33, 1, 451, DateTimeKind.Local).AddTicks(3395), null, 2, "/images/streams/piano-cover.jpg", "Piano Cover Hits 2024", 18900, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LiveStreams_CategoryId",
                table: "LiveStreams",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LiveStreams_StreamerId",
                table: "LiveStreams",
                column: "StreamerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiveStreams");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Streamers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
