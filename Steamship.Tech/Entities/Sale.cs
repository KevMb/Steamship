using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Steamship.Tech.Entities
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SaleTitle { get; set; }

        [Required]
        [MaxLength(250)]
        public string SaleDescription { get; set; }

        [Required]
        public double SalePrice { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public int EmployeeId { get; set; }
    }
}
