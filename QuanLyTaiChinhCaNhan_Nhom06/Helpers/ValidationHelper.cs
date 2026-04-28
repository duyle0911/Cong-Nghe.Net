namespace QuanLyTaiChinhCaNhan_Nhom06.Helpers
{
    public static class ValidationHelper
    {
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
        public static bool IsValidUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username) && 
                   !username.Contains(" ") && 
                   !username.Contains("\t") &&
                   username.Length >= 3 &&
                   username.Length <= 50;
        }

        public static bool IsStrongPassword(string password)
        {
            return password.Length >= 6;
        }

        public static bool IsValidFullName(string fullName)
        {
            return !string.IsNullOrWhiteSpace(fullName) && 
                   fullName.Length <= 100;
        }
    }
}
