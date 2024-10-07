using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_PROMO_WEB_GRUPO_10A
{
    public partial class DetalleArticulo : Page
    {
        public List<Dominio.Articulos> listaArticulos;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarArticulos();
            }
        }

        private void CargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.ListarArticulos();
            RepeaterArticulos.DataSource = listaArticulos;
            RepeaterArticulos.DataBind();
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormFelicidades.aspx", false);
        }
    }
}