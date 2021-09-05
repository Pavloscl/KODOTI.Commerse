using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Databese.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Descripcion", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product1", 233m },
                    { 73, "Description for product 73", "Product73", 798m },
                    { 72, "Description for product 72", "Product72", 502m },
                    { 71, "Description for product 71", "Product71", 289m },
                    { 70, "Description for product 70", "Product70", 380m },
                    { 69, "Description for product 69", "Product69", 604m },
                    { 68, "Description for product 68", "Product68", 859m },
                    { 67, "Description for product 67", "Product67", 889m },
                    { 66, "Description for product 66", "Product66", 264m },
                    { 65, "Description for product 65", "Product65", 800m },
                    { 64, "Description for product 64", "Product64", 297m },
                    { 63, "Description for product 63", "Product63", 959m },
                    { 62, "Description for product 62", "Product62", 564m },
                    { 61, "Description for product 61", "Product61", 426m },
                    { 60, "Description for product 60", "Product60", 155m },
                    { 59, "Description for product 59", "Product59", 687m },
                    { 58, "Description for product 58", "Product58", 425m },
                    { 57, "Description for product 57", "Product57", 412m },
                    { 56, "Description for product 56", "Product56", 162m },
                    { 55, "Description for product 55", "Product55", 712m },
                    { 54, "Description for product 54", "Product54", 216m },
                    { 53, "Description for product 53", "Product53", 626m },
                    { 74, "Description for product 74", "Product74", 666m },
                    { 52, "Description for product 52", "Product52", 724m },
                    { 75, "Description for product 75", "Product75", 581m },
                    { 77, "Description for product 77", "Product77", 827m },
                    { 98, "Description for product 98", "Product98", 146m },
                    { 97, "Description for product 97", "Product97", 949m },
                    { 96, "Description for product 96", "Product96", 430m },
                    { 95, "Description for product 95", "Product95", 179m },
                    { 94, "Description for product 94", "Product94", 758m },
                    { 93, "Description for product 93", "Product93", 392m },
                    { 92, "Description for product 92", "Product92", 865m },
                    { 91, "Description for product 91", "Product91", 397m },
                    { 90, "Description for product 90", "Product90", 879m },
                    { 89, "Description for product 89", "Product89", 778m },
                    { 88, "Description for product 88", "Product88", 100m },
                    { 87, "Description for product 87", "Product87", 412m },
                    { 86, "Description for product 86", "Product86", 155m },
                    { 85, "Description for product 85", "Product85", 156m },
                    { 84, "Description for product 84", "Product84", 500m },
                    { 83, "Description for product 83", "Product83", 396m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Descripcion", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "Description for product 82", "Product82", 445m },
                    { 81, "Description for product 81", "Product81", 963m },
                    { 80, "Description for product 80", "Product80", 208m },
                    { 79, "Description for product 79", "Product79", 481m },
                    { 78, "Description for product 78", "Product78", 929m },
                    { 76, "Description for product 76", "Product76", 304m },
                    { 51, "Description for product 51", "Product51", 814m },
                    { 50, "Description for product 50", "Product50", 768m },
                    { 49, "Description for product 49", "Product49", 457m },
                    { 22, "Description for product 22", "Product22", 171m },
                    { 21, "Description for product 21", "Product21", 213m },
                    { 20, "Description for product 20", "Product20", 475m },
                    { 19, "Description for product 19", "Product19", 173m },
                    { 18, "Description for product 18", "Product18", 612m },
                    { 17, "Description for product 17", "Product17", 481m },
                    { 16, "Description for product 16", "Product16", 480m },
                    { 15, "Description for product 15", "Product15", 990m },
                    { 14, "Description for product 14", "Product14", 545m },
                    { 13, "Description for product 13", "Product13", 350m },
                    { 12, "Description for product 12", "Product12", 106m },
                    { 11, "Description for product 11", "Product11", 203m },
                    { 10, "Description for product 10", "Product10", 580m },
                    { 9, "Description for product 9", "Product9", 168m },
                    { 8, "Description for product 8", "Product8", 228m },
                    { 7, "Description for product 7", "Product7", 318m },
                    { 6, "Description for product 6", "Product6", 137m },
                    { 5, "Description for product 5", "Product5", 735m },
                    { 4, "Description for product 4", "Product4", 760m },
                    { 3, "Description for product 3", "Product3", 849m },
                    { 2, "Description for product 2", "Product2", 359m },
                    { 23, "Description for product 23", "Product23", 946m },
                    { 24, "Description for product 24", "Product24", 523m },
                    { 25, "Description for product 25", "Product25", 172m },
                    { 26, "Description for product 26", "Product26", 679m },
                    { 48, "Description for product 48", "Product48", 365m },
                    { 47, "Description for product 47", "Product47", 716m },
                    { 46, "Description for product 46", "Product46", 964m },
                    { 45, "Description for product 45", "Product45", 142m },
                    { 44, "Description for product 44", "Product44", 116m },
                    { 43, "Description for product 43", "Product43", 343m },
                    { 42, "Description for product 42", "Product42", 909m },
                    { 41, "Description for product 41", "Product41", 894m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Descripcion", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "Description for product 40", "Product40", 506m },
                    { 39, "Description for product 39", "Product39", 814m },
                    { 99, "Description for product 99", "Product99", 316m },
                    { 38, "Description for product 38", "Product38", 979m },
                    { 36, "Description for product 36", "Product36", 710m },
                    { 35, "Description for product 35", "Product35", 941m },
                    { 34, "Description for product 34", "Product34", 490m },
                    { 33, "Description for product 33", "Product33", 216m },
                    { 32, "Description for product 32", "Product32", 938m },
                    { 31, "Description for product 31", "Product31", 780m },
                    { 30, "Description for product 30", "Product30", 871m },
                    { 29, "Description for product 29", "Product29", 268m },
                    { 28, "Description for product 28", "Product28", 754m },
                    { 27, "Description for product 27", "Product27", 710m },
                    { 37, "Description for product 37", "Product37", 291m },
                    { 100, "Description for product 100", "Product100", 877m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[] { 100, 1, 87 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductInStockId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductInStockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
