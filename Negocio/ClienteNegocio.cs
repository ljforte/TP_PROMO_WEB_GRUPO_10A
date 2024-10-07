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
    public class ClienteNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        private Clientes _cliente;
        string consulta;

        public ClienteNegocio() {
            consulta = @"SELECT
                            c.Id,
                            c.Documento,
	                        c.Nombre,
	                        c.Apellido,
	                        c.Email,
	                        c.Direccion,
	                        c.Ciudad,
	                        c.CP
                            FROM Clientes AS c
                                        ";
        }

        public Clientes buscarID(string doc)
        {
            _cliente = null;
            try
            {
                

                datos.setearConsulta (@"SELECT
                            c.Id,
                            c.Documento,
	                        c.Nombre,
	                        c.Apellido,
	                        c.Email,
	                        c.Direccion,
	                        c.Ciudad,
	                        c.CP
                            FROM Clientes AS c
                            where c.Documento = '" + doc + "'");

                //datos.setearParametro("@Documento", doc);
                datos.ejecutarLectura();
                if (datos.Lector.Read()) {
                    _cliente = new Clientes();
                    _cliente.Id = (int)datos.Lector.GetInt32(0);

                    _cliente.Documento = (string)datos.Lector["Documento"];
                    
                    _cliente.Nombre = (string)datos.Lector["Nombre"];
                    
                    _cliente.Apellido = (string)datos.Lector["Apellido"];

                    _cliente.Email = (string)datos.Lector["Email"];
                    _cliente.Direccion = (string)datos.Lector["Direccion"];

                    _cliente.Ciudad = (string)datos.Lector["Ciudad"];
                    
                    _cliente.CP = (int)datos.Lector["CP"];

                    return _cliente;
                }
                return _cliente;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al obtener el Cliente por Doc.", ex);
            }
            finally { datos.cerrarConexion(); }





        }

        public List<Clientes> ListarClientes() { 
        List<Clientes> listClientes = new List<Clientes>();
            try {
                string consultaSQL = @"SELECT
                            Id,
                            Documento,
	                        Nombre,
	                        Apellido,
	                        Email,
	                        Direccion,
	                        Ciudad,
	                        CP
                            FROM Clientes
                                        ";
                datos.setearConsulta(consultaSQL);
                datos.ejecutarLectura();


                while (datos.Lector.Read()) { 
                    Clientes cliente = new Clientes();
                    if (!(datos.Lector["Id"] is DBNull))
                        cliente.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Documento"] is DBNull))
                        cliente.Documento = (string)datos.Lector["Documento"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        cliente.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Apellido"] is DBNull))
                        cliente.Apellido = (string)datos.Lector["Apellido"];
                    if (!(datos.Lector["Email"] is DBNull))
                        cliente.Email = (string)datos.Lector["Email"];
                    if (!(datos.Lector["Direccion"] is DBNull))
                        cliente.Direccion = (string)datos.Lector["Direccion"];
                    if (!(datos.Lector["Ciudad"] is DBNull))
                        cliente.Ciudad = (string)datos.Lector["Ciudad"];
                    if (!(datos.Lector["CP"] is DBNull))
                        cliente.CP = (int)datos.Lector["CP"];
                    listClientes.Add(cliente);
                }
                return listClientes;
            }
            catch (Exception ex){ throw ex; }
            finally {
                datos.cerrarConexion();
            }
        }

        public int ConsultarId(string dni)
        {
            int id=0;
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("Select id from CLIENTES where Documento = '" + dni + "'");
            datos.ejecutarLectura();

            if (datos.Lector.Read())
            {
                id = (int)datos.Lector["Id"];
            }
            return id;
        }

        public void Agregar(Clientes nuevo) {
            try
            {
                datos.setearConsulta("insert into Clientes (Documento,Nombre,Apellido,Email,Direccion,Ciudad,CP) " +

                    "VALUES ('" + nuevo.Documento + "', '" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.Email + "', '" + nuevo.Direccion + "', '" + nuevo.Ciudad + "', '" + nuevo.CP + "')");


              
                datos.setearParametro("@Documento", nuevo.Documento);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@Direccion", nuevo.Direccion);
                datos.setearParametro("@Ciudad", nuevo.Ciudad);
                datos.setearParametro("@CP", nuevo.CP);
                datos.ejecutarAccion();
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

    }
        public enum ValidacionDNI
        {
            dniCargado,
            dniNoCargado,
            error
        }

        public class DniValidador
        {
            public ValidacionDNI ValidacionDniEnLista(List<Clientes> listaClientes, string dniBuscado)
            {
                int i = 0;

            if(listaClientes == null)
            {
                return ValidacionDNI.error;
            }

                foreach (var item in listaClientes)
                {
                    if (item.Documento == dniBuscado)
                    {
                        return ValidacionDNI.dniCargado;
                    }
                }
                return ValidacionDNI.dniNoCargado;
            
        }


    }
}