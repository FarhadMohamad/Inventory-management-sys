using System;
using InventoryManagementSys.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(InventoryManagementSys.Areas.Identity.IdentityHostingStartup))]
namespace InventoryManagementSys.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<InventoryManagementSysContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("InventoryManagementSysContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<InventoryManagementSysContext>();
            });
        }
    }
}