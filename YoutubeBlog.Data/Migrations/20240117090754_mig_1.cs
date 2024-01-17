using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("354043d3-5934-4136-b117-99f57b40f0f7"), "32ddfaef-b108-4ddb-9b27-3548c54cef7d", "SuperAdmin", "SUPERADMIN" },
                    { new Guid("5b680afb-97fa-4adb-a1c2-7fbd84616302"), "fb9e0b3b-a0dd-4e91-b4a7-2350582101fe", "User", "USER" },
                    { new Guid("9e62cbd1-68e7-4a37-bdb6-844c6c8090e3"), "c414dd2f-78d1-4452-ac27-fd198df7e929", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("6b32f844-74a3-424b-9431-ecf65bee09e4"), "Admin Test", new DateTime(2024, 1, 17, 12, 7, 54, 485, DateTimeKind.Local).AddTicks(5361), null, null, false, null, null, "Visual Studio 2022" },
                    { new Guid("a2235fb5-9aa0-4103-bb4b-5bc2bb74457f"), "Admin Test", new DateTime(2024, 1, 17, 12, 7, 54, 485, DateTimeKind.Local).AddTicks(5359), null, null, false, null, null, "ASP.NET CORE" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"), "Admin Test", new DateTime(2024, 1, 17, 12, 7, 54, 485, DateTimeKind.Local).AddTicks(5420), null, null, "images/vstest", ".png", false, null, null },
                    { new Guid("aed4065c-ffab-4b86-8837-3858281a850f"), "Admin Test", new DateTime(2024, 1, 17, 12, 7, 54, 485, DateTimeKind.Local).AddTicks(5418), null, null, "images/testimage", ".jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("45d910af-e957-4880-88a7-49b1fced6d24"), 0, "f3c81e3e-f0df-49d5-91d6-eb00ee93ea23", "admin@gmail.com", false, "Admin", new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFByKQZ6Gtqa+1bHgaVxecvxcrQHLieNQMR0uJuvhhoTp/xlgXWSU1HtCTjHINpXeQ==", "905553455855", false, "950fc757-33fc-46e1-a2a8-10be1b1128d7", false, "admin@gmail.com" },
                    { new Guid("e5102e42-2326-40d7-ae9d-f6593ce92a48"), 0, "ff5d930a-7b6c-410c-9dba-ea937ac8e1c7", "superadmin@gmail.com", true, "Kerem", new Guid("aed4065c-ffab-4b86-8837-3858281a850f"), "Aluç", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMIeVJjTuddZO90CNk3Qm6JXXruL7juAF7XawEU4gpP3UD/zG7U4NZIbGRvHgJC1AA==", "9", true, "591ab1f0-8f4b-47f6-a1a6-5fb86d19e133", false, "superadmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("16490ab8-a4ec-4930-99e6-2f9ca17dba45"), new Guid("a2235fb5-9aa0-4103-bb4b-5bc2bb74457f"), "Asp.Net Core Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.", "Admin Test", new DateTime(2024, 1, 17, 12, 7, 54, 485, DateTimeKind.Local).AddTicks(5233), null, null, new Guid("aed4065c-ffab-4b86-8837-3858281a850f"), false, null, null, "Asp.Net Core Deneme Makalesi 1", new Guid("e5102e42-2326-40d7-ae9d-f6593ce92a48"), 15 },
                    { new Guid("51163d17-35c4-450b-810d-cc6640604b9c"), new Guid("6b32f844-74a3-424b-9431-ecf65bee09e4"), "Visual Studio Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.", "Admin Test", new DateTime(2024, 1, 17, 12, 7, 54, 485, DateTimeKind.Local).AddTicks(5248), null, null, new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"), false, null, null, "Visual Studio Core Deneme Makalesi 1", new Guid("45d910af-e957-4880-88a7-49b1fced6d24"), 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9e62cbd1-68e7-4a37-bdb6-844c6c8090e3"), new Guid("45d910af-e957-4880-88a7-49b1fced6d24") },
                    { new Guid("354043d3-5934-4136-b117-99f57b40f0f7"), new Guid("e5102e42-2326-40d7-ae9d-f6593ce92a48") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
