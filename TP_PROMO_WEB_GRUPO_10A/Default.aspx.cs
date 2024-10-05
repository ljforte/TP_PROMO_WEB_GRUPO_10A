using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TP_PROMO_WEB_GRUPO_10A
{
    public partial class _Default : Page
    {

        public List<Articulos> listarPokemon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listarPokemon = negocio.ListarArticulos();
            
        }

    }
}