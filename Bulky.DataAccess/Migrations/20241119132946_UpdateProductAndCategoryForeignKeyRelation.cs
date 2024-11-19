using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductAndCategoryForeignKeyRelation : Migration
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
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "SciFi" },
                    { 3, 3, "History" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "BookPrice", "CategoryId", "Description", "ISBN", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", 99.0, 1, "History; Professor Margaret Hensley stumbles upon an ancient artifact that can manipulate time itself. \r\n\r\nAs she navigates the temptation to rewrite her past, she becomes entangled in a centuries-old \r\n\r\nconflict between secret societies fighting to control the device.", "SWD9999001", 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Nancy Hoover", 40.0, 2, "Dark Skies weaves a tale of suspense, betrayal, and redemption as \r\n\r\njournalist Callie Mason races against time to uncover the truth about a decades-old conspiracy \r\n\r\nthreatening her community—one that could forever darken the skies of their future.", "CAW777777701", 30.0, 20.0, 25.0, "Dark Skies" },
                    { 3, "Julian Button", 55.0, 1, "Vanish in the Sunset follows the mysterious disappearance of a legendary outlaw, Cole McRae. \r\nWhen bounty hunter Evelyn Wyatt begins her search, she uncovers more than she bargained \r\nfor—a buried truth about McRae’s intentions and her own family’s involvement.", "RITO5555501", 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { 4, "Abby Muscles", 70.0, 3, "Cotton Candy is a heartwarming romance set in a bustling amusement park. When two strangers, \r\n\r\nOlivia, a jaded event planner, and Ethan, a struggling artist, meet over a shared cotton candy mishap, \r\n\r\nthey discover the sweet surprises life has in store.", "WS3333333301", 65.0, 55.0, 60.0, "Cotton Candy" },
                    { 5, "Ron Parker", 30.0, 2, "Rock in the Ocean is a gripping survival drama about marine biologist Lucy Warren, \r\nwho becomes stranded on a desolate island after her research vessel capsizes.", "SOTJ1111111101", 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { 6, "Laura Phantom", 25.0, 3, "A renowned botanist Emma Cline retreats to an enchanting forest to recover from a personal tragedy. \r\nAmong the towering trees and whispering leaves, she stumbles upon a hidden world teeming with magical creatures.", "FOT000000001", 23.0, 20.0, 22.0, "Leaves and Wonders" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
