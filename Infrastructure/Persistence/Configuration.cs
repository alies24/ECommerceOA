using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence
{
    public static class Configuration
    {
       
        public static string VerifyJson()
        {
            string connectionString = "PostgreSQL";
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Presentation/ECommerceOA.WebAPI"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString(connectionString);
        }
    }
}
