using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Coolicky.Utilities
{
    public static class Variables
    {
        public static string DatabaseString(IConfiguration Configuration)
        {
            var connectionString = Configuration["ConnectionStrings:DBLocation"];
            if (connectionString == null)
            {
                connectionString = Environment.GetEnvironmentVariable("SQL_STRING");
            }

            return connectionString;
        }

        public static string GoogleClientId(IConfiguration Configuration)
        {
            var googleClient = Configuration["Authentication:Google:ClientId"];
            if (googleClient == null)
            {
                googleClient = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_ID");
            }

            return googleClient;
        }

        public static string GoogleClientSecret(IConfiguration Configuration)
        {
            var googleSecret = Configuration["Authentication:Google:ClientSecret"];
            if (googleSecret == null)
            {
                googleSecret = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_SECRET");
            }

            return googleSecret;
        }

        public static string SendGridId(IConfiguration Configuration)
        {
            var sendgridId = Configuration["SendGridKey"];
            if (sendgridId == null)
            {
                sendgridId = Environment.GetEnvironmentVariable("SENDGRID_KEY");
            }

            return sendgridId;
        }
    }
}