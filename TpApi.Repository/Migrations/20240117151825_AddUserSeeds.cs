using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TpApi.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0ef41b89-80ce-491d-b780-9a9c99883bdf"), new DateTime(2023, 6, 19, 14, 25, 40, 986, DateTimeKind.Local).AddTicks(9080), "Alison.Stehr19@yahoo.com", "Alison", "Stehr", new DateTime(2023, 12, 30, 12, 54, 53, 975, DateTimeKind.Local).AddTicks(9228) },
                    { new Guid("1176918e-74f2-4eca-8838-a3a2e026a571"), new DateTime(2023, 2, 19, 5, 53, 9, 206, DateTimeKind.Local).AddTicks(1208), "Verna_Lind22@gmail.com", "Verna", "Lind", new DateTime(2024, 1, 10, 8, 18, 13, 839, DateTimeKind.Local).AddTicks(1312) },
                    { new Guid("1e75dc8e-9fa9-4d71-b32e-70305c003944"), new DateTime(2023, 11, 9, 22, 1, 5, 584, DateTimeKind.Local).AddTicks(2003), "Genevieve47@hotmail.com", "Genevieve", "Leffler", new DateTime(2023, 9, 19, 13, 47, 1, 845, DateTimeKind.Local).AddTicks(5374) },
                    { new Guid("20861e7e-a2c4-4455-90a3-58661a474b38"), new DateTime(2022, 11, 22, 5, 1, 27, 65, DateTimeKind.Local).AddTicks(9257), "Francis92@gmail.com", "Francis", "Wilderman", new DateTime(2023, 9, 10, 23, 31, 50, 418, DateTimeKind.Local).AddTicks(3597) },
                    { new Guid("21565dfa-15f8-44b7-85de-215285f85a04"), new DateTime(2022, 8, 28, 8, 22, 32, 912, DateTimeKind.Local).AddTicks(7446), "Jesse.Howell19@yahoo.com", "Jesse", "Howell", new DateTime(2023, 8, 22, 15, 44, 49, 587, DateTimeKind.Local).AddTicks(5116) },
                    { new Guid("2e7e4aef-6390-4a51-b41b-75f945a36d45"), new DateTime(2022, 9, 27, 12, 34, 47, 495, DateTimeKind.Local).AddTicks(592), "Christie.Tremblay@gmail.com", "Christie", "Tremblay", new DateTime(2023, 4, 25, 17, 32, 36, 368, DateTimeKind.Local).AddTicks(9952) },
                    { new Guid("43111f45-478f-4feb-a899-e0596642c244"), new DateTime(2023, 12, 25, 17, 51, 5, 598, DateTimeKind.Local).AddTicks(7342), "Lillian_Bahringer78@gmail.com", "Lillian", "Bahringer", new DateTime(2023, 5, 8, 16, 29, 50, 802, DateTimeKind.Local).AddTicks(5268) },
                    { new Guid("4ac854f1-a113-4b8d-8d07-f11ac3ae29af"), new DateTime(2022, 7, 15, 0, 21, 42, 188, DateTimeKind.Local).AddTicks(2434), "Miranda.McLaughlin48@gmail.com", "Miranda", "McLaughlin", new DateTime(2023, 5, 19, 21, 33, 20, 223, DateTimeKind.Local).AddTicks(6046) },
                    { new Guid("56be272f-17c7-4ec4-87bb-8768e11b07d7"), new DateTime(2022, 8, 12, 21, 0, 42, 738, DateTimeKind.Local).AddTicks(5593), "Evan.Treutel@yahoo.com", "Evan", "Treutel", new DateTime(2023, 3, 30, 22, 2, 54, 515, DateTimeKind.Local).AddTicks(840) },
                    { new Guid("62e4e891-0875-40ae-a347-79d46770a526"), new DateTime(2022, 9, 5, 0, 28, 55, 126, DateTimeKind.Local).AddTicks(834), "Richard_Schmeler84@yahoo.com", "Richard", "Schmeler", new DateTime(2023, 11, 24, 11, 53, 22, 802, DateTimeKind.Local).AddTicks(3845) },
                    { new Guid("673e7020-a126-4253-ad18-baf30852dd75"), new DateTime(2023, 3, 3, 18, 40, 38, 150, DateTimeKind.Local).AddTicks(5627), "Geoffrey.Stiedemann@hotmail.com", "Geoffrey", "Stiedemann", new DateTime(2023, 4, 8, 12, 54, 27, 839, DateTimeKind.Local).AddTicks(9005) },
                    { new Guid("8061edab-098d-4a70-bde8-01e2fdc3f428"), new DateTime(2023, 12, 22, 14, 2, 39, 426, DateTimeKind.Local).AddTicks(4136), "Aaron.Reinger99@gmail.com", "Aaron", "Reinger", new DateTime(2023, 8, 1, 13, 57, 24, 325, DateTimeKind.Local).AddTicks(8795) },
                    { new Guid("90f21eb1-5d93-4632-a07c-a086ae395229"), new DateTime(2022, 9, 12, 9, 3, 3, 699, DateTimeKind.Local).AddTicks(317), "Viola_Baumbach8@hotmail.com", "Viola", "Baumbach", new DateTime(2023, 4, 6, 6, 49, 21, 321, DateTimeKind.Local).AddTicks(220) },
                    { new Guid("930b7252-da5a-45f7-9870-7b28090baaa6"), new DateTime(2022, 3, 24, 18, 15, 39, 368, DateTimeKind.Local).AddTicks(1423), "Doug24@gmail.com", "Doug", "Greenfelder", new DateTime(2023, 8, 3, 2, 35, 3, 927, DateTimeKind.Local).AddTicks(2054) },
                    { new Guid("942c52b3-4e6c-46df-b9b3-7c70f80d4a88"), new DateTime(2022, 9, 7, 16, 48, 5, 595, DateTimeKind.Local).AddTicks(2075), "Michael.Schaden95@hotmail.com", "Michael", "Schaden", new DateTime(2023, 2, 21, 15, 16, 34, 102, DateTimeKind.Local).AddTicks(5222) },
                    { new Guid("9868583d-03b2-4e1d-b94f-4666715ffabe"), new DateTime(2023, 10, 5, 22, 2, 34, 805, DateTimeKind.Local).AddTicks(2923), "Michael_Ankunding@gmail.com", "Michael", "Ankunding", new DateTime(2023, 4, 7, 4, 56, 9, 352, DateTimeKind.Local).AddTicks(3936) },
                    { new Guid("a31a17e4-67e9-48e1-a91e-5f17c285cf23"), new DateTime(2023, 11, 18, 18, 28, 9, 484, DateTimeKind.Local).AddTicks(2765), "Ronald_McKenzie95@gmail.com", "Ronald", "McKenzie", new DateTime(2023, 4, 7, 20, 36, 39, 643, DateTimeKind.Local).AddTicks(9070) },
                    { new Guid("afa7ff8a-f8bc-427e-8a10-7639f0f67901"), new DateTime(2022, 8, 24, 6, 18, 8, 871, DateTimeKind.Local).AddTicks(6314), "Diana.Padberg23@hotmail.com", "Diana", "Padberg", new DateTime(2023, 12, 21, 14, 20, 24, 114, DateTimeKind.Local).AddTicks(9544) },
                    { new Guid("b01dbefd-b0b1-4779-87fc-03c372426bbc"), new DateTime(2023, 1, 3, 11, 33, 6, 348, DateTimeKind.Local).AddTicks(9405), "Jeanne.Kreiger12@yahoo.com", "Jeanne", "Kreiger", new DateTime(2023, 11, 12, 5, 54, 56, 883, DateTimeKind.Local).AddTicks(1163) },
                    { new Guid("b17d24d7-a0f4-42e3-8ee6-889936b8fc3f"), new DateTime(2023, 3, 17, 7, 15, 48, 339, DateTimeKind.Local).AddTicks(1681), "Norman.Corwin@yahoo.com", "Norman", "Corwin", new DateTime(2023, 2, 14, 19, 41, 27, 669, DateTimeKind.Local).AddTicks(9825) },
                    { new Guid("b9eed57f-bcce-4e01-bbaa-e72de5159753"), new DateTime(2022, 3, 23, 10, 51, 59, 661, DateTimeKind.Local).AddTicks(4600), "Annie_Borer@hotmail.com", "Annie", "Borer", new DateTime(2023, 9, 2, 19, 28, 45, 223, DateTimeKind.Local).AddTicks(1514) },
                    { new Guid("ba638687-5399-48b0-a75d-a77524f51228"), new DateTime(2022, 3, 31, 20, 5, 48, 30, DateTimeKind.Local).AddTicks(7232), "Cynthia_Price73@yahoo.com", "Cynthia", "Price", new DateTime(2023, 3, 21, 17, 39, 48, 497, DateTimeKind.Local).AddTicks(4256) },
                    { new Guid("beeb1322-825a-4b60-8cbf-307b3dfd2c28"), new DateTime(2022, 11, 29, 16, 11, 38, 144, DateTimeKind.Local).AddTicks(1265), "Clinton76@gmail.com", "Clinton", "O'Connell", new DateTime(2023, 9, 18, 19, 42, 9, 541, DateTimeKind.Local).AddTicks(8976) },
                    { new Guid("bf592051-bbdc-4874-9ac5-b948acf488e1"), new DateTime(2023, 5, 12, 18, 19, 2, 936, DateTimeKind.Local).AddTicks(5218), "Thelma36@yahoo.com", "Thelma", "Marquardt", new DateTime(2023, 7, 21, 12, 20, 0, 900, DateTimeKind.Local).AddTicks(6556) },
                    { new Guid("c3f81423-2ba4-4970-9190-3611252a36f4"), new DateTime(2022, 12, 19, 16, 30, 33, 200, DateTimeKind.Local).AddTicks(2795), "Ana_Dicki@hotmail.com", "Ana", "Dicki", new DateTime(2023, 2, 18, 1, 12, 59, 355, DateTimeKind.Local).AddTicks(9218) },
                    { new Guid("c895118a-299f-4a43-8912-f6fa5592f57e"), new DateTime(2022, 4, 29, 10, 16, 0, 665, DateTimeKind.Local).AddTicks(7428), "Peter_Rempel@hotmail.com", "Peter", "Rempel", new DateTime(2023, 9, 12, 23, 8, 21, 972, DateTimeKind.Local).AddTicks(1006) },
                    { new Guid("cbf772b5-837b-4785-b64b-4ff587676496"), new DateTime(2022, 8, 1, 17, 10, 42, 405, DateTimeKind.Local).AddTicks(1850), "Stella.Labadie33@gmail.com", "Stella", "Labadie", new DateTime(2023, 8, 26, 3, 37, 29, 254, DateTimeKind.Local).AddTicks(9202) },
                    { new Guid("e944b58e-09a2-4722-b297-e5928063db24"), new DateTime(2023, 8, 26, 7, 36, 44, 971, DateTimeKind.Local).AddTicks(7427), "Anna_Pacocha95@hotmail.com", "Anna", "Pacocha", new DateTime(2023, 7, 2, 23, 21, 55, 210, DateTimeKind.Local).AddTicks(606) },
                    { new Guid("f5005123-d252-4f82-8f9f-487ca434ad40"), new DateTime(2023, 10, 16, 21, 5, 5, 40, DateTimeKind.Local).AddTicks(395), "David.Kuphal59@hotmail.com", "David", "Kuphal", new DateTime(2023, 8, 21, 2, 5, 30, 918, DateTimeKind.Local).AddTicks(4660) },
                    { new Guid("f647d247-fbb4-4c8e-916f-d86ba8395de4"), new DateTime(2022, 7, 19, 6, 50, 9, 466, DateTimeKind.Local).AddTicks(6778), "Bradley_Hahn90@yahoo.com", "Bradley", "Hahn", new DateTime(2023, 9, 6, 1, 34, 2, 92, DateTimeKind.Local).AddTicks(6296) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0ef41b89-80ce-491d-b780-9a9c99883bdf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1176918e-74f2-4eca-8838-a3a2e026a571"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1e75dc8e-9fa9-4d71-b32e-70305c003944"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("20861e7e-a2c4-4455-90a3-58661a474b38"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("21565dfa-15f8-44b7-85de-215285f85a04"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2e7e4aef-6390-4a51-b41b-75f945a36d45"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("43111f45-478f-4feb-a899-e0596642c244"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4ac854f1-a113-4b8d-8d07-f11ac3ae29af"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("56be272f-17c7-4ec4-87bb-8768e11b07d7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("62e4e891-0875-40ae-a347-79d46770a526"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("673e7020-a126-4253-ad18-baf30852dd75"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8061edab-098d-4a70-bde8-01e2fdc3f428"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("90f21eb1-5d93-4632-a07c-a086ae395229"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("930b7252-da5a-45f7-9870-7b28090baaa6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("942c52b3-4e6c-46df-b9b3-7c70f80d4a88"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9868583d-03b2-4e1d-b94f-4666715ffabe"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a31a17e4-67e9-48e1-a91e-5f17c285cf23"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("afa7ff8a-f8bc-427e-8a10-7639f0f67901"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b01dbefd-b0b1-4779-87fc-03c372426bbc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b17d24d7-a0f4-42e3-8ee6-889936b8fc3f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9eed57f-bcce-4e01-bbaa-e72de5159753"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ba638687-5399-48b0-a75d-a77524f51228"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("beeb1322-825a-4b60-8cbf-307b3dfd2c28"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf592051-bbdc-4874-9ac5-b948acf488e1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3f81423-2ba4-4970-9190-3611252a36f4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c895118a-299f-4a43-8912-f6fa5592f57e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cbf772b5-837b-4785-b64b-4ff587676496"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e944b58e-09a2-4722-b297-e5928063db24"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f5005123-d252-4f82-8f9f-487ca434ad40"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f647d247-fbb4-4c8e-916f-d86ba8395de4"));
        }
    }
}
