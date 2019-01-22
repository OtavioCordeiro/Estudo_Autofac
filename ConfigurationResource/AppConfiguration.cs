using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationResource
{
    public class AppConfiguration : IConfiguration
    {
        public string RepositoryType => ConfigurationManager.AppSettings["repositoryType"];
    }
}
