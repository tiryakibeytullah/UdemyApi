using System;
using IdentityUserDeneme2.Areas.Identity.Data;
using IdentityUserDeneme2.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityUserDeneme2.Areas.Identity.IdentityHostingStartup))]
namespace IdentityUserDeneme2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<IdentityUserDeneme2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityUserDeneme2ContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<IdentityUserDeneme2Context>();
            });
        }
    }
}