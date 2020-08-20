using Microsoft.EntityFrameworkCore.Migrations;

namespace Steamship.Tech.Migrations
{
    public partial class AdditionalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "EmployeeId", "SaleDescription", "SalePrice", "SaleTitle" },
                values: new object[,]
                {
                    { 25, 4, "augue ut lacus.", 9999.0, "massa." },
                    { 44, 2, "sodales at, velit.", 999.0, "quam. Pellentesque habitant morbi tristique" },
                    { 43, 7, "Proin velit. Sed malesuada augue ut lacus. Nulla tincidunt.", 350.0, "sit amet nulla. Donec non justo. Proin non massa" },
                    { 42, 4, "ultrices posuere cubilia Curae; Donec tincidunt.", 5788.0, "a sollicitudin orci" },
                    { 41, 1, "ipsum. Phasellus vitae mauris sit amet.", 6709.0, "non, luctus sit amet, faucibus ut, nulla." },
                    { 40, 8, "dolor elit, pellentesque a, facilisis non, bibendum sed, est.", 450.0, "interdum." },
                    { 39, 2, "a nunc. In at pede.", 1234.0, "et, rutrum non, hendrerit id," },
                    { 38, 10, "augue ac ipsum. Phasellus vitae mauris sit.", 2000.0, "neque" },
                    { 37, 3, "pede, nonummy ut, molestie in, tempus eu, ligula.", 250.0, "mattis. Integer eu" },
                    { 36, 3, "non, hendrerit id, ante.", 150.0, "aliquam iaculis." },
                    { 35, 11, "montes, nascetur ridiculus mus.", 25.0, "eget" },
                    { 34, 5, "eu odio tristique pharetra.", 8976.0, "lacus. Etiam bibendum fermentum metus." },
                    { 33, 9, "penatibus et magnis dis parturient montes.", 50.0, "quam. Pellentesque habitant" },
                    { 32, 1, "faucibus orci luctus et ultrices posuere cubilia Curae.", 5000.0, "amet ultricies sem magna nec quam." },
                    { 31, 10, "magna. Ut tincidunt orci quis lectus.", 678.0, "mauris. Suspendisse aliquet molestie tellus." },
                    { 30, 7, "nec, euismod in, dolor. Fusce feugiat.", 345.0, "Nam" },
                    { 29, 3, "Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis aliquet diam. Sed", 4839.0, "hendrerit a, arcu. Sed et libero. Proin mi. Aliquam" },
                    { 28, 4, "molestie in, tempus eu, ligula.", 400.0, "nec, malesuada ut, sem." },
                    { 27, 8, "Integer tincidunt aliquam arcu.", 546.0, "Vestibulum ante ipsum" },
                    { 26, 1, "interdum. Sed auctor odio a purus.", 12345.0, "Integer aliquam adipiscing lacus. Ut nec" },
                    { 45, 9, "risus. Donec egestas.", 555.0, "nec ligula consectetuer" },
                    { 46, 8, "sagittis placerat. Cras dictum ultricies ligula.", 345.0, "ut, pellentesque" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 46);
        }
    }
}
