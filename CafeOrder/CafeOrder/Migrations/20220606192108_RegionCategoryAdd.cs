using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeOrder.Migrations
{
    public partial class RegionCategoryAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodCategoryId = table.Column<int>(type: "int", nullable: true),
                    FoodRegionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_FoodCategories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Foods_FoodRegions_FoodRegionId",
                        column: x => x.FoodRegionId,
                        principalTable: "FoodRegions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Drink" },
                    { 2, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "FoodRegions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Japan" },
                    { 2, "Korea" },
                    { 3, "Hong Kong" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodCategoryId", "FoodRegionId", "ImgUrl", "Introduction", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 1, "#", "Green tea is a type of tea that is made from Camellia sinensis leaves and buds that have not undergone the same withering.", "Green Tea", 1.5m, 3 },
                    { 2, 1, 1, "#", "Ramune is a Japanese carbonated soft drink. It was introduced in 1884 in Kobe by the British pharmacist Alexander Cameron Sim. ", "Ramune", 1.6m, 4 },
                    { 3, 2, 1, "#", "Taiyaki is a Japanese fish-shaped cake, commonly sold as street food. The most common filling is red bean paste that is made from sweetened adzuki beans.", "Taiyaki", 1.8m, 4 },
                    { 4, 2, 1, "#", "Dorayaki is a type of Japanese confection. It consists of two small pancake-like patties made from castella wrapped around a filling of sweet azuki bean paste.", "Dorayaki", 1.8m, 4 },
                    { 5, 2, 1, "#", "Dango is a Japanese dumpling made from rice flour mixed with uruchi rice flour and glutinous rice flour.", "Dango", 1.6m, 3 },
                    { 6, 2, 1, "#", "Takoyaki is a ball-shaped Japanese snack made of a wheat flour-based batter and cooked in a special molded pan. ", "Takoyaki", 2.2m, 5 },
                    { 7, 1, 2, "#", "Banana Flavored Milk is a South Korean milk beverage produced by Binggrae in Korea.", "Banana Flavored Milk", 2.2m, 4 },
                    { 8, 2, 2, "#", "Hotteok, sometimes called Hoeddeok, is a type of filled pancake and is a popular street food in South Korea. ", "Hotteok", 1.8m, 5 },
                    { 9, 2, 2, "#", "walnut cookie is a type of cookie originated from Cheonan, South Korea.", "Walnut cookie", 1.6m, 3 },
                    { 10, 1, 3, "#", "The drink is made from a mixture between coffee and tea. It can be served hot or cold.", "Yuenyeung", 2m, 4 },
                    { 11, 1, 3, "#", "Milk tea refers to several forms of beverage found in many cultures, containing some combination of tea and milk.", "Milktea", 2m, 4 },
                    { 12, 2, 3, "#", "These Cantonese egg tarts are classic pastry in Hong Kong, with buttery, crisp and crumbly tart shell, silky smooth custard inside.", "Eggtart", 1.5m, 5 },
                    { 13, 2, 3, "#", "An egg waffle is a spherical egg-based waffle popular in Hong Kong, consisting of an eggy leavened batter cooked between two plates of semi-spherical cells.", "Egg Waffles ", 1.8m, 4 },
                    { 14, 2, 3, "#", "Peanut butter, butter, sugar and condensed milk are put together in the 2 waffles.", "Baked waffles", 1.8m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodRegionId",
                table: "Foods",
                column: "FoodRegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "FoodRegions");
        }
    }
}
