using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente
{
    public class Repository : IRepository
    {
        ILog _log;

        public Repository(ILog log)
        {
            _log = log;
        }

        public bool Create(string message)
        {
            _log.Save(message);
            return true;
        }

        public void Delete(int id)
        {
            _log.Save("Delete");
        }

        public string Read()
        {
            _log.Save("OK");

            return "OK";
        }

        public void Update(int id)
        {
            _log.Save("Update");
        }
    }
}
