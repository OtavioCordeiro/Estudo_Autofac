using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationResource
{
    public interface IConfiguration
    {
        string RepositoryType { get; }
    }
}
