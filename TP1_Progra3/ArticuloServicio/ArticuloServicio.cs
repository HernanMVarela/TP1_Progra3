using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace ArticuloServicio
{
    public class ArticuloServicio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl as Imagen, A.Precio from ARTICULOS A left join MARCAS M on M.Id = A.IdMarca left join CATEGORIAS C on C.Id = A.IdCategoria");
                datos.LecturaDB();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["A.Codigo"];
                    aux.Nombre = (string)datos.Lector["A.Nombre"];
                    aux.Descripcion = (string)datos.Lector["A.Descripcion"];
                    aux.NomMarca.Nombre = (string)datos.Lector["Descripcion"];
                    aux.NomCategoria.Nombre = (string)datos.Lector["Categoria"];
                    aux.ImagenURL = (string)datos.Lector["Imagen"];
                    aux.Precio = (int)datos.Lector["Precio"];

                    lista.Add(aux);

                    
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


            
        }

    }
}
