using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTaiChinhCaNhan_Nhom06.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(7)]
        public string? Color { get; set; }

        [StringLength(50)]
        public string? Icon { get; set; }

        public TransactionType Type { get; set; } = TransactionType.Expense;

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User? User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
