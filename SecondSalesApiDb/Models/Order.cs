using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondSalesApiDb.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [StringLength(30)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        [StringLength(30)]
        public string Status { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

    }
}
