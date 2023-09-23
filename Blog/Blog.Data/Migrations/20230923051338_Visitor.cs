using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("44600b5b-0d41-420d-9bda-b3bb7bc771b5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8887161f-070d-43ce-b0b0-3fd1aba601cb"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3508f172-ef0f-40d9-b778-54b5ea723816"), new Guid("79cace82-03cf-489a-92de-746f3c32c527"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.", "Admin Test", new DateTime(2023, 9, 23, 8, 13, 38, 137, DateTimeKind.Local).AddTicks(1767), null, null, new Guid("3c499dc8-0f63-44cb-a060-32183d00493e"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("1971a100-bb8b-4467-a652-829159a85c20"), 15 },
                    { new Guid("73806f39-b777-424b-b83b-8c33eab64166"), new Guid("a9ff72a1-9d62-43b7-8613-35b74c42a166"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.", "Admin Test", new DateTime(2023, 9, 23, 8, 13, 38, 137, DateTimeKind.Local).AddTicks(1757), null, null, new Guid("2cb1551b-8ffd-4a50-b1b1-b9e8ee973555"), false, null, null, "Asp.Net Core Deneme Makalesi 1", new Guid("182753c2-744c-4118-8179-2d7d03b588c9"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("43801b55-5bef-4234-80ab-8ba592da48c9"),
                column: "ConcurrencyStamp",
                value: "bc1ce5a4-ce6f-4d14-b3ba-337b5702f0a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d29b062-1147-4587-a80d-a8e2339d0891"),
                column: "ConcurrencyStamp",
                value: "87c83530-c6df-470e-85d1-7d43cbbb0b0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fa8bb9e4-3f71-4c60-9c73-72384e405000"),
                column: "ConcurrencyStamp",
                value: "515d6b06-2407-4f3a-96c9-9ea906206e23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("182753c2-744c-4118-8179-2d7d03b588c9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08705409-4288-4e09-a0d2-dc5b2a50fbd5", "AQAAAAEAACcQAAAAEA2iqJbdsimJovv7/fai+l3Bp+nKZNVulgVO8TffYFugOc9xmWGQe96IviJcey8XyQ==", "6b790269-20d1-417e-8212-f9ddeb4182ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1971a100-bb8b-4467-a652-829159a85c20"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "349f3e10-11c8-4e13-bb45-b8070ce11475", "AQAAAAEAACcQAAAAEJVGB5p17SD/ZlaF72Lf8nvwt+ibeddUFfd+bu4pncs0tIBpldpFKYf+dpYh8KN12g==", "73e6da52-6e05-437c-afdc-59382a646e3b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79cace82-03cf-489a-92de-746f3c32c527"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 8, 13, 38, 137, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9ff72a1-9d62-43b7-8613-35b74c42a166"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 8, 13, 38, 137, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2cb1551b-8ffd-4a50-b1b1-b9e8ee973555"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 8, 13, 38, 137, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3c499dc8-0f63-44cb-a060-32183d00493e"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 23, 8, 13, 38, 137, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3508f172-ef0f-40d9-b778-54b5ea723816"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("73806f39-b777-424b-b83b-8c33eab64166"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("44600b5b-0d41-420d-9bda-b3bb7bc771b5"), new Guid("a9ff72a1-9d62-43b7-8613-35b74c42a166"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.", "Admin Test", new DateTime(2023, 9, 10, 6, 19, 55, 330, DateTimeKind.Local).AddTicks(2626), null, null, new Guid("2cb1551b-8ffd-4a50-b1b1-b9e8ee973555"), false, null, null, "Asp.Net Core Deneme Makalesi 1", new Guid("182753c2-744c-4118-8179-2d7d03b588c9"), 15 },
                    { new Guid("8887161f-070d-43ce-b0b0-3fd1aba601cb"), new Guid("79cace82-03cf-489a-92de-746f3c32c527"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.", "Admin Test", new DateTime(2023, 9, 10, 6, 19, 55, 330, DateTimeKind.Local).AddTicks(2633), null, null, new Guid("3c499dc8-0f63-44cb-a060-32183d00493e"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("1971a100-bb8b-4467-a652-829159a85c20"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("43801b55-5bef-4234-80ab-8ba592da48c9"),
                column: "ConcurrencyStamp",
                value: "5880906a-3280-4198-965b-34a564ce5aab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d29b062-1147-4587-a80d-a8e2339d0891"),
                column: "ConcurrencyStamp",
                value: "765f666b-c483-4a4e-be1d-138592795291");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fa8bb9e4-3f71-4c60-9c73-72384e405000"),
                column: "ConcurrencyStamp",
                value: "ef1bd14b-f808-4248-8be4-ec03974ee1c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("182753c2-744c-4118-8179-2d7d03b588c9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ce77bee-c655-4d07-bc31-b92b2970bfea", "AQAAAAEAACcQAAAAEIRQwZKQV12Vls5yrcCq4NA1pqXNbXs/Rvk3+f/s9zR+lrRT63U/xJryZtxPt8Mm4w==", "69d794b6-791e-4ee9-ab87-53c23de03b1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1971a100-bb8b-4467-a652-829159a85c20"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f65f99-4f16-4bef-a063-8cde7806c2f0", "AQAAAAEAACcQAAAAEF2FDMW7WfNM1BLRisKr7fJCQ8QeB8gJRFVD6f6HP8iIluDI35cvK0rWApbaOvy3xw==", "5e5f5882-54a0-493b-8a16-5535136ead4b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79cace82-03cf-489a-92de-746f3c32c527"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 6, 19, 55, 330, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9ff72a1-9d62-43b7-8613-35b74c42a166"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 6, 19, 55, 330, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2cb1551b-8ffd-4a50-b1b1-b9e8ee973555"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 6, 19, 55, 330, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3c499dc8-0f63-44cb-a060-32183d00493e"),
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 6, 19, 55, 330, DateTimeKind.Local).AddTicks(3007));
        }
    }
}
