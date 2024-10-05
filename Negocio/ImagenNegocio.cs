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
    public class ImagenNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        private List<Imagenes> list;

        public List<Imagenes> listarImagenes(int id)
        {
            list = new List<Imagenes>();
            
            datos.setearConsulta("select i.id,i.imagenUrl,a.Id articulo from imagenes i, articulos a where a.Id=i.IdArticulo");
            try
            {
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    int idArticulo = (int)datos.Lector["articulo"];
                    if (idArticulo == id)
                    {
                        Imagenes img = new Imagenes();
                        img.Id = (int)datos.Lector["id"];
                        img.IdArticulo = idArticulo;
                        img.ImagenUrl = (string)datos.Lector["imagenUrl"];
                        list.Add(img);
                    }
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
    }
}