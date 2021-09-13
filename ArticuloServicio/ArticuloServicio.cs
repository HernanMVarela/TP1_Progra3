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
                datos.SetearComando("select A.id, A.Codigo, A.Nombre, A.Descripcion, coalesce(M.Descripcion,'Sin Marca') as Marca, coalesce(C.Descripcion,'Sin categoria') as Categoria, A.ImagenUrl as Imagen, A.Precio from ARTICULOS A left join MARCAS M on M.Id = A.IdMarca left join CATEGORIAS C on C.Id = A.IdCategoria");
                datos.LecturaDB();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new marca();
                    aux.Categoria = new categoria();
                    aux.Marca.Nombre = (string)datos.Lector["Marca"];
                    aux.Categoria.Nombre = (string)datos.Lector["Categoria"];
                    aux.ImagenURL = (string)datos.Lector["Imagen"];
                    decimal p =(decimal)datos.Lector["Precio"];
                    decimal pr = Math.Round(p, 2);
                    aux.Precio = "$ " + pr.ToString();

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

        public void AgregarDB()
        {
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("");
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
