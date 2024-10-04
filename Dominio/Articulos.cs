﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Articulos
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [DisplayName("Marcas")]
        public Marcas IdMarca { get; set; }

        [DisplayName("Categorias")]
        public Categorias IdCategoria { set; get; }

        //public List<Imagen> Imagen { set; get; }

        public decimal Precio { get; set; }
    }
}