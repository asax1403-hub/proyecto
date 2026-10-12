using System;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {

        private void ActualizarTotal()
        {
            decimal total = 0;
            string mesa = cmbMesa.SelectedItem.ToString();

            foreach (DataGridViewRow fila in dgvPedidos.Rows)
            {
                if (fila.Cells["colMesa"].Value.ToString() == mesa)
                {
                    decimal precio;

                    if (decimal.TryParse(
                        fila.Cells["colPrecio"].Value.ToString(),
                        out precio))
                    {
                        total += precio;
                    }
                }
            }

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        public Form1()
        {
            InitializeComponent();
            // Inicializar configuración del restaurante (mesas, columnas, etc.)
            ConfigurarRestaurante();
        }

        private void ConfigurarRestaurante()
        {
            cmbMesa.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                cmbMesa.Items.Add("Mesa " + i);
            }

            cmbMesa.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbMesa.SelectedIndex = 0;

            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.ReadOnly = true;
            dgvPedidos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;

            dgvPedidos.Columns.Clear();
            dgvPedidos.Columns.Add("colMesa", "Mesa");
            dgvPedidos.Columns.Add("colProducto", "Producto");
            dgvPedidos.Columns.Add("colPrecio", "Precio");

            lblTotal.Text = "Total: $0.00";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text.Trim();
            decimal precio;

            if (producto == "")
            {
                MessageBox.Show("Escribe el nombre del producto.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio)
                || precio < 0)
            {
                MessageBox.Show("Escribe un precio válido.");
                return;
            }

            string mesa = cmbMesa.SelectedItem.ToString();

            dgvPedidos.Rows.Add(
                mesa,
                producto,
                precio.ToString("0.00")
            );

            txtProducto.Clear();
            txtPrecio.Clear();

            ActualizarTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido.");
                return;
            }

            dgvPedidos.Rows.RemoveAt(
                dgvPedidos.SelectedRows[0].Index
            );

            ActualizarTotal();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            string mesa = cmbMesa.SelectedItem.ToString();
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvPedidos.Rows)
            {
                if (fila.Cells["colMesa"].Value.ToString() == mesa)
                {
                    decimal precio;

                    if (decimal.TryParse(
                        fila.Cells["colPrecio"].Value.ToString(),
                        out precio))
                    {
                        total += precio;
                    }
                }
            }

            if (total == 0)
            {
                MessageBox.Show("La mesa no tiene pedidos.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "Total a cobrar: $" + total.ToString("0.00") +
                "\n¿Deseas confirmar el cobro?",
                "Cobrar cuenta",
                MessageBoxButtons.YesNo
            );

            if (respuesta != DialogResult.Yes)
                return;

            for (int i = dgvPedidos.Rows.Count - 1; i >= 0; i--)
            {
                if (dgvPedidos.Rows[i].Cells["colMesa"].Value.ToString()
                    == mesa)
                {
                    dgvPedidos.Rows.RemoveAt(i);
                }
            }

            ActualizarTotal();

            MessageBox.Show("Cuenta cobrada. Mesa liberada.");
        }

        private void cmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }
    }
}

