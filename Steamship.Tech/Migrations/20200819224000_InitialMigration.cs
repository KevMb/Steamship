using Microsoft.EntityFrameworkCore.Migrations;

namespace Steamship.Tech.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    LineManagerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_LineManagerId",
                        column: x => x.LineManagerId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleTitle = table.Column<string>(maxLength: 100, nullable: false),
                    SaleDescription = table.Column<string>(maxLength: 250, nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "FirstName", "LastName", "LineManagerId" },
                values: new object[] { 1, "BackTo@TheFuture.com", "Marty", "McFly", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "FirstName", "LastName", "LineManagerId" },
                values: new object[] { 2, "DunderMifflin@TheOffice.com", "Michael", "Scott", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "FirstName", "LastName", "LineManagerId" },
                values: new object[] { 5, "JediMaster@DarkSide.com", "Darth", "Vader", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "FirstName", "LastName", "LineManagerId" },
                values: new object[,]
                {
                    { 4, "NotBatman@Gotham.com", "Bruce", "Wayne", 1 },
                    { 8, "ClownPrinceOfCrime@Gotham.com", "The", "Jocker", 1 },
                    { 3, "NotSuperman@Krypton.com", "Clark", "Kent", 2 },
                    { 9, "GottaCatchEmAll@Kanto.com", "Ash", "Ketchum", 2 },
                    { 10, "ScoobertTheGreat@MysteryMachine.com", "Scooby", "Doo", 2 },
                    { 6, "TheKingInTheNorth@Winterfell.com", "Jon", "Snow", 5 },
                    { 7, "TheGreatest@Champ.com", "Muhammad", "Ali", 5 },
                    { 11, "BlackPanther@Wakanda.com", "T'Challa", "Unknown", 5 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "EmployeeId", "SaleDescription", "SalePrice", "SaleTitle" },
                values: new object[,]
                {
                    { 2, 4, "Sold a pair of emerald earrings to Catwoman of Gotham.", 50000.0, "Catwoman earrings sale" },
                    { 21, 6, "mi, ac mattis velit justo nec ante. Maecenas mi felis.", 346.0, "odio a purus. Duis elementum, dui quis accumsan convallis." },
                    { 20, 10, "eget ipsum. Suspendisse sagittis. Nullam vitae diam.", 61.0, "augue ut lacus. Nulla tincidunt, neque vitae semper egestas, urna justo" },
                    { 5, 10, "arcu ac orci. Ut semper pretium neque. Morbi quis urna.", 50.0, "amet diam eu dolor." },
                    { 4, 10, "Sold kryptonite to Lex Luthor of Metropolis.", 3500.0, "Lex Luthor kryptonite ale" },
                    { 1, 10, "Sold 5000 units of paper to Naruto of the Leaf Village.", 3500.0, "Naruto paper sale" },
                    { 19, 9, "bibendum. Donec felis orci, adipiscing non, luctus sit amet, faucibus ut.", 677.0, "Duis sit amet diam eu dolor egestas rhoncus." },
                    { 17, 9, "molestie tortor nibh sit amet orci. Ut sagittis lobortis mauris.", 764.0, "magna. Lorem ipsum dolor sit amet." },
                    { 13, 11, "facilisi. Sed neque. Sed eget lacus.", 973.0, "Curabitur massa. Vestibulum accumsan neque et nunc." },
                    { 12, 9, "Nullam nisl. Maecenas malesuada fringilla est.", 249.0, "amet, consectetuer adipiscing elit. Etiam laoreet." },
                    { 23, 3, "penatibus et magnis dis parturient montes, nascetur ridiculus mus.", 227.0, "lacus, varius et, euismod et, commodo at, libero." },
                    { 7, 3, "et, rutrum non, hendrerit id, ante. Nunc mauris sapien.", 345.0, "vulputate, lacus. Cras interdum. Nunc sollicitudin commodo ipsum." },
                    { 6, 3, "hendrerit consectetuer, cursus et, magna.", 608.0, "taciti sociosqu ad litora torquent per conubia nostra." },
                    { 24, 4, "montes, nascetur ridiculus mus. Donec dignissim magna a tortor.", 98.0, "augue ut lacus. Nulla tincidunt, neque vitae semper egestas." },
                    { 22, 4, "Quisque ornare tortor at risus. Nunc ac sem ut dolor dapibus gravida.", 750.0, "augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan sed." },
                    { 15, 4, "ornare tortor at risus. Nunc ac sem ut dolor.", 9.0, "massa non ante bibendum ullamcorper." },
                    { 3, 4, "Sold a necklace and gold bracelet to Catwoman of Gotham.", 3500.0, "Catwoman necklace and bracelet sale" },
                    { 10, 9, "nulla. In tincidunt congue turpis. In condimentum.", 775.0, "dapibus rutrum, justo. Praesent luctus." },
                    { 18, 11, "ipsum leo elementum sem, vitae aliquam eros turpis non enim. Mauris", 29.0, "primis in faucibus orci luctus et ultrices posuere cubilia Curae." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LineManagerId",
                table: "Employees",
                column: "LineManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
