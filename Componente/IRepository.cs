using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente
{
    public interface IRepository
    {
        bool Create(string message);

        string Read();

        void Update(int id);

        void Delete(int id);
    }
}
