using Microsoft.EntityFrameworkCore;
using Steamship.Tech.Entities;

namespace Steamship.Tech.DbContexts
{
    public class SteamshipContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public SteamshipContext(DbContextOptions<SteamshipContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Marty",
                    LastName = "McFly",
                    Email = "BackTo@TheFuture.com",
                    LineManagerId = null
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Email = "DunderMifflin@TheOffice.com",
                    LineManagerId = null
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Clark",
                    LastName = "Kent",
                    Email = "NotSuperman@Krypton.com",
                    LineManagerId = 2
                },
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Email = "NotBatman@Gotham.com",
                    LineManagerId = 1
                },
                new Employee
                {
                    EmployeeId = 5,
                    FirstName = "Darth",
                    LastName = "Vader",
                    Email = "JediMaster@DarkSide.com",
                    LineManagerId = null
                },
                new Employee
                {
                    EmployeeId = 6,
                    FirstName = "Jon",
                    LastName = "Snow",
                    Email = "TheKingInTheNorth@Winterfell.com",
                    LineManagerId = 5
                },
                new Employee
                {
                    EmployeeId = 7,
                    FirstName = "Muhammad",
                    LastName = "Ali",
                    Email = "TheGreatest@Champ.com",
                    LineManagerId = 5
                },
                new Employee
                {
                    EmployeeId = 8,
                    FirstName = "The",
                    LastName = "Jocker",
                    Email = "ClownPrinceOfCrime@Gotham.com",
                    LineManagerId = 1
                },
                new Employee
                {
                    EmployeeId = 9,
                    FirstName = "Ash",
                    LastName = "Ketchum",
                    Email = "GottaCatchEmAll@Kanto.com",
                    LineManagerId = 2
                },
                new Employee
                {
                    EmployeeId = 10,
                    FirstName = "Scooby",
                    LastName = "Doo",
                    Email = "ScoobertTheGreat@MysteryMachine.com",
                    LineManagerId = 2
                },
                new Employee
                {
                    EmployeeId = 11,
                    FirstName = "T'Challa",
                    LastName = "Unknown",
                    Email = "BlackPanther@Wakanda.com",
                    LineManagerId = 5
                });

            modelBuilder.Entity<Sale>().HasData(
                new Sale
                {
                    SaleId = 1,
                    SaleTitle = "Naruto paper sale",
                    SaleDescription = "Sold 5000 units of paper to Naruto of the Leaf Village.",
                    SalePrice = 3500.00,
                    EmployeeId = 10
                },
                new Sale
                {
                    SaleId = 2,
                    SaleTitle = "Catwoman earrings sale",
                    SaleDescription = "Sold a pair of emerald earrings to Catwoman of Gotham.",
                    SalePrice = 50000.00,
                    EmployeeId = 4
                },
                new Sale
                {
                    SaleId = 3,
                    SaleTitle = "Catwoman necklace and bracelet sale",
                    SaleDescription = "Sold a necklace and gold bracelet to Catwoman of Gotham.",
                    SalePrice = 3500.00,
                    EmployeeId = 4
                },
                new Sale
                {
                    SaleId = 4,
                    SaleTitle = "Lex Luthor kryptonite ale",
                    SaleDescription = "Sold kryptonite to Lex Luthor of Metropolis.",
                    SalePrice = 3500.00,
                    EmployeeId = 10
                },
                new Sale
                {
                    SaleId = 5,
                    SaleTitle = "amet diam eu dolor.",
                    SaleDescription = "arcu ac orci. Ut semper pretium neque. Morbi quis urna.",
                    SalePrice = 50.00,
                    EmployeeId = 10
                },
                new Sale
                {
                    SaleId = 6,
                    SaleTitle = "taciti sociosqu ad litora torquent per conubia nostra.",
                    SaleDescription = "hendrerit consectetuer, cursus et, magna.",
                    SalePrice = 608.00,
                    EmployeeId = 3
                },
                new Sale
                {
                    SaleId = 7,
                    SaleTitle = "vulputate, lacus. Cras interdum. Nunc sollicitudin commodo ipsum.",
                    SaleDescription = "et, rutrum non, hendrerit id, ante. Nunc mauris sapien.",
                    SalePrice = 345.00,
                    EmployeeId = 3
                },
                new Sale
                {
                    SaleId = 10,
                    SaleTitle = "dapibus rutrum, justo. Praesent luctus.",
                    SaleDescription = "nulla. In tincidunt congue turpis. In condimentum.",
                    SalePrice = 775.00,
                    EmployeeId = 9
                },
                new Sale
                {
                    SaleId = 12,
                    SaleTitle = "amet, consectetuer adipiscing elit. Etiam laoreet.",
                    SaleDescription = "Nullam nisl. Maecenas malesuada fringilla est.",
                    SalePrice = 249.00,
                    EmployeeId = 9
                },
                new Sale
                {
                    SaleId = 13,
                    SaleTitle = "Curabitur massa. Vestibulum accumsan neque et nunc.",
                    SaleDescription = "facilisi. Sed neque. Sed eget lacus.",
                    SalePrice = 973.00,
                    EmployeeId = 11
                },
                new Sale
                {
                    SaleId = 15,
                    SaleTitle = "massa non ante bibendum ullamcorper.",
                    SaleDescription = "ornare tortor at risus. Nunc ac sem ut dolor.",
                    SalePrice = 9.00,
                    EmployeeId = 4
                },
                new Sale
                {
                    SaleId = 17,
                    SaleTitle = "magna. Lorem ipsum dolor sit amet.",
                    SaleDescription = "molestie tortor nibh sit amet orci. Ut sagittis lobortis mauris.",
                    SalePrice = 764.00,
                    EmployeeId = 9
                },
                new Sale
                {
                    SaleId = 18,
                    SaleTitle = "primis in faucibus orci luctus et ultrices posuere cubilia Curae.",
                    SaleDescription = "ipsum leo elementum sem, vitae aliquam eros turpis non enim. Mauris",
                    SalePrice = 29.00,
                    EmployeeId = 11
                },
                new Sale
                {
                    SaleId = 19,
                    SaleTitle = "Duis sit amet diam eu dolor egestas rhoncus.",
                    SaleDescription = "bibendum. Donec felis orci, adipiscing non, luctus sit amet, faucibus ut.",
                    SalePrice = 677.00,
                    EmployeeId = 9
                },
                new Sale
                {
                    SaleId = 20,
                    SaleTitle = "augue ut lacus. Nulla tincidunt, neque vitae semper egestas, urna justo",
                    SaleDescription = "eget ipsum. Suspendisse sagittis. Nullam vitae diam.",
                    SalePrice = 61.00,
                    EmployeeId = 10
                },
                new Sale
                {
                    SaleId = 21,
                    SaleTitle = "odio a purus. Duis elementum, dui quis accumsan convallis.",
                    SaleDescription = "mi, ac mattis velit justo nec ante. Maecenas mi felis.",
                    SalePrice = 346.00,
                    EmployeeId = 6
                },
                new Sale
                {
                    SaleId = 22,
                    SaleTitle = "augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan sed.",
                    SaleDescription = "Quisque ornare tortor at risus. Nunc ac sem ut dolor dapibus gravida.",
                    SalePrice = 750.00,
                    EmployeeId = 4
                },
                new Sale
                {
                    SaleId = 23,
                    SaleTitle = "lacus, varius et, euismod et, commodo at, libero.",
                    SaleDescription = "penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                    SalePrice = 227.00,
                    EmployeeId = 3
                },
                new Sale
                {
                    SaleId = 24,
                    SaleTitle = "augue ut lacus. Nulla tincidunt, neque vitae semper egestas.",
                    SaleDescription = "montes, nascetur ridiculus mus. Donec dignissim magna a tortor.",
                    SalePrice = 98.00,
                    EmployeeId = 4
                });
        }
    }
}
