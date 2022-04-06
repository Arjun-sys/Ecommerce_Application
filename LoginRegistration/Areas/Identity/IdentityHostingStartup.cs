using System;
using LoginRegistration.Areas.Identity.Data;
using LoginRegistration.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LoginRegistration.Areas.Identity.IdentityHostingStartup))]
namespace LoginRegistration.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LoginRegistrationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LoginRegistrationDbContextConnection")));

                services.AddDefaultIdentity<LoginRegistrationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<LoginRegistrationDbContext>();
            });
        }
    }
}