using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("79cace82-03cf-489a-92de-746f3c32c527"), "Admin Test", new DateTime(2023, 9, 7, 6, 28, 12, 744, DateTimeKind.Local).AddTicks(8177), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("a9ff72a1-9d62-43b7-8613-35b74c42a166"), "Admin Test", new DateTime(2023, 9, 7, 6, 28, 12, 744, DateTimeKind.Local).AddTicks(8175), null, null, false, null, null, "ASP.NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("2cb1551b-8ffd-4a50-b1b1-b9e8ee973555"), "Admin Test", new DateTime(2023, 9, 7, 6, 28, 12, 744, DateTimeKind.Local).AddTicks(8273), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("3c499dc8-0f63-44cb-a060-32183d00493e"), "Admin Test", new DateTime(2023, 9, 7, 6, 28, 12, 744, DateTimeKind.Local).AddTicks(8276), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("700a43a9-ebfd-425e-ab47-9ada5be45e4b"), new Guid("a9ff72a1-9d62-43b7-8613-35b74c42a166"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.", "Admin Test", new DateTime(2023, 9, 7, 6, 28, 12, 744, DateTimeKind.Local).AddTicks(7988), null, null, new Guid("2cb1551b-8ffd-4a50-b1b1-b9e8ee973555"), false, null, null, "Asp.Net Core Deneme Makalesi 1", 15 },
                    { new Guid("b426d617-37a9-461a-86e2-57c582f89216"), new Guid("79cace82-03cf-489a-92de-746f3c32c527"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque hendrerit libero ut neque dapibus, a elementum lectus auctor. Etiam enim arcu, porttitor sit amet quam eu, auctor eleifend eros. Ut sapien orci, feugiat ut nunc in, iaculis gravida metus. Aliquam vestibulum id risus a egestas. Nunc ut elementum libero. Pellentesque nibh nisi, vehicula id interdum ac, tristique ut tellus. Vivamus laoreet, ipsum ut dapibus vehicula, erat mauris lacinia nunc, rutrum dictum turpis libero vel est. Nunc molestie mi in felis vulputate, a sodales ex rutrum. Fusce posuere, sapien eu condimentum tristique, ex ipsum gravida nibh, vitae pulvinar mauris odio vel diam. Aenean odio risus, consequat vel sodales et, bibendum non lacus. Aliquam convallis, justo eget lacinia commodo, felis turpis dignissim urna, sed blandit nunc arcu id dolor. Nunc vestibulum, leo eget consectetur lacinia, nisi libero pulvinar erat, pellentesque vehicula mauris est ac magna. Donec maximus magna mi, sed suscipit lorem ultrices ut.", "Admin Test", new DateTime(2023, 9, 7, 6, 28, 12, 744, DateTimeKind.Local).AddTicks(7997), null, null, new Guid("3c499dc8-0f63-44cb-a060-32183d00493e"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("700a43a9-ebfd-425e-ab47-9ada5be45e4b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b426d617-37a9-461a-86e2-57c582f89216"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79cace82-03cf-489a-92de-746f3c32c527"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9ff72a1-9d62-43b7-8613-35b74c42a166"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2cb1551b-8ffd-4a50-b1b1-b9e8ee973555"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3c499dc8-0f63-44cb-a060-32183d00493e"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
