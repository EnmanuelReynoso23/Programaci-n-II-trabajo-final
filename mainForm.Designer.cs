namespace Proyecto
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            DGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
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
            lblDate = new Label();
            DTP = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.BackgroundColor = SystemColors.ActiveCaption;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Precio, Stock, Fecha });
            DGV.Location = new Point(13, 296);
            DGV.Margin = new Padding(1);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 102;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(920, 240);
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
            statusStrip1.Location = new Point(0, 567);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(0, 0, 7, 0);
            statusStrip1.Size = new Size(947, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // SSLEstado
            // 
            SSLEstado.Name = "SSLEstado";
            SSLEstado.Size = new Size(77, 20);
            SSLEstado.Text = "SSLEstado";
            // 
            // SSLConteo
            // 
            SSLConteo.Name = "SSLConteo";
            SSLConteo.Size = new Size(57, 20);
            SSLConteo.Text = "Conteo";
            SSLConteo.Click += SSLConteo_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(65, 91);
            lblID.Margin = new Padding(1, 0, 1, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 3;
            lblID.Text = "ID";
            lblID.Click += lblID_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(65, 152);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Location = new Point(673, 552);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 28);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.Location = new Point(813, 552);
            btnLimpiar.Margin = new Padding(1);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 28);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCrear.BackColor = SystemColors.ActiveCaption;
            btnCrear.Location = new Point(507, 211);
            btnCrear.Margin = new Padding(1);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(88, 28);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += BtnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Location = new Point(646, 211);
            btnActualizar.Margin = new Padding(1);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(88, 28);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(130, 212);
            TxtPrecio.Margin = new Padding(1);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(234, 27);
            TxtPrecio.TabIndex = 16;
            TxtPrecio.TextChanged += TxtPrecio_TextChanged;
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Location = new Point(65, 213);
            LblPrecio.Margin = new Padding(1, 0, 1, 0);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(50, 20);
            LblPrecio.TabIndex = 14;
            LblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(411, 89);
            lblStock.Margin = new Padding(1, 0, 1, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock";
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 89);
            txtID.Margin = new Padding(1);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(234, 27);
            txtID.TabIndex = 11;
            txtID.TextChanged += TxtID_TextChanged;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(130, 151);
            TxtNombre.Margin = new Padding(1);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(234, 27);
            TxtNombre.TabIndex = 12;
            TxtNombre.TextChanged += TxtNombre_TextChanged;
            // 
            // TxtStock
            // 
            TxtStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtStock.Location = new Point(487, 89);
            TxtStock.Margin = new Padding(1);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(274, 27);
            TxtStock.TabIndex = 17;
            TxtStock.TextChanged += TxtStock_TextChanged;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(40, 40);
            menuStrip2.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, verToolStripMenuItem, registrosToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(2, 1, 0, 1);
            menuStrip2.Size = new Size(947, 26);
            menuStrip2.TabIndex = 18;
            menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, guardarCrearToolStripMenuItem, actualizarToolStripMenuItem, eliminarToolStripMenuItem, toolStripSeparator1, importarCSVToolStripMenuItem, exportarCSVToolStripMenuItem, imprimirListadoToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(198, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += NuevoToolStripMenuItem_Click;
            // 
            // guardarCrearToolStripMenuItem
            // 
            guardarCrearToolStripMenuItem.Name = "guardarCrearToolStripMenuItem";
            guardarCrearToolStripMenuItem.Size = new Size(198, 26);
            guardarCrearToolStripMenuItem.Text = "Guardar/Crear";
            guardarCrearToolStripMenuItem.Click += GuardarCrearToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(198, 26);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += ActualizarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(198, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += EliminarToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(195, 6);
            // 
            // importarCSVToolStripMenuItem
            // 
            importarCSVToolStripMenuItem.Name = "importarCSVToolStripMenuItem";
            importarCSVToolStripMenuItem.Size = new Size(198, 26);
            importarCSVToolStripMenuItem.Text = "Importar CSV";
            importarCSVToolStripMenuItem.Click += ImportarCSVToolStripMenuItem_Click;
            // 
            // exportarCSVToolStripMenuItem
            // 
            exportarCSVToolStripMenuItem.Name = "exportarCSVToolStripMenuItem";
            exportarCSVToolStripMenuItem.Size = new Size(198, 26);
            exportarCSVToolStripMenuItem.Text = "Exportar CSV";
            exportarCSVToolStripMenuItem.Click += ExportarCSVToolStripMenuItem_Click;
            // 
            // imprimirListadoToolStripMenuItem
            // 
            imprimirListadoToolStripMenuItem.Name = "imprimirListadoToolStripMenuItem";
            imprimirListadoToolStripMenuItem.Size = new Size(198, 26);
            imprimirListadoToolStripMenuItem.Text = "Imprimir listado";
            imprimirListadoToolStripMenuItem.Click += ImprimirListadoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(195, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(198, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarCeldaToolStripMenuItem, copiarFilaComoCSVToolStripMenuItem, limpiarSelecciónToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarCeldaToolStripMenuItem
            // 
            copiarCeldaToolStripMenuItem.Name = "copiarCeldaToolStripMenuItem";
            copiarCeldaToolStripMenuItem.Size = new Size(233, 26);
            copiarCeldaToolStripMenuItem.Text = "Copiar celda";
            copiarCeldaToolStripMenuItem.Click += CopiarCeldaToolStripMenuItem_Click;
            // 
            // copiarFilaComoCSVToolStripMenuItem
            // 
            copiarFilaComoCSVToolStripMenuItem.Name = "copiarFilaComoCSVToolStripMenuItem";
            copiarFilaComoCSVToolStripMenuItem.Size = new Size(233, 26);
            copiarFilaComoCSVToolStripMenuItem.Text = "Copiar fila como CSV";
            copiarFilaComoCSVToolStripMenuItem.Click += CopiarFilaComoCSVToolStripMenuItem_Click;
            // 
            // limpiarSelecciónToolStripMenuItem
            // 
            limpiarSelecciónToolStripMenuItem.Name = "limpiarSelecciónToolStripMenuItem";
            limpiarSelecciónToolStripMenuItem.Size = new Size(233, 26);
            limpiarSelecciónToolStripMenuItem.Text = "Limpiar selección";
            limpiarSelecciónToolStripMenuItem.Click += LimpiarSelecciónToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refrescarToolStripMenuItem, soloConStockToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(44, 24);
            verToolStripMenuItem.Text = "Ver";
            // 
            // refrescarToolStripMenuItem
            // 
            refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            refrescarToolStripMenuItem.Size = new Size(188, 26);
            refrescarToolStripMenuItem.Text = "Refrescar";
            refrescarToolStripMenuItem.Click += RefrescarToolStripMenuItem_Click;
            // 
            // soloConStockToolStripMenuItem
            // 
            soloConStockToolStripMenuItem.Name = "soloConStockToolStripMenuItem";
            soloConStockToolStripMenuItem.Size = new Size(188, 26);
            soloConStockToolStripMenuItem.Text = "Solo con stock";
            soloConStockToolStripMenuItem.Click += SoloConStockToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarSeleccionadoToolStripMenuItem, duplicarSeleccionadoToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(84, 24);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // editarSeleccionadoToolStripMenuItem
            // 
            editarSeleccionadoToolStripMenuItem.Name = "editarSeleccionadoToolStripMenuItem";
            editarSeleccionadoToolStripMenuItem.Size = new Size(239, 26);
            editarSeleccionadoToolStripMenuItem.Text = "Editar seleccionado";
            editarSeleccionadoToolStripMenuItem.Click += EditarSeleccionadoToolStripMenuItem_Click;
            // 
            // duplicarSeleccionadoToolStripMenuItem
            // 
            duplicarSeleccionadoToolStripMenuItem.Name = "duplicarSeleccionadoToolStripMenuItem";
            duplicarSeleccionadoToolStripMenuItem.Size = new Size(239, 26);
            duplicarSeleccionadoToolStripMenuItem.Text = "Duplicar seleccionado";
            duplicarSeleccionadoToolStripMenuItem.Click += DuplicarSeleccionadoToolStripMenuItem_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(411, 152);
            lblDate.Margin = new Padding(1, 0, 1, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(47, 20);
            lblDate.TabIndex = 19;
            lblDate.Text = "Fecha";
            lblDate.Click += label1_Click;
            // 
            // DTP
            // 
            DTP.Checked = false;
            DTP.Location = new Point(487, 151);
            DTP.Margin = new Padding(2, 3, 2, 3);
            DTP.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            DTP.Name = "DTP";
            DTP.Size = new Size(274, 27);
            DTP.TabIndex = 20;
            DTP.ValueChanged += DTP_ValueChanged;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(947, 593);
            Controls.Add(DTP);
            Controls.Add(lblDate);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "mainForm";
            Text = "Gestión de inventario";
            Load += MainForm_Load;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Fecha;
        private DateTimePicker DTP;
        private Label lblDate;
    }
}
