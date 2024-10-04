using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_PROMO_WEB_GRUPO_10A
{
    public class Articulos
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [DisplayName("Marca")]
        public Marca IdMarca { get; set; }

        [DisplayName("Categoria")]
        public Categoria IdCategoria { set; get; }

        //public List<Imagen> Imagen { set; get; }

        public decimal Precio { get; set; }
    }
}