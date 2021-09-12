using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP1_WinForms
{
    public partial class VtnCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        public VtnCatalogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloServicio service = new ArticuloServicio();
            listaArticulos = service.listar();
            dgvTabla.DataSource = listaArticulos;
            dgvTabla.Columns["ImagenURL"].Visible = false;
            dgvTabla.Columns["Id"].Visible = false;
            dgvTabla.Columns["Precio"].Visible = false;
            dgvTabla.Columns["Codigo"].Visible = false;
            dgvTabla.Columns["Descripcion"].Visible = false;
            dgvTabla.AutoResizeColumns();
        }

        private void btnDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void btnDescripcion_Click_1(object sender, EventArgs e)
        {
            Articulo ArtDesc = (Articulo)dgvTabla.CurrentRow.DataBoundItem;
            lblCategoria.Text = "Categoria: " + ArtDesc.Categoria.Nombre;
            lblTitulo.Text = ArtDesc.Nombre;
            lblCodigo.Text = ArtDesc.Codigo;
            lblMarca.Text = "Marca: " + ArtDesc.Marca.Nombre;
            lblDescripcion.Text = "Descripcion: " + ArtDesc.Descripcion;
            lblPrecio.Text = "Precio: " + ArtDesc.Precio;
            try
            {
                pbxFoto.Load(ArtDesc.ImagenURL);
            }
            catch (Exception)
            {
                pbxFoto.Load("https://st4.depositphotos.com/14953852/22772/v/600/depositphotos_227725020-stock-illustration-no-image-available-icon-flat.jpg");
            }
        }
    }
}
