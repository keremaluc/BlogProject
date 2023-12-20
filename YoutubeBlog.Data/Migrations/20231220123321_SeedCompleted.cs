using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Articles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                    { new Guid("6b32f844-74a3-424b-9431-ecf65bee09e4"), "Admin Test", new DateTime(2023, 12, 20, 15, 33, 21, 719, DateTimeKind.Local).AddTicks(4490), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("a2235fb5-9aa0-4103-bb4b-5bc2bb74457f"), "Admin Test", new DateTime(2023, 12, 20, 15, 33, 21, 719, DateTimeKind.Local).AddTicks(4487), null, null, false, null, null, "ASP.NET CORE" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"), "Admin Test", new DateTime(2023, 12, 20, 15, 33, 21, 719, DateTimeKind.Local).AddTicks(4601), null, null, "images/vstest", ".png", false, null, null },
                    { new Guid("aed4065c-ffab-4b86-8837-3858281a850f"), "Admin Test", new DateTime(2023, 12, 20, 15, 33, 21, 719, DateTimeKind.Local).AddTicks(4583), null, null, "images/testimage", ".jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("962fbec3-afc8-44c2-a100-ff0d924cbd0c"), new Guid("a2235fb5-9aa0-4103-bb4b-5bc2bb74457f"), "Asp.Net Core Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.", "Admin Test", new DateTime(2023, 12, 20, 15, 33, 21, 719, DateTimeKind.Local).AddTicks(4299), null, null, new Guid("aed4065c-ffab-4b86-8837-3858281a850f"), false, null, null, "Asp.Net Core Deneme Makalesi 1", 15 },
                    { new Guid("c6979879-867f-48c4-8d6b-1cbb2530494a"), new Guid("6b32f844-74a3-424b-9431-ecf65bee09e4"), "Visual Studio Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.", "Admin Test", new DateTime(2023, 12, 20, 15, 33, 21, 719, DateTimeKind.Local).AddTicks(4306), null, null, new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"), false, null, null, "Visual Studio Core Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("962fbec3-afc8-44c2-a100-ff0d924cbd0c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c6979879-867f-48c4-8d6b-1cbb2530494a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b32f844-74a3-424b-9431-ecf65bee09e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2235fb5-9aa0-4103-bb4b-5bc2bb74457f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("aed4065c-ffab-4b86-8837-3858281a850f"));

            migrationBuilder.AlterColumn<string>(
                name: "ViewCount",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
