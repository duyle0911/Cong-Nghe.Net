using System.Collections.Generic;
using System.Linq;
using QuanLyTaiChinhCaNhan_Nhom06.Models;

namespace QuanLyTaiChinhCaNhan_Nhom06.Helpers
{
    public static class CategoryHelper
    {
        /// <summary>
        /// Lấy danh mục mặc định cho giao dịch chi tiêu
        /// </summary>
        public static List<(string Name, string Color, string Icon)> GetDefaultExpenseCategories()
        {
            return new List<(string, string, string)>
            {
                ("Ăn uống", "#FF5722", "Restaurant"),
                ("Mua sắm", "#E91E63", "Shopping"),
                ("Giao thông", "#9C27B0", "DirectionsCar"),
                ("Giải trí", "#673AB7", "Movie"),
                ("Y tế", "#3F51B5", "LocalHospital"),
                ("Giáo dục", "#2196F3", "School"),
                ("Hóa đơn", "#00BCD4", "Receipt"),
                ("Khác", "#607D8B", "More")
            };
        }

        /// <summary>
        /// Lấy danh mục mặc định cho giao dịch thu nhập
        /// </summary>
        public static List<(string Name, string Color, string Icon)> GetDefaultIncomeCategories()
        {
            return new List<(string, string, string)>
            {
                ("Lương", "#4CAF50", "Work"),
                ("Thưởng", "#8BC34A", "CardGiftcard"),
                ("Đầu tư", "#CDDC39", "TrendingUp"),
                ("Freelance", "#FFC107", "Freelancer"),
                ("Kinh doanh", "#FF9800", "Store"),
                ("Khác", "#795548", "More")
            };
        }

        /// <summary>
        /// Lấy màu theo loại giao dịch
        /// </summary>
        public static string GetCategoryColor(TransactionType type)
        {
            return type == TransactionType.Income ? "#4CAF50" : "#FF5722";
        }
    }
}
