using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTaiChinhCaNhan_Nhom06.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User? User { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue)]
        public decimal TargetAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CurrentAmount { get; set; } = 0;

        [StringLength(7)]
        public string? Color { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? DeadlineDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public bool IsCompleted { get; set; } = false;

        public decimal GetProgress() => TargetAmount > 0 ? (CurrentAmount / TargetAmount) * 100 : 0;
    }
}
