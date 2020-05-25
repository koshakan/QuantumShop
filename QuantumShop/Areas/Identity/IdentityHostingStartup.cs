using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuantumShop.Areas.Identity.Data;
using QuantumShop.Data;

[assembly: HostingStartup(typeof(QuantumShop.Areas.Identity.IdentityHostingStartup))]
namespace QuantumShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<QuantumShopDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("QuantumShopDbContextConnection")));

                services.AddDefaultIdentity<QuantumShopUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<QuantumShopDbContext>();
            });
        }
    }
}