using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace file_duplicator_to_cloud.Models
{
    public class Startup
    {
        public OAuthSettings? OAuthSettings { get; private set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();

            OAuthSettings = config.GetSection("OAuthSettings").Get<OAuthSettings>();
            // directories settings here
        }
    }
}
