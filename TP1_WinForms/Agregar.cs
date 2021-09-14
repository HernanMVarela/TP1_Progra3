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
                cargar_imagen(txtURLImagen.Text);
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

        private void cargar_imagen(string texto)
        {
            try
            {
                pbxImagen.Load(texto);
            }
            catch (Exception)
            {
                pbxImagen.Load("https://st4.depositphotos.com/14953852/22772/v/600/depositphotos_227725020-stock-illustration-no-image-available-icon-flat.jpg");
            }
            
        }

        private void txtURLImagen_TextChanged(object sender, EventArgs e)
        {
            cargar_imagen(txtURLImagen.Text);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text == "")
                txbNombre.BackColor = Color.Red;
            else
                txbNombre.BackColor = System.Drawing.SystemColors.Control;
            if (txbCodigo.Text == "")
                txbCodigo.BackColor = Color.Red;
            else
                txbCodigo.BackColor = System.Drawing.SystemColors.Control;
            if (txbCodigo.Text != "" && txbNombre.Text != "")
            {
                Articulo nuevo = new Articulo();
                ArticuloServicio newServicio = new ArticuloServicio();
                try
                {
                    nuevo.Nombre = txbNombre.Text;
                    nuevo.Descripcion = txbDescripcion.Text;
                    nuevo.Codigo = txbCodigo.Text;
                    nuevo.Categoria = (categoria)cmbCategoria.SelectedItem;
                    nuevo.Marca = (marca)cmbMarca.SelectedItem;
                    nuevo.ImagenURL = txtURLImagen.Text;
                    nuevo.Precio = txtPrecio.Text;

                    newServicio.AgregarDB(nuevo);
                    MessageBox.Show("Articulo agregado!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw ex;
                }
            }
        }
    }
}
