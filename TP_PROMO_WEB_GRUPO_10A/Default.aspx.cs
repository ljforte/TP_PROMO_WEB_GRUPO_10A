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

        public List<Articulos> listarArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listarArticulos = negocio.ListarArticulos();
            if (!IsPostBack) {
                repRepitidor.DataSource = listarArticulos;
                DataBind();
            }
            
        }

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
            
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}