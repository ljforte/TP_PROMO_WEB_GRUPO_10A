using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_PROMO_WEB_GRUPO_10A
{
    public class Categorias
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}