using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuanLyTaiChinhCaNhan_Nhom06.Data;
using QuanLyTaiChinhCaNhan_Nhom06.Services;
using QuanLyTaiChinhCaNhan_Nhom06.Services.Implementations;
using QuanLyTaiChinhCaNhan_Nhom06.Services.Interfaces;
using QuanLyTaiChinhCaNhan_Nhom06.ViewModels;
using QuanLyTaiChinhCaNhan_Nhom06.Views;

namespace QuanLyTaiChinhCaNhan_Nhom06
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();

            var connectionString = "Server=(local);Database=QuanLyTaiChinhDB;Trusted_Connection=true;Encrypt=false;";

            services.AddDbContextFactory<ExpenseDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddSingleton<ISessionContext, SessionContext>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();

            services.AddTransient<LoginViewModel>();
            services.AddTransient<RegisterViewModel>();

            services.AddTransient<LoginView>();
            services.AddTransient<RegisterView>();

            Services = services.BuildServiceProvider();

            var loginView = Services.GetRequiredService<LoginView>();
            loginView.Show();
        }
    }
}