using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using Microsoft.Ajax.Utilities;

namespace TP_PROMO_WEB_GRUPO_10A
{
    public partial class _Default : Page
    {
        private List<Vouchers> listaVouchers;

        public List<Articulos> listarArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            CargarListaVouchers();
            
        }

        private void CargarListaVouchers()
        {
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            listaVouchers = voucherNegocio.ListarVouchers();
        }
        protected void btnValidar_Click(object sender, EventArgs e)
        {

            string codigo = txtCodigoVoucher.Text;
            VoucherValidator validador= new VoucherValidator();

            ResultadoValidacion resultado = validador.ValidarVoucherEnLista(listaVouchers,codigo);

            switch(resultado)
            {
                case ResultadoValidacion.CodigoErroneo:
                    //lblResultado.Text = "El código ingresado es erróneo.";
                    Response.Redirect("Clientes.aspx");
                    break;

                case ResultadoValidacion.CodigoExitoso:
                    Response.Redirect("Articulos.aspx");
                    break;

                case ResultadoValidacion.CodigoUtilizado:
                    //lblResultado.Text = "El código ha sido utilizado anteriormente.";
                    Response.Redirect("DetalleArticulo.aspx");
                    break;
            }
        }
    }
}