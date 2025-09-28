using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Npgsql;
using System.Globalization;
using System.Drawing.Printing;

namespace Proyecto
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text) && !int.TryParse(txtID.Text, out _))
                SSLEstado.Text = "ID inválido, debe ser numérico";
            else
                SSLEstado.Text = "";
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            SSLEstado.Text = string.IsNullOrWhiteSpace(TxtNombre.Text) ? "El nombre es obligatorio" : "";
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtPrecio.Text))
            {
                if (!decimal.TryParse(TxtPrecio.Text, out var p) || p <= 0)
                    SSLEstado.Text = "Precio inválido";
                else
                    SSLEstado.Text = "";
            }
            else SSLEstado.Text = "";
        }

        private void TxtStock_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtStock.Text))
            {
                if (!int.TryParse(TxtStock.Text, out var s) || s < 0)
                    SSLEstado.Text = "Stock inválido";
                else
                    SSLEstado.Text = "";
            }
            else SSLEstado.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }
            if (!decimal.TryParse(TxtPrecio.Text, out var precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido. Debe ser un número mayor que 0.");
                return;
            }
            if (!int.TryParse(TxtStock.Text, out var stock) || stock < 0)
            {
                MessageBox.Show("Stock inválido. Debe ser un entero, mayor o igual a 0.");
                return;
            }

            DGV.Rows.Add(txtID.Text, TxtNombre.Text.Trim(), precio.ToString("0.##"), stock.ToString());
            SSLEstado.Text = "Producto creado";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow == null || DGV.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione una fila para actualizar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }
            if (!decimal.TryParse(TxtPrecio.Text, out var precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido. Debe ser un número mayor que 0.");
                return;
            }
            if (!int.TryParse(TxtStock.Text, out var stock) || stock < 0)
            {
                MessageBox.Show("Stock inválido. Debe ser un entero ≥ 0.");
                return;
            }

            DGV.CurrentRow.Cells[0].Value = txtID.Text;
            DGV.CurrentRow.Cells[1].Value = TxtNombre.Text.Trim();
            DGV.CurrentRow.Cells[2].Value = precio.ToString("0.##");
            DGV.CurrentRow.Cells[3].Value = stock.ToString();

            SSLEstado.Text = "Producto actualizado";
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = DGV.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value?.ToString();
            TxtNombre.Text = row.Cells[1].Value?.ToString();
            TxtPrecio.Text = row.Cells[2].Value?.ToString();
            TxtStock.Text = row.Cells[3].Value?.ToString();

            SSLEstado.Text = "Fila cargada";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                DGV.Rows.Remove(DGV.CurrentRow);
                SSLEstado.Text = "Producto eliminado";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            TxtNombre.Clear();
            TxtPrecio.Clear();
            TxtStock.Clear();
            DGV.ClearSelection();
            SSLEstado.Text = "Formulario limpio";
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear(); TxtNombre.Clear(); TxtPrecio.Clear(); TxtStock.Clear();
            SSLEstado.Text = "Nuevo registro";
            TxtNombre.Focus();

        }

        private void guardarCrearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminar.PerformClick();
        }

        private void importarCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV|*.csv";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string line in File.ReadAllLines(ofd.FileName))
                    {
                        string[] data = line.Split(',');
                        DGV.Rows.Add(data);
                    }
                    SSLEstado.Text = "CSV importado";
                }
            }
        }

        private void exportarCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV|*.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (DataGridViewRow row in DGV.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "");
                                sw.WriteLine(string.Join(",", cells));
                            }
                        }
                    }
                    SSLEstado.Text = "CSV exportado";
                }
            }
        }

        private void imprimirListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDoc = new PrintDocument();
                SSLEstado.Text = "Enviando a impresora...";
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem.Enabled = false;
            Application.Exit();
        }

        private void copiarCeldaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentCell != null)
                Clipboard.SetText(DGV.CurrentCell.Value?.ToString() ?? "");
        }

        private void copiarFilaComoCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                var cells = DGV.CurrentRow.Cells.Cast<DataGridViewCell>()
                             .Select(c => c.Value?.ToString() ?? "");
                Clipboard.SetText(string.Join(",", cells));
            }
        }

        private void limpiarSelecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV.ClearSelection();
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV.Refresh();
            SSLEstado.Text = "Vista actualizada";
        }

        private void soloConStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                if (row.IsNewRow) continue;
                var val = row.Cells[3].Value?.ToString();
                if (!int.TryParse(val, out var stk)) stk = 0;
                row.Visible = stk > 0;
            }

            SSLEstado.Text = "Mostrando solo con stock";
        }

        private void editarSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                txtID.Text = DGV.CurrentRow.Cells[0].Value?.ToString();
                TxtNombre.Text = DGV.CurrentRow.Cells[1].Value?.ToString();
                TxtPrecio.Text = DGV.CurrentRow.Cells[2].Value?.ToString();
                TxtStock.Text = DGV.CurrentRow.Cells[3].Value?.ToString();
                SSLEstado.Text = "Editando registro";
            }
        }

        private void duplicarSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                var cells = DGV.CurrentRow.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "").ToArray();
                DGV.Rows.Add(cells);
                SSLEstado.Text = "Registro duplicado";
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
