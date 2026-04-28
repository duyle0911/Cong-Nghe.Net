namespace QuanLyTaiChinhCaNhan_Nhom06.Helpers
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Kiểm tra xem email có hợp lệ không
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra xem username có hợp lệ không (không chứa khoảng trắng)
        /// </summary>
        public static bool IsValidUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username) && 
                   !username.Contains(" ") && 
                   !username.Contains("\t") &&
                   username.Length >= 3 &&
                   username.Length <= 50;
        }

        /// <summary>
        /// Kiểm tra xem mật khẩu có đủ mạnh không (ít nhất 6 ký tự)
        /// </summary>
        public static bool IsStrongPassword(string password)
        {
            return password.Length >= 6;
        }

        /// <summary>
        /// Kiểm tra xem tên đầy đủ có hợp lệ không
        /// </summary>
        public static bool IsValidFullName(string fullName)
        {
            return !string.IsNullOrWhiteSpace(fullName) && 
                   fullName.Length <= 100;
        }
    }
}
