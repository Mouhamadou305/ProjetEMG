using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ProjetEMG2.Data;

namespace ProjetEMG2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("emgDb"));

            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
            //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>().
                AddDefaultUI().
                AddDefaultTokenProviders();

            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            var scope = app.Services.CreateScope();
            
            var services = scope.ServiceProvider;
            var dbContext = services.GetRequiredService<ApplicationDbContext>();
            SampleData.Initialize(services);

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapRazorPages();
            //ApplyMigration();
            app.Run();

            //void ApplyMigration()
            //{
            //    using (var scope = app.Services.CreateScope())
            //    {
            //        var _db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //        if(_db.Database.GetPendingMigrations().Count()>0)
            //        {
            //            _db.Database.Migrate();
            //        }
            //    }
            //}
        }

        
    }
}
