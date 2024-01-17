﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TpApi.Repository.Database.Contexts;

#nullable disable

namespace TpApi.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TpApi.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Game", (string)null);
                });

            modelBuilder.Entity("TpApi.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c895118a-299f-4a43-8912-f6fa5592f57e"),
                            CreatedAt = new DateTime(2022, 4, 29, 10, 16, 0, 665, DateTimeKind.Local).AddTicks(7428),
                            Email = "Peter_Rempel@hotmail.com",
                            FirstName = "Peter",
                            LastName = "Rempel",
                            UpdatedAt = new DateTime(2023, 9, 12, 23, 8, 21, 972, DateTimeKind.Local).AddTicks(1006)
                        },
                        new
                        {
                            Id = new Guid("930b7252-da5a-45f7-9870-7b28090baaa6"),
                            CreatedAt = new DateTime(2022, 3, 24, 18, 15, 39, 368, DateTimeKind.Local).AddTicks(1423),
                            Email = "Doug24@gmail.com",
                            FirstName = "Doug",
                            LastName = "Greenfelder",
                            UpdatedAt = new DateTime(2023, 8, 3, 2, 35, 3, 927, DateTimeKind.Local).AddTicks(2054)
                        },
                        new
                        {
                            Id = new Guid("9868583d-03b2-4e1d-b94f-4666715ffabe"),
                            CreatedAt = new DateTime(2023, 10, 5, 22, 2, 34, 805, DateTimeKind.Local).AddTicks(2923),
                            Email = "Michael_Ankunding@gmail.com",
                            FirstName = "Michael",
                            LastName = "Ankunding",
                            UpdatedAt = new DateTime(2023, 4, 7, 4, 56, 9, 352, DateTimeKind.Local).AddTicks(3936)
                        },
                        new
                        {
                            Id = new Guid("c3f81423-2ba4-4970-9190-3611252a36f4"),
                            CreatedAt = new DateTime(2022, 12, 19, 16, 30, 33, 200, DateTimeKind.Local).AddTicks(2795),
                            Email = "Ana_Dicki@hotmail.com",
                            FirstName = "Ana",
                            LastName = "Dicki",
                            UpdatedAt = new DateTime(2023, 2, 18, 1, 12, 59, 355, DateTimeKind.Local).AddTicks(9218)
                        },
                        new
                        {
                            Id = new Guid("20861e7e-a2c4-4455-90a3-58661a474b38"),
                            CreatedAt = new DateTime(2022, 11, 22, 5, 1, 27, 65, DateTimeKind.Local).AddTicks(9257),
                            Email = "Francis92@gmail.com",
                            FirstName = "Francis",
                            LastName = "Wilderman",
                            UpdatedAt = new DateTime(2023, 9, 10, 23, 31, 50, 418, DateTimeKind.Local).AddTicks(3597)
                        },
                        new
                        {
                            Id = new Guid("a31a17e4-67e9-48e1-a91e-5f17c285cf23"),
                            CreatedAt = new DateTime(2023, 11, 18, 18, 28, 9, 484, DateTimeKind.Local).AddTicks(2765),
                            Email = "Ronald_McKenzie95@gmail.com",
                            FirstName = "Ronald",
                            LastName = "McKenzie",
                            UpdatedAt = new DateTime(2023, 4, 7, 20, 36, 39, 643, DateTimeKind.Local).AddTicks(9070)
                        },
                        new
                        {
                            Id = new Guid("62e4e891-0875-40ae-a347-79d46770a526"),
                            CreatedAt = new DateTime(2022, 9, 5, 0, 28, 55, 126, DateTimeKind.Local).AddTicks(834),
                            Email = "Richard_Schmeler84@yahoo.com",
                            FirstName = "Richard",
                            LastName = "Schmeler",
                            UpdatedAt = new DateTime(2023, 11, 24, 11, 53, 22, 802, DateTimeKind.Local).AddTicks(3845)
                        },
                        new
                        {
                            Id = new Guid("942c52b3-4e6c-46df-b9b3-7c70f80d4a88"),
                            CreatedAt = new DateTime(2022, 9, 7, 16, 48, 5, 595, DateTimeKind.Local).AddTicks(2075),
                            Email = "Michael.Schaden95@hotmail.com",
                            FirstName = "Michael",
                            LastName = "Schaden",
                            UpdatedAt = new DateTime(2023, 2, 21, 15, 16, 34, 102, DateTimeKind.Local).AddTicks(5222)
                        },
                        new
                        {
                            Id = new Guid("43111f45-478f-4feb-a899-e0596642c244"),
                            CreatedAt = new DateTime(2023, 12, 25, 17, 51, 5, 598, DateTimeKind.Local).AddTicks(7342),
                            Email = "Lillian_Bahringer78@gmail.com",
                            FirstName = "Lillian",
                            LastName = "Bahringer",
                            UpdatedAt = new DateTime(2023, 5, 8, 16, 29, 50, 802, DateTimeKind.Local).AddTicks(5268)
                        },
                        new
                        {
                            Id = new Guid("2e7e4aef-6390-4a51-b41b-75f945a36d45"),
                            CreatedAt = new DateTime(2022, 9, 27, 12, 34, 47, 495, DateTimeKind.Local).AddTicks(592),
                            Email = "Christie.Tremblay@gmail.com",
                            FirstName = "Christie",
                            LastName = "Tremblay",
                            UpdatedAt = new DateTime(2023, 4, 25, 17, 32, 36, 368, DateTimeKind.Local).AddTicks(9952)
                        },
                        new
                        {
                            Id = new Guid("ba638687-5399-48b0-a75d-a77524f51228"),
                            CreatedAt = new DateTime(2022, 3, 31, 20, 5, 48, 30, DateTimeKind.Local).AddTicks(7232),
                            Email = "Cynthia_Price73@yahoo.com",
                            FirstName = "Cynthia",
                            LastName = "Price",
                            UpdatedAt = new DateTime(2023, 3, 21, 17, 39, 48, 497, DateTimeKind.Local).AddTicks(4256)
                        },
                        new
                        {
                            Id = new Guid("cbf772b5-837b-4785-b64b-4ff587676496"),
                            CreatedAt = new DateTime(2022, 8, 1, 17, 10, 42, 405, DateTimeKind.Local).AddTicks(1850),
                            Email = "Stella.Labadie33@gmail.com",
                            FirstName = "Stella",
                            LastName = "Labadie",
                            UpdatedAt = new DateTime(2023, 8, 26, 3, 37, 29, 254, DateTimeKind.Local).AddTicks(9202)
                        },
                        new
                        {
                            Id = new Guid("b01dbefd-b0b1-4779-87fc-03c372426bbc"),
                            CreatedAt = new DateTime(2023, 1, 3, 11, 33, 6, 348, DateTimeKind.Local).AddTicks(9405),
                            Email = "Jeanne.Kreiger12@yahoo.com",
                            FirstName = "Jeanne",
                            LastName = "Kreiger",
                            UpdatedAt = new DateTime(2023, 11, 12, 5, 54, 56, 883, DateTimeKind.Local).AddTicks(1163)
                        },
                        new
                        {
                            Id = new Guid("1176918e-74f2-4eca-8838-a3a2e026a571"),
                            CreatedAt = new DateTime(2023, 2, 19, 5, 53, 9, 206, DateTimeKind.Local).AddTicks(1208),
                            Email = "Verna_Lind22@gmail.com",
                            FirstName = "Verna",
                            LastName = "Lind",
                            UpdatedAt = new DateTime(2024, 1, 10, 8, 18, 13, 839, DateTimeKind.Local).AddTicks(1312)
                        },
                        new
                        {
                            Id = new Guid("bf592051-bbdc-4874-9ac5-b948acf488e1"),
                            CreatedAt = new DateTime(2023, 5, 12, 18, 19, 2, 936, DateTimeKind.Local).AddTicks(5218),
                            Email = "Thelma36@yahoo.com",
                            FirstName = "Thelma",
                            LastName = "Marquardt",
                            UpdatedAt = new DateTime(2023, 7, 21, 12, 20, 0, 900, DateTimeKind.Local).AddTicks(6556)
                        },
                        new
                        {
                            Id = new Guid("8061edab-098d-4a70-bde8-01e2fdc3f428"),
                            CreatedAt = new DateTime(2023, 12, 22, 14, 2, 39, 426, DateTimeKind.Local).AddTicks(4136),
                            Email = "Aaron.Reinger99@gmail.com",
                            FirstName = "Aaron",
                            LastName = "Reinger",
                            UpdatedAt = new DateTime(2023, 8, 1, 13, 57, 24, 325, DateTimeKind.Local).AddTicks(8795)
                        },
                        new
                        {
                            Id = new Guid("f5005123-d252-4f82-8f9f-487ca434ad40"),
                            CreatedAt = new DateTime(2023, 10, 16, 21, 5, 5, 40, DateTimeKind.Local).AddTicks(395),
                            Email = "David.Kuphal59@hotmail.com",
                            FirstName = "David",
                            LastName = "Kuphal",
                            UpdatedAt = new DateTime(2023, 8, 21, 2, 5, 30, 918, DateTimeKind.Local).AddTicks(4660)
                        },
                        new
                        {
                            Id = new Guid("673e7020-a126-4253-ad18-baf30852dd75"),
                            CreatedAt = new DateTime(2023, 3, 3, 18, 40, 38, 150, DateTimeKind.Local).AddTicks(5627),
                            Email = "Geoffrey.Stiedemann@hotmail.com",
                            FirstName = "Geoffrey",
                            LastName = "Stiedemann",
                            UpdatedAt = new DateTime(2023, 4, 8, 12, 54, 27, 839, DateTimeKind.Local).AddTicks(9005)
                        },
                        new
                        {
                            Id = new Guid("0ef41b89-80ce-491d-b780-9a9c99883bdf"),
                            CreatedAt = new DateTime(2023, 6, 19, 14, 25, 40, 986, DateTimeKind.Local).AddTicks(9080),
                            Email = "Alison.Stehr19@yahoo.com",
                            FirstName = "Alison",
                            LastName = "Stehr",
                            UpdatedAt = new DateTime(2023, 12, 30, 12, 54, 53, 975, DateTimeKind.Local).AddTicks(9228)
                        },
                        new
                        {
                            Id = new Guid("b9eed57f-bcce-4e01-bbaa-e72de5159753"),
                            CreatedAt = new DateTime(2022, 3, 23, 10, 51, 59, 661, DateTimeKind.Local).AddTicks(4600),
                            Email = "Annie_Borer@hotmail.com",
                            FirstName = "Annie",
                            LastName = "Borer",
                            UpdatedAt = new DateTime(2023, 9, 2, 19, 28, 45, 223, DateTimeKind.Local).AddTicks(1514)
                        },
                        new
                        {
                            Id = new Guid("f647d247-fbb4-4c8e-916f-d86ba8395de4"),
                            CreatedAt = new DateTime(2022, 7, 19, 6, 50, 9, 466, DateTimeKind.Local).AddTicks(6778),
                            Email = "Bradley_Hahn90@yahoo.com",
                            FirstName = "Bradley",
                            LastName = "Hahn",
                            UpdatedAt = new DateTime(2023, 9, 6, 1, 34, 2, 92, DateTimeKind.Local).AddTicks(6296)
                        },
                        new
                        {
                            Id = new Guid("beeb1322-825a-4b60-8cbf-307b3dfd2c28"),
                            CreatedAt = new DateTime(2022, 11, 29, 16, 11, 38, 144, DateTimeKind.Local).AddTicks(1265),
                            Email = "Clinton76@gmail.com",
                            FirstName = "Clinton",
                            LastName = "O'Connell",
                            UpdatedAt = new DateTime(2023, 9, 18, 19, 42, 9, 541, DateTimeKind.Local).AddTicks(8976)
                        },
                        new
                        {
                            Id = new Guid("b17d24d7-a0f4-42e3-8ee6-889936b8fc3f"),
                            CreatedAt = new DateTime(2023, 3, 17, 7, 15, 48, 339, DateTimeKind.Local).AddTicks(1681),
                            Email = "Norman.Corwin@yahoo.com",
                            FirstName = "Norman",
                            LastName = "Corwin",
                            UpdatedAt = new DateTime(2023, 2, 14, 19, 41, 27, 669, DateTimeKind.Local).AddTicks(9825)
                        },
                        new
                        {
                            Id = new Guid("e944b58e-09a2-4722-b297-e5928063db24"),
                            CreatedAt = new DateTime(2023, 8, 26, 7, 36, 44, 971, DateTimeKind.Local).AddTicks(7427),
                            Email = "Anna_Pacocha95@hotmail.com",
                            FirstName = "Anna",
                            LastName = "Pacocha",
                            UpdatedAt = new DateTime(2023, 7, 2, 23, 21, 55, 210, DateTimeKind.Local).AddTicks(606)
                        },
                        new
                        {
                            Id = new Guid("1e75dc8e-9fa9-4d71-b32e-70305c003944"),
                            CreatedAt = new DateTime(2023, 11, 9, 22, 1, 5, 584, DateTimeKind.Local).AddTicks(2003),
                            Email = "Genevieve47@hotmail.com",
                            FirstName = "Genevieve",
                            LastName = "Leffler",
                            UpdatedAt = new DateTime(2023, 9, 19, 13, 47, 1, 845, DateTimeKind.Local).AddTicks(5374)
                        },
                        new
                        {
                            Id = new Guid("4ac854f1-a113-4b8d-8d07-f11ac3ae29af"),
                            CreatedAt = new DateTime(2022, 7, 15, 0, 21, 42, 188, DateTimeKind.Local).AddTicks(2434),
                            Email = "Miranda.McLaughlin48@gmail.com",
                            FirstName = "Miranda",
                            LastName = "McLaughlin",
                            UpdatedAt = new DateTime(2023, 5, 19, 21, 33, 20, 223, DateTimeKind.Local).AddTicks(6046)
                        },
                        new
                        {
                            Id = new Guid("afa7ff8a-f8bc-427e-8a10-7639f0f67901"),
                            CreatedAt = new DateTime(2022, 8, 24, 6, 18, 8, 871, DateTimeKind.Local).AddTicks(6314),
                            Email = "Diana.Padberg23@hotmail.com",
                            FirstName = "Diana",
                            LastName = "Padberg",
                            UpdatedAt = new DateTime(2023, 12, 21, 14, 20, 24, 114, DateTimeKind.Local).AddTicks(9544)
                        },
                        new
                        {
                            Id = new Guid("21565dfa-15f8-44b7-85de-215285f85a04"),
                            CreatedAt = new DateTime(2022, 8, 28, 8, 22, 32, 912, DateTimeKind.Local).AddTicks(7446),
                            Email = "Jesse.Howell19@yahoo.com",
                            FirstName = "Jesse",
                            LastName = "Howell",
                            UpdatedAt = new DateTime(2023, 8, 22, 15, 44, 49, 587, DateTimeKind.Local).AddTicks(5116)
                        },
                        new
                        {
                            Id = new Guid("56be272f-17c7-4ec4-87bb-8768e11b07d7"),
                            CreatedAt = new DateTime(2022, 8, 12, 21, 0, 42, 738, DateTimeKind.Local).AddTicks(5593),
                            Email = "Evan.Treutel@yahoo.com",
                            FirstName = "Evan",
                            LastName = "Treutel",
                            UpdatedAt = new DateTime(2023, 3, 30, 22, 2, 54, 515, DateTimeKind.Local).AddTicks(840)
                        },
                        new
                        {
                            Id = new Guid("90f21eb1-5d93-4632-a07c-a086ae395229"),
                            CreatedAt = new DateTime(2022, 9, 12, 9, 3, 3, 699, DateTimeKind.Local).AddTicks(317),
                            Email = "Viola_Baumbach8@hotmail.com",
                            FirstName = "Viola",
                            LastName = "Baumbach",
                            UpdatedAt = new DateTime(2023, 4, 6, 6, 49, 21, 321, DateTimeKind.Local).AddTicks(220)
                        });
                });

            modelBuilder.Entity("TpApi.Entities.Game", b =>
                {
                    b.HasOne("TpApi.Entities.User", "User")
                        .WithMany("Games")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TpApi.Entities.User", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
