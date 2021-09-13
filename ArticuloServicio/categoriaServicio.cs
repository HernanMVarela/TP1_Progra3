using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Windows.Forms;

namespace Servicio
{
    class categoriaServicio
    {
        public List<categoria> listaCategorias()
        {
            List<categoria> listaCategorias = new List<categoria>();
            AccesoDB datos = new AccesoDB();

            try
            {
                datos.SetearComando("select Id, Descripcion from CATEGORIA");
                datos.LecturaDB();
                while (datos.Lector.Read())
                {
                    categoria aux = new categoria();
                    aux.Id = (int)datos.Lector["Id"];

                    // if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Descripcion"];
                    listaCategorias.Add(aux);
                }

                return listaCategorias;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }
    
    
    
    }
}
