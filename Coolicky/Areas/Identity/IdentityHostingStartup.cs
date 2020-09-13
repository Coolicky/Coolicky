using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Coolicky.Areas.Identity.IdentityHostingStartup))]

namespace Coolicky.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}