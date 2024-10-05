using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.Text.RegularExpressions;
namespace Negocio
{

    public class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        private List<Articulos> list;
        private ImagenNegocio negImagen = new ImagenNegocio();

        public List<Articulos> ListarArticulos()
        {
            list = new List<Articulos>();
            try {
                string consulta = @"SELECT
                                        A.Id,
                                        A.Codigo, 
                                        A.Nombre, 
                                        A.Descripcion, 
                                        M.Descripcion AS Marca, 
                                        C.Descripcion AS Categoria, 
                                        A.Precio,
                                        M.Id as IdMarca,
                                        C.Id as IdCategoriahttps://http2.mlstatic.com/D_NQ_NP_701613-MLA45464844877_042021-O.webp

                                        FROM ARTICULOS AS A
                                        LEFT JOIN Marcas AS M ON A.IdMarca = M.Id
                                        LEFT JOIN Categorias AS C ON A.IdCategoria = C.Id
                                        ";
                datos.setearConsulta(consulta);

                //datos.setearProcedimiento("storedListar");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos art = new Articulos();
                    art.Id = (int)datos.Lector["id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        art.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        art.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        art.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        art.IdCategoria = new Categorias();
                        art.IdCategoria.Descripcion = (string)datos.Lector["Categoria"];
                        if (!(datos.Lector["idCategoria"] is DBNull))
                            art.IdCategoria.Id = (int)datos.Lector["idCategoria"];
                    }

                    if (!(datos.Lector["Marca"] is DBNull))
                    {
                        art.IdMarca = new Marcas();
                        art.IdMarca.Descripcion = (string)datos.Lector["Marca"];
                        if (!(datos.Lector["idMarca"] is DBNull))
                            art.IdMarca.Id = (int)datos.Lector["idMarca"];
                    }

                    if (!(datos.Lector["Precio"] is DBNull))
                        art.Precio = (decimal)datos.Lector["Precio"];



                    List<Imagenes> img = negImagen.listarImagenes(art.Id);
                    if (img.Count > 0)
                        art.listImagenes = img;
                    list.Add(art);
                }
                return list;
            }
            catch (Exception ex){
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            

        }
    }
}