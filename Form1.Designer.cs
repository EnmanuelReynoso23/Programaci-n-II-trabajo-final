namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            SSLEstado = new ToolStripStatusLabel();
            SSLConteo = new ToolStripStatusLabel();
            lblID = new Label();
            lblNombre = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnCrear = new Button();
            btnActualizar = new Button();
            TxtPrecio = new TextBox();
            LblPrecio = new Label();
            lblStock = new Label();
            txtID = new TextBox();
            TxtNombre = new TextBox();
            TxtStock = new TextBox();
            menuStrip2 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarCrearToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            importarCSVToolStripMenuItem = new ToolStripMenuItem();
            exportarCSVToolStripMenuItem = new ToolStripMenuItem();
            imprimirListadoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarCeldaToolStripMenuItem = new ToolStripMenuItem();
            copiarFilaComoCSVToolStripMenuItem = new ToolStripMenuItem();
            limpiarSelecciónToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            refrescarToolStripMenuItem = new ToolStripMenuItem();
            soloConStockToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            editarSeleccionadoToolStripMenuItem = new ToolStripMenuItem();
            duplicarSeleccionadoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.BackgroundColor = SystemColors.ActiveCaption;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripcion, Precio, Stock, Fecha });
            DGV.Location = new Point(26, 607);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 102;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(1954, 492);
            DGV.TabIndex = 0;
            DGV.CellContentClick += DGV_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 12;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 12;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 12;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 12;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 12;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 12;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(40, 40);
            statusStrip1.Items.AddRange(new ToolStripItem[] { SSLEstado, SSLConteo });
            statusStrip1.Location = new Point(0, 1279);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2014, 54);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // SSLEstado
            // 
            SSLEstado.Name = "SSLEstado";
            SSLEstado.Size = new Size(153, 41);
            SSLEstado.Text = "SSLEstado";
            // 
            // SSLConteo
            // 
            SSLConteo.Name = "SSLConteo";
            SSLConteo.Size = new Size(116, 41);
            SSLConteo.Text = "Conteo";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(138, 186);
            lblID.Name = "lblID";
            lblID.Size = new Size(47, 41);
            lblID.TabIndex = 3;
            lblID.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(138, 311);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 41);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Location = new Point(1430, 1132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 58);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.Location = new Point(1726, 1132);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(188, 58);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ActiveCaption;
            btnCrear.Location = new Point(1024, 322);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(188, 58);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Location = new Point(1318, 322);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(188, 58);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(277, 435);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(493, 47);
            TxtPrecio.TabIndex = 16;
            TxtPrecio.TextChanged += TxtPrecio_TextChanged;
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Location = new Point(138, 438);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(100, 41);
            LblPrecio.TabIndex = 14;
            LblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(861, 186);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(90, 41);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock";
            // 
            // txtID
            // 
            txtID.Location = new Point(277, 183);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(493, 47);
            txtID.TabIndex = 11;
            txtID.TextChanged += TxtID_TextChanged;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(277, 308);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(493, 47);
            TxtNombre.TabIndex = 12;
            TxtNombre.TextChanged += TxtNombre_TextChanged;
            // 
            // TxtStock
            // 
            TxtStock.Location = new Point(1023, 186);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(493, 47);
            TxtStock.TabIndex = 17;
            TxtStock.TextChanged += TxtStock_TextChanged;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(40, 40);
            menuStrip2.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, verToolStripMenuItem, registrosToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(2014, 52);
            menuStrip2.TabIndex = 18;
            menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, guardarCrearToolStripMenuItem, actualizarToolStripMenuItem, eliminarToolStripMenuItem, toolStripSeparator1, importarCSVToolStripMenuItem, exportarCSVToolStripMenuItem, imprimirListadoToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(141, 48);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(392, 54);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // guardarCrearToolStripMenuItem
            // 
            guardarCrearToolStripMenuItem.Name = "guardarCrearToolStripMenuItem";
            guardarCrearToolStripMenuItem.Size = new Size(392, 54);
            guardarCrearToolStripMenuItem.Text = "Guardar/Crear";
            guardarCrearToolStripMenuItem.Click += guardarCrearToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(392, 54);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(392, 54);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(389, 6);
            // 
            // importarCSVToolStripMenuItem
            // 
            importarCSVToolStripMenuItem.Name = "importarCSVToolStripMenuItem";
            importarCSVToolStripMenuItem.Size = new Size(392, 54);
            importarCSVToolStripMenuItem.Text = "Importar CSV";
            importarCSVToolStripMenuItem.Click += importarCSVToolStripMenuItem_Click;
            // 
            // exportarCSVToolStripMenuItem
            // 
            exportarCSVToolStripMenuItem.Name = "exportarCSVToolStripMenuItem";
            exportarCSVToolStripMenuItem.Size = new Size(392, 54);
            exportarCSVToolStripMenuItem.Text = "Exportar CSV";
            exportarCSVToolStripMenuItem.Click += exportarCSVToolStripMenuItem_Click;
            // 
            // imprimirListadoToolStripMenuItem
            // 
            imprimirListadoToolStripMenuItem.Name = "imprimirListadoToolStripMenuItem";
            imprimirListadoToolStripMenuItem.Size = new Size(392, 54);
            imprimirListadoToolStripMenuItem.Text = "Imprimir listado";
            imprimirListadoToolStripMenuItem.Click += imprimirListadoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(389, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(392, 54);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarCeldaToolStripMenuItem, copiarFilaComoCSVToolStripMenuItem, limpiarSelecciónToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 48);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarCeldaToolStripMenuItem
            // 
            copiarCeldaToolStripMenuItem.Name = "copiarCeldaToolStripMenuItem";
            copiarCeldaToolStripMenuItem.Size = new Size(463, 54);
            copiarCeldaToolStripMenuItem.Text = "Copiar celda";
            copiarCeldaToolStripMenuItem.Click += copiarCeldaToolStripMenuItem_Click;
            // 
            // copiarFilaComoCSVToolStripMenuItem
            // 
            copiarFilaComoCSVToolStripMenuItem.Name = "copiarFilaComoCSVToolStripMenuItem";
            copiarFilaComoCSVToolStripMenuItem.Size = new Size(463, 54);
            copiarFilaComoCSVToolStripMenuItem.Text = "Copiar fila como CSV";
            copiarFilaComoCSVToolStripMenuItem.Click += copiarFilaComoCSVToolStripMenuItem_Click;
            // 
            // limpiarSelecciónToolStripMenuItem
            // 
            limpiarSelecciónToolStripMenuItem.Name = "limpiarSelecciónToolStripMenuItem";
            limpiarSelecciónToolStripMenuItem.Size = new Size(463, 54);
            limpiarSelecciónToolStripMenuItem.Text = "Limpiar selección";
            limpiarSelecciónToolStripMenuItem.Click += limpiarSelecciónToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refrescarToolStripMenuItem, soloConStockToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(85, 48);
            verToolStripMenuItem.Text = "Ver";
            // 
            // refrescarToolStripMenuItem
            // 
            refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            refrescarToolStripMenuItem.Size = new Size(378, 54);
            refrescarToolStripMenuItem.Text = "Refrescar";
            refrescarToolStripMenuItem.Click += refrescarToolStripMenuItem_Click;
            // 
            // soloConStockToolStripMenuItem
            // 
            soloConStockToolStripMenuItem.Name = "soloConStockToolStripMenuItem";
            soloConStockToolStripMenuItem.Size = new Size(378, 54);
            soloConStockToolStripMenuItem.Text = "Solo con stock";
            soloConStockToolStripMenuItem.Click += soloConStockToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarSeleccionadoToolStripMenuItem, duplicarSeleccionadoToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(164, 48);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // editarSeleccionadoToolStripMenuItem
            // 
            editarSeleccionadoToolStripMenuItem.Name = "editarSeleccionadoToolStripMenuItem";
            editarSeleccionadoToolStripMenuItem.Size = new Size(474, 54);
            editarSeleccionadoToolStripMenuItem.Text = "Editar seleccionado";
            editarSeleccionadoToolStripMenuItem.Click += editarSeleccionadoToolStripMenuItem_Click;
            // 
            // duplicarSeleccionadoToolStripMenuItem
            // 
            duplicarSeleccionadoToolStripMenuItem.Name = "duplicarSeleccionadoToolStripMenuItem";
            duplicarSeleccionadoToolStripMenuItem.Size = new Size(474, 54);
            duplicarSeleccionadoToolStripMenuItem.Text = "Duplicar seleccionado";
            duplicarSeleccionadoToolStripMenuItem.Click += duplicarSeleccionadoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2014, 1333);
            Controls.Add(TxtStock);
            Controls.Add(TxtPrecio);
            Controls.Add(LblPrecio);
            Controls.Add(lblStock);
            Controls.Add(TxtNombre);
            Controls.Add(txtID);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(lblNombre);
            Controls.Add(lblID);
            Controls.Add(statusStrip1);
            Controls.Add(DGV);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private ErrorProvider errorProvider1;
        private StatusStrip statusStrip1;
        private Label lblNombre;
        private Label lblID;
        private ToolStripStatusLabel SSLEstado;
        private ToolStripStatusLabel SSLConteo;
        private Button btnActualizar;
        private Button btnCrear;
        private Button btnLimpiar;
        private Button btnEliminar;
        private TextBox TxtPrecio;
        private Label LblPrecio;
        private Label lblStock;
        private TextBox TxtStock;
        private TextBox TxtNombre;
        private TextBox txtID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Fecha;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarCrearToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem importarCSVToolStripMenuItem;
        private ToolStripMenuItem exportarCSVToolStripMenuItem;
        private ToolStripMenuItem imprimirListadoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarCeldaToolStripMenuItem;
        private ToolStripMenuItem copiarFilaComoCSVToolStripMenuItem;
        private ToolStripMenuItem limpiarSelecciónToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem refrescarToolStripMenuItem;
        private ToolStripMenuItem soloConStockToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem editarSeleccionadoToolStripMenuItem;
        private ToolStripMenuItem duplicarSeleccionadoToolStripMenuItem;
    }
}
