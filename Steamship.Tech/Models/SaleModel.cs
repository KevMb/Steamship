namespace Steamship.Tech.Models
{
    public class SaleModel
    {
        public int Id { get; set; }
        public string SaleTitle { get; set; }
        public string SaleDescription { get; set; }
        public double SalePrice { get; set; }

        public int EmployeeId { get; set; }
    }
}
