using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using static System.Net.Mime.MediaTypeNames;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        private List<Articulos> list;
    }
}
