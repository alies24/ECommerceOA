using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence.Configurations
{
    public static class Configuration
    {
        public static string ConfigurationVerification(string connectionString = "PostgreSQL")
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceOA.WebAPI"));
            configurationManager.AddJsonFile("appsetting.json");
            return configurationManager.GetConnectionString(connectionString);
            
        }
    }
}
