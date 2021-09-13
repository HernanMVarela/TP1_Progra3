using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Servicio;


namespace TP1_WinForms
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void DescripcionArt_Load(object sender, EventArgs e)
        {
            marcaServicio serviceMarca = new marcaServicio();
            categoriaServicio serviceCategoria = new categoriaServicio();
            try
            {
                cmbMarca.DataSource = serviceMarca.listaMarcas();
                cmbCategoria.DataSource = serviceCategoria.listaCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
