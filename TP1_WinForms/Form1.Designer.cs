
namespace TP1_WinForms
{
    partial class VtnCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTabla.Location = new System.Drawing.Point(9, 132);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(362, 354);
            this.dgvTabla.TabIndex = 0;
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(544, 500);
            this.btnDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(146, 37);
            this.btnDescripcion.TabIndex = 0;
            this.btnDescripcion.Text = "Ver Descripcion";
            this.btnDescripcion.UseVisualStyleBackColor = true;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(458, 67);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 23);
            this.lblTitulo.TabIndex = 3;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(461, 132);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(318, 262);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 4;
            this.pbxFoto.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(458, 401);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 16);
            this.lblDescripcion.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(458, 432);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 16);
            this.lblMarca.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(611, 432);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 16);
            this.lblCategoria.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(458, 105);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 16);
            this.lblCodigo.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(457, 468);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 23);
            this.lblPrecio.TabIndex = 9;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Arial Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.Location = new System.Drawing.Point(9, 7);
            this.lblCatalogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(337, 31);
            this.lblCatalogo.TabIndex = 10;
            this.lblCatalogo.Text = "CATALOGO DE ARTICULOS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 500);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(257, 500);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 37);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(141, 500);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 37);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(307, 84);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 28);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(66, 89);
            this.txbBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(108, 20);
            this.txbBuscar.TabIndex = 12;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Marca",
            "Categoria"});
            this.cbxBuscar.Location = new System.Drawing.Point(199, 89);
            this.cbxBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(92, 21);
            this.cbxBuscar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "en";
            // 
            // VtnCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.dgvTabla);
            this.Name = "VtnCatalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

