using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente
{
    public class NewRepository : IRepository
    {
        public bool Create(string message)
        {
            return false;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
