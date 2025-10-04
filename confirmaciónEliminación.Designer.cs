namespace Proyecto
{
    partial class confirmaciónEliminación
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
            labelConfirmacion = new Label();
            buttonConfirmar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // labelConfirmacion
            // 
            labelConfirmacion.AutoSize = true;
            labelConfirmacion.Font = new Font("Segoe UI", 14F);
            labelConfirmacion.Location = new Point(12, 50);
            labelConfirmacion.Name = "labelConfirmacion";
            labelConfirmacion.Size = new Size(372, 25);
            labelConfirmacion.TabIndex = 0;
            labelConfirmacion.Text = "¿Seguro que deseas eliminar este registro?";
            labelConfirmacion.Click += label1_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(12, 133);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(186, 62);
            buttonConfirmar.TabIndex = 1;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(223, 133);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(161, 62);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // confirmaciónEliminación
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 304);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonConfirmar);
            Controls.Add(labelConfirmacion);
            Name = "confirmaciónEliminación";
            Text = "confirmaciónEliminación";
            Load += confirmaciónEliminación_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelConfirmacion;
        private Button buttonConfirmar;
        private Button buttonCancelar;
    }
}