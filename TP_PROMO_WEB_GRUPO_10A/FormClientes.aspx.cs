using Negocio;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using WebGrease.Css.Ast;
using static Negocio.ClienteNegocio;
using Microsoft.Ajax.Utilities;

namespace TP_PROMO_WEB_GRUPO_10A
{
    public partial class FormClientes : Page
    {
        public List<Clientes> ListaClientes;

        private Clientes nuevoCliente;

        private ClienteNegocio negocio = new ClienteNegocio();
        private void CargarListaCliente()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            ListaClientes = negocio.ListarClientes();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarListaCliente();
                HabilitarTxt(true);
                EsconderTxtValidaciones();
            }

          

        }

        private void EsconderTxtValidaciones()
        {
            lblErrorApellido.Visible = false;
            lblErrorCiudad.Visible = false;
            lblErrorCP.Visible = false;
            lblErrorDireccion.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorEmail.Visible = false;
        }
        private void HabilitarTxt(bool flag)
        {

            txtNombre.ReadOnly = flag;
            txtApellido.ReadOnly = flag;
            txtEmail.ReadOnly = flag;
            txtDireccion.ReadOnly = flag;
            txtCiudad.ReadOnly = flag;


            txtCP.Visible = !flag;
            txtNombre.Visible = !flag;
            txtApellido.Visible = !flag;
            txtEmail.Visible = !flag;
            txtDireccion.Visible = !flag;
            txtCiudad.Visible = !flag;
            txtCP.Visible = !flag;
            btnSiguiente.Visible = !flag;

            lblCP.Visible = !flag;
            lblNombre.Visible = !flag;
            lblApellido.Visible = !flag;
            lblEmail.Visible = !flag;
            lblDireccion.Visible = !flag;
            lblCiudad.Visible = !flag;
            lblCP.Visible = !flag;


        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            bool ok = true;
            EsconderTxtValidaciones();

            VoucherNegocio negocioV = new VoucherNegocio();
            Vouchers voucher = new Vouchers();

            try
            {
                if (txtApellido.Text.IsNullOrWhiteSpace()) {
                    lblErrorApellido.Visible=true;
                    ok = false;
                }
                if (txtCiudad.Text.IsNullOrWhiteSpace())
                {
                    lblErrorCiudad.Visible = true;
                    ok = false;
                }
                if (txtNombre.Text.IsNullOrWhiteSpace())
                {

                    lblErrorNombre.Visible = true;
                    ok = false;
                }
                if (txtDireccion.Text.IsNullOrWhiteSpace())
                {
                    lblErrorDireccion.Visible = true;
                    ok = false;
                }
                if (txtCP.Text.IsNullOrWhiteSpace())
                {
                    lblErrorCP.Visible = true;
                    ok = false;
                }
                if (txtEmail.Text.IsNullOrWhiteSpace())
                {
                    lblErrorEmail.Visible = true;
                    ok = false;
                }

                if (ok)
                {
                    btnSiguiente.Text = "AVANZO";
                    nuevoCliente = new Clientes();
                    ClienteNegocio neg = new ClienteNegocio();
                    //nuevoCliente.Id = int.Parse(txtId.Text);
                    nuevoCliente.Documento = txtDocumento.Text;
                    nuevoCliente.Nombre = txtNombre.Text;
                    nuevoCliente.Apellido = txtApellido.Text;
                    nuevoCliente.Email = txtEmail.Text;
                    nuevoCliente.Ciudad = txtCiudad.Text;
                    nuevoCliente.Direccion = txtDireccion.Text;
                    nuevoCliente.CP = int.Parse(txtCP.Text);
                    neg.Agregar(nuevoCliente);
                    Response.Redirect("Default.aspx", false);
                   
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
    
            //Siguiente Pantalla


        }

        protected void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            ClienteNegocio neg = new ClienteNegocio();
            List<Clientes> listCliente = new List<Clientes>();
            Clientes aux = neg.buscarID(txtDocumento.Text);

            if (aux!=null)
            {

                txtApellido.Text = aux.Apellido;
                txtNombre.Text = aux.Nombre;
                txtEmail.Text =aux.Email;
                txtDireccion.Text = aux.Direccion;
                txtCiudad.Text = aux.Ciudad;
                txtCP.Text = Convert.ToString(aux.CP);


                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtCiudad.ReadOnly = true;
                txtCP.ReadOnly = true;

                nuevoCliente = aux;

            }
            else {
                txtApellido.Text = " ";
                txtNombre.Text = " ";
                txtEmail.Text =" ";
                txtDireccion.Text = " ";
                txtCiudad.Text = " ";
                txtCP.Text = " ";

                txtNombre.ReadOnly = false;
                txtApellido.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtDireccion.ReadOnly = false;
                txtCiudad.ReadOnly = false;
                txtCP.ReadOnly = false;

            }


        }

        protected void ValidarDni_Click(object sender, EventArgs e)
        {
            string dni=txtDocumento.Text;

       

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                lblResultadoDni.Text = "Ingresa Dni";
                HabilitarTxt(true);
            }
            else if (negocio.buscarID(dni) == null)
            {
                lblResultadoDni.Text = "Carga tus datos";
                HabilitarTxt(false);
            }
            else {
                lblResultadoDni.Text = "El Dni ya se encuentra cargado";
                HabilitarTxt(false);
                txtNombre.ReadOnly = false;
                txtApellido.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtDireccion.ReadOnly = false;
                txtCiudad.ReadOnly = false;
                txtCP.ReadOnly = false;
            }

        }
    }
}