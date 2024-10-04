using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_PROMO_WEB_GRUPO_10A
{
    public class Imagenes
    {
        public int Id { get; set; }

        public int IdArticulo { get; set; }

        public string ImagenUrl { get; set; }

        public override string ToString()
        {
            return ImagenUrl;
        }
    }
}