using Microsoft.EntityFrameworkCore;
using MVC_CoreIdentity.Models;
using MVC_CoreIdentity.RepoServices;
using Microsoft.AspNetCore.Identity;
using MVC_CoreIdentity.Areas.Identity.Data;

namespace MVC_CoreIdentity
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("IdentityAppContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityAppContextConnection' not found.");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MainDbContext>(
                op=>op.UseSqlServer("Data Source=DESKTOP-13MSA5Q\\SS;Initial Catalog=TraineeDb;Integrated Security=True")
                );

            builder.Services.AddDbContext<IdentityAppContext>(
                op=>op.UseSqlServer("Server=DESKTOP-13MSA5Q\\SS;Database=MVC_CoreIdentity;Trusted_Connection=True;MultipleActiveResultSets=true")
                );
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<IdentityAppContext>();
            builder.Services.AddScoped<ITraineeRepo, TraineeRepoServices>();
            builder.Services.AddScoped<ITrackRepo, TrackRepoServices>();
            builder.Services.AddScoped<ICourse, CourceRepoServices>();
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

            app.MapRazorPages();

            app.Run();
        }
    }
}