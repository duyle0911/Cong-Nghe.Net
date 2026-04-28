using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using QuanLyTaiChinhCaNhan_Nhom06.Data;
using QuanLyTaiChinhCaNhan_Nhom06.Models;
using QuanLyTaiChinhCaNhan_Nhom06.Services.Interfaces;

namespace QuanLyTaiChinhCaNhan_Nhom06.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IDbContextFactory<ExpenseDbContext> _dbFactory;
        private User? _currentUser;
        private readonly ISessionContext _sessionContext;

        public AuthenticationService(IDbContextFactory<ExpenseDbContext> dbFactory, ISessionContext sessionContext)
        {
            _dbFactory = dbFactory;
            _sessionContext = sessionContext;
        }

        public User? CurrentUser => _currentUser;
        public bool IsLoggedIn => _currentUser != null;

        public event EventHandler<UserLoggedInEventArgs>? UserLoggedIn;
        public event EventHandler? UserLoggedOut;

        public async Task<bool> RegisterAsync(string username, string email, string password, string? fullName = null)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Contains(" "))
                return false;

            try
            {
                await using var context = await _dbFactory.CreateDbContextAsync();
                
                if (await context.Users.AnyAsync(u => u.Username == username || u.Email == email))
                    return false;

                var user = new User
                {
                    Username = username,
                    Email = email,
                    PasswordHash = HashPassword(password),
                    FullName = fullName,
                    CreatedAt = DateTime.Now,
                    IsActive = true
                };

                context.Users.Add(user);
                await context.SaveChangesAsync();
                await CreateDefaultCategoriesAsync(user.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            try
            {
                await using var context = await _dbFactory.CreateDbContextAsync();
                var user = await context.Users
                    .FirstOrDefaultAsync(u => u.Username == username && u.IsActive);
                
                if (user == null || !VerifyPassword(password, user.PasswordHash))
                    return false;

                user.LastLoginAt = DateTime.Now;
                context.Users.Update(user);
                await context.SaveChangesAsync();

                _currentUser = user;
                _sessionContext.SetCurrentUser(user);
                UserLoggedIn?.Invoke(this, new UserLoggedInEventArgs(user));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Logout()
        {
            _currentUser = null;
            _sessionContext.ClearCurrentUser();
            UserLoggedOut?.Invoke(this, EventArgs.Empty);
        }

        public async Task<bool> UpdateProfileAsync(string? fullName, string? email, string? avatar = null)
        {
            if (_currentUser == null) return false;

            try
            {
                await using var context = await _dbFactory.CreateDbContextAsync();
                
                if (!string.IsNullOrEmpty(email) && email != _currentUser.Email)
                {
                    var exists = await context.Users
                        .AnyAsync(u => u.Email == email && u.Id != _currentUser.Id);
                    if (exists) return false;
                }

                var user = await context.Users.FindAsync(_currentUser.Id);
                if (user == null) return false;

                if (!string.IsNullOrEmpty(fullName))
                    user.FullName = fullName;

                if (!string.IsNullOrEmpty(email))
                    user.Email = email;

                if (avatar != null)
                    user.Avatar = avatar;

                context.Users.Update(user);
                await context.SaveChangesAsync();

                _currentUser.FullName = user.FullName;
                _currentUser.Email = user.Email;
                _currentUser.Avatar = user.Avatar;
                _sessionContext.SetCurrentUser(_currentUser);
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        private async Task CreateDefaultCategoriesAsync(int userId)
        {
            var seedDate = DateTime.Now;
            var defaultCategories = new List<Category>
            {
                new() { Name = "Ăn uống", Color = "#FF5722", Icon = "Restaurant", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Mua sắm", Color = "#E91E63", Icon = "Shopping", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Giao thông", Color = "#9C27B0", Icon = "DirectionsCar", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Giải trí", Color = "#673AB7", Icon = "Movie", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Y tế", Color = "#3F51B5", Icon = "LocalHospital", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Giáo dục", Color = "#2196F3", Icon = "School", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Hóa đơn", Color = "#00BCD4", Icon = "Receipt", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Khác", Color = "#607D8B", Icon = "More", Type = TransactionType.Expense, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Lương", Color = "#4CAF50", Icon = "Work", Type = TransactionType.Income, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Thưởng", Color = "#8BC34A", Icon = "CardGiftcard", Type = TransactionType.Income, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Đầu tư", Color = "#CDDC39", Icon = "TrendingUp", Type = TransactionType.Income, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Freelance", Color = "#FFC107", Icon = "Freelancer", Type = TransactionType.Income, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Kinh doanh", Color = "#FF9800", Icon = "Store", Type = TransactionType.Income, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate },
                new() { Name = "Khác", Color = "#795548", Icon = "More", Type = TransactionType.Income, UserId = userId, CreatedAt = seedDate, UpdatedAt = seedDate }
            };

            try
            {
                await using var context = await _dbFactory.CreateDbContextAsync();
                await context.Categories.AddRangeAsync(defaultCategories);
                await context.SaveChangesAsync();
            }
            catch
            {
                // Silently fail if categories already exist
            }
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }

        private static bool VerifyPassword(string password, string hash)
        {
            return HashPassword(password) == hash;
        }
    }
}