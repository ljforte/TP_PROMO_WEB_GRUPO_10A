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

namespace TP_PROMO_WEB_GRUPO_10A
{
    public partial class FormClientes : Page
    {
        private Clientes nuevoCliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HabilitarTxt(false);
                

            }
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

            try
            {
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
                
                
                nuevoCliente = aux;

            }
            else {
                txtApellido.Text = " ";
                txtNombre.Text = " ";
                txtEmail.Text =" ";
                txtDireccion.Text = " ";
                txtCiudad.Text = " ";
                txtCP.Text = " ";
                               
            }


        }
   
    }
}

