﻿// <auto-generated />
using System;
using MYWEBAPP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MYWEBAPP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MYWEBAPP.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2147),
                            Description = "Game livestreams và esports",
                            Name = "Gaming"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2159),
                            Description = "Nhạc live và performances",
                            Name = "Music"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2160),
                            Description = "Nấu ăn và ẩm thực",
                            Name = "Cooking"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2161),
                            Description = "Just chatting và tán gẫu",
                            Name = "Chat"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2198),
                            Description = "Thể thao và fitness",
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2199),
                            Description = "Giáo dục và học tập",
                            Name = "Education"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2200),
                            Description = "Du lịch và khám phá",
                            Name = "Travel"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2201),
                            Description = "Nghệ thuật và sáng tạo",
                            Name = "Art"
                        });
                });

            modelBuilder.Entity("MYWEBAPP.Models.LiveStream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("StreamUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("StreamerId")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TotalViews")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewerCount")
                        .HasColumnType("int");

                    b.Property<int>("Visibility")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StreamerId");

                    b.HasIndex("UserId");

                    b.ToTable("LiveStreams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2324),
                            Description = "Stream VALORANT ranked với gameplay chất lượng cao",
                            Duration = 0,
                            IsFeatured = true,
                            IsLive = true,
                            StartedAt = new DateTime(2025, 5, 31, 13, 13, 24, 802, DateTimeKind.Local).AddTicks(2327),
                            StreamerId = 1,
                            ThumbnailUrl = "/images/streams/valorant-stream.jpg",
                            Title = "VALORANT Ranked - Hành trình lên Radiant",
                            TotalViews = 15600,
                            ViewerCount = 1250,
                            Visibility = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2333),
                            Description = "Leo rank Challenger với gameplay chuyên nghiệp",
                            Duration = 0,
                            IsFeatured = false,
                            IsLive = true,
                            StartedAt = new DateTime(2025, 5, 31, 14, 13, 24, 802, DateTimeKind.Local).AddTicks(2334),
                            StreamerId = 1,
                            ThumbnailUrl = "/images/streams/lol-stream.jpg",
                            Title = "League of Legends - Solo Queue Challenger",
                            TotalViews = 12400,
                            ViewerCount = 890,
                            Visibility = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2335),
                            Description = "Đêm nhạc acoustic với những ca khúc được yêu thích",
                            Duration = 0,
                            IsFeatured = true,
                            IsLive = true,
                            StartedAt = new DateTime(2025, 5, 31, 14, 28, 24, 802, DateTimeKind.Local).AddTicks(2336),
                            StreamerId = 2,
                            ThumbnailUrl = "/images/streams/acoustic-night.jpg",
                            Title = "Acoustic Night - Những bài hát hay nhất",
                            TotalViews = 8900,
                            ViewerCount = 650,
                            Visibility = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2337),
                            Description = "Hướng dẫn nấu phở bò truyền thống từ A-Z",
                            Duration = 0,
                            IsFeatured = false,
                            IsLive = true,
                            StartedAt = new DateTime(2025, 5, 31, 14, 43, 24, 802, DateTimeKind.Local).AddTicks(2339),
                            StreamerId = 3,
                            ThumbnailUrl = "/images/streams/pho-cooking.jpg",
                            Title = "Học nấu Phở Bò chuẩn vị Hà Nội",
                            TotalViews = 6700,
                            ViewerCount = 420,
                            Visibility = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2339),
                            Description = "Cùng tán gẫu về cuộc sống, công việc và những câu chuyện thú vị",
                            Duration = 0,
                            IsFeatured = false,
                            IsLive = true,
                            StartedAt = new DateTime(2025, 5, 31, 14, 53, 24, 802, DateTimeKind.Local).AddTicks(2341),
                            StreamerId = 4,
                            ThumbnailUrl = "/images/streams/weekend-chat.jpg",
                            Title = "Tán gẫu cuối tuần - Chia sẻ cuộc sống",
                            TotalViews = 4200,
                            ViewerCount = 280,
                            Visibility = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2341),
                            Description = "Bài tập yoga nhẹ nhàng để bắt đầu ngày mới",
                            Duration = 0,
                            IsFeatured = true,
                            IsLive = true,
                            StartedAt = new DateTime(2025, 5, 31, 14, 58, 24, 802, DateTimeKind.Local).AddTicks(2343),
                            StreamerId = 5,
                            ThumbnailUrl = "/images/streams/morning-yoga.jpg",
                            Title = "Yoga buổi sáng - Thư giãn cơ thể",
                            TotalViews = 5800,
                            ViewerCount = 320,
                            Visibility = 0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2343),
                            Description = "Giải đấu FIFA 24 với prize pool hấp dẫn",
                            Duration = 180,
                            EndedAt = new DateTime(2025, 5, 30, 18, 13, 24, 802, DateTimeKind.Local).AddTicks(2346),
                            IsFeatured = false,
                            IsLive = false,
                            StartedAt = new DateTime(2025, 5, 30, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2345),
                            StreamerId = 1,
                            ThumbnailUrl = "/images/streams/fifa-tournament.jpg",
                            Title = "FIFA 24 Tournament",
                            TotalViews = 25600,
                            ViewerCount = 0,
                            Visibility = 0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2347),
                            Description = "Cover những bài hit 2024 bằng piano",
                            Duration = 120,
                            EndedAt = new DateTime(2025, 5, 29, 17, 13, 24, 802, DateTimeKind.Local).AddTicks(2349),
                            IsFeatured = false,
                            IsLive = false,
                            StartedAt = new DateTime(2025, 5, 29, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2348),
                            StreamerId = 2,
                            ThumbnailUrl = "/images/streams/piano-cover.jpg",
                            Title = "Piano Cover Hits 2024",
                            TotalViews = 18900,
                            ViewerCount = 0,
                            Visibility = 0
                        });
                });

            modelBuilder.Entity("MYWEBAPP.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal?>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SoldCount")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MYWEBAPP.Models.Streamer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Bio")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FollowerCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Streamers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvatarUrl = "/images/avatars/gamemaster.jpg",
                            Bio = "Professional gamer và streamer hàng đầu Việt Nam",
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2302),
                            FollowerCount = 15000,
                            IsActive = true,
                            IsVerified = true,
                            Name = "GameMaster_VN"
                        },
                        new
                        {
                            Id = 2,
                            AvatarUrl = "/images/avatars/musicstudio.jpg",
                            Bio = "Studio âm nhạc live hàng ngày",
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2306),
                            FollowerCount = 8500,
                            IsActive = true,
                            IsVerified = true,
                            Name = "MusicLive_Studio"
                        },
                        new
                        {
                            Id = 3,
                            AvatarUrl = "/images/avatars/chefalex.jpg",
                            Bio = "Đầu bếp chuyên nghiệp chia sẻ món ngon",
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2308),
                            FollowerCount = 12000,
                            IsActive = true,
                            IsVerified = true,
                            Name = "ChefAlex_Kitchen"
                        },
                        new
                        {
                            Id = 4,
                            AvatarUrl = "/images/avatars/talkshow.jpg",
                            Bio = "Talkshow hàng ngày về cuộc sống",
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2309),
                            FollowerCount = 6500,
                            IsActive = true,
                            IsVerified = false,
                            Name = "TalkShow_Daily"
                        },
                        new
                        {
                            Id = 5,
                            AvatarUrl = "/images/avatars/fitness.jpg",
                            Bio = "HLV thể hình và yoga",
                            CreatedAt = new DateTime(2025, 5, 31, 15, 13, 24, 802, DateTimeKind.Local).AddTicks(2310),
                            FollowerCount = 9200,
                            IsActive = true,
                            IsVerified = false,
                            Name = "Fitness_Coach"
                        });
                });

            modelBuilder.Entity("MYWEBAPP.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Bio")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MYWEBAPP.Models.LiveStream", b =>
                {
                    b.HasOne("MYWEBAPP.Models.Category", "Category")
                        .WithMany("LiveStreams")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MYWEBAPP.Models.Streamer", "Streamer")
                        .WithMany("LiveStreams")
                        .HasForeignKey("StreamerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MYWEBAPP.Models.User", "User")
                        .WithMany("LiveStreams")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("Streamer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MYWEBAPP.Models.Product", b =>
                {
                    b.HasOne("MYWEBAPP.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MYWEBAPP.Models.Category", b =>
                {
                    b.Navigation("LiveStreams");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("MYWEBAPP.Models.Streamer", b =>
                {
                    b.Navigation("LiveStreams");
                });

            modelBuilder.Entity("MYWEBAPP.Models.User", b =>
                {
                    b.Navigation("LiveStreams");
                });
#pragma warning restore 612, 618
        }
    }
}
