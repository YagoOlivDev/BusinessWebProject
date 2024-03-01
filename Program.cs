using Microsoft.EntityFrameworkCore;
using ProjectWeb.Data;
using MySqlConnector;
using ProjectWeb.Controllers;
using ProjectWeb.Services;
using Microsoft.Extensions.DependencyInjection;


namespace ProjectWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);


            //builder.Services.AddScoped<SeedingService>();

            string mySqlConnection = builder.Configuration.GetConnectionString("ProjectWebContext");

            builder.Services.AddDbContext<ProjectWebContext>(options =>
                options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));

            builder.Services.AddScoped<SellerService>();
            builder.Services.AddScoped<DepartmentService>();


            // Add services to the container.
            builder.Services.AddControllersWithViews();


            var app = builder.Build();


            // Configure the HTTP request pipeline.


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}