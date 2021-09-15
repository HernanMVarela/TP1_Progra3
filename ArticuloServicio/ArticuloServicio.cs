using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;


namespace Servicio
{
    public class ArticuloServicio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("select A.id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl as Imagen, A.Precio, M.Id as IdMarca, C.Id as IdCategoria from ARTICULOS A left join MARCAS M on M.Id = A.IdMarca left join CATEGORIAS C on C.Id = A.IdCategoria");
                datos.LecturaDB();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    {
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    }
                    if (!(datos.Lector["Marca"] is DBNull))
                    {
                        aux.Marca = new marca();
                        aux.Marca.Nombre = (string)datos.Lector["Marca"];
                        aux.Marca.Id = (int)datos.Lector["idMarca"];
                    }
                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria = new categoria();
                        aux.Categoria.Nombre = (string)datos.Lector["Categoria"];
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    }
                    
                    if (!(datos.Lector["Precio"] is DBNull))
                    {
                        decimal p = (decimal)datos.Lector["Precio"];
                        decimal pr = Math.Round(p, 2);
                        aux.Precio = pr;
                    }
                    
                    aux.ImagenURL = (string)datos.Lector["Imagen"];
                    

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void AgregarDB(Articulo nuevo)
        {
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("insert into Articulos (Codigo, Nombre, Descripcion, idMarca, IdCategoria, ImagenUrl, Precio) values ('" + nuevo.Codigo +"','" + nuevo.Nombre + "','"+ nuevo.Descripcion + "'," + nuevo.Marca.Id + "," + nuevo.Categoria.Id + ",'" + nuevo.ImagenURL + "'," + nuevo.Precio +");");
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }

        }

        public void ModificarDB(Articulo modify)
        {
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("update Articulos set Codigo='"+modify.Codigo+"', Nombre='"+modify.Nombre+"', Descripcion='"+modify.Descripcion+"', idMarca="+modify.Marca.Id+", IdCategoria="+modify.Categoria.Id+", ImagenUrl='"+modify.ImagenURL+"', Precio="+(float)modify.Precio+"where Id="+modify.Id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw ex;
            }



        }

        public void BorrarDB(Articulo borrarArt)
        {
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("delete from ARTICULOS where ID = " + borrarArt.Id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw ex;
            }

        }

    }
}
