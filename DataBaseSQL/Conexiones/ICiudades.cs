using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSQL.Conexiones
{
    public interface ICiudades
    {
        IList<String> getCities();
    }
}
