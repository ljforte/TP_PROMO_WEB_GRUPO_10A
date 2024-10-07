using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using static System.Net.Mime.MediaTypeNames;

namespace Negocio
{
    public class VoucherNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        private List<Vouchers> list;

        public List<Vouchers> ListarVouchers()
        {
            list = new List<Vouchers>();
            try
            {
                string consulta = @"SELECT CodigoVoucher, IdCliente FROM Vouchers";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Vouchers vou = new Vouchers();
                    vou.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    if (!(datos.Lector["CodigoVoucher"] is DBNull))
                        vou.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    if (!(datos.Lector["IdCliente"] is DBNull))
                        vou.IdCliente = (int)datos.Lector["IdCliente"];
                    list.Add(vou);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    public void CargarRegistro(int id)
    {
        AccesoDatos datos = new AccesoDatos();
        int IdArticulo = 0;

        datos.setearConsulta("insert into Vouchers (IdCliente, FechaCanje. IdArticulo) VALUES (IdCliente, FechaCanje, IdArticulo)"); //+IdArticulo+")")

        datos.setearParametro("@IdCliente", id);
        datos.setearParametro("@FechaCanje", DateTime.Now);
        datos.setearParametro("@IdArticulo", IdArticulo);

        datos.ejecutarAccion();
    }
    }

    public enum ResultadoValidacion
    {
        CodigoErroneo,
        CodigoExitoso,
        CodigoUtilizado
    }

    public class VoucherValidator
    {
        public ResultadoValidacion ValidarVoucherEnLista(List<Vouchers> listaVouchers, string codigoVoucherBuscado)
        {
            int i = 0;
            while (i < listaVouchers.Count)
            {
                if (listaVouchers[i].CodigoVoucher == codigoVoucherBuscado)
                {
                    if (listaVouchers[i].IdCliente != null)
                    {
                        return ResultadoValidacion.CodigoUtilizado;
                    }
                    else
                    {
                        return ResultadoValidacion.CodigoExitoso;
                    }
                }
                i++;
            }

            return ResultadoValidacion.CodigoErroneo;
        }
    }
}


