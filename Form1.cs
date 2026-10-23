using System.ComponentModel;

namespace CAFETERIA
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Producto> productos = new();
        private readonly BindingList<Pedido> pedidos = new();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnVaciar.Click += btnVaciar_Click;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Text = "Pedidos Cafetería";


            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPrecio.ReadOnly = true;
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 10;
            nudCantidad.Value = 1;
            chkParaLlevar.Text = "Para llevar (+ $5 por pedido)";

            dgvPedidos.ReadOnly = true;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.MultiSelect = false;

            productos.Add(new Producto("Café", 30m));
            productos.Add(new Producto("Té", 25m));
            productos.Add(new Producto("Sándwich", 55m));
            productos.Add(new Producto("Galletas", 20m));

            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.DataSource = productos;
            cmbProducto.SelectedIndex = -1;   

            dgvPedidos.DataSource = pedidos;
            dgvPedidos.Columns["ParaLlevar"].HeaderText = "Para llevar";
            dgvPedidos.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ActualizarTotal();
        }

        private void cmbProducto_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is Producto p)
                txtPrecio.Text = p.Precio.ToString("C2");
            else
                txtPrecio.Clear();
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)nudCantidad.Value;  
            pedidos.Add(new Pedido(producto, cantidad, chkParaLlevar.Checked));

            ActualizarTotal();

        
            nudCantidad.Value = 1;
            chkParaLlevar.Checked = false;
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0 ||
                dgvPedidos.SelectedRows[0].DataBoundItem is not Pedido pedido)
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            pedidos.Remove(pedido);
            ActualizarTotal();
        }

        private void btnVaciar_Click(object? sender, EventArgs e)
        {
            if (pedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos que eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var r = MessageBox.Show("¿Deseas eliminar todos los pedidos?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                pedidos.Clear();
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = pedidos.Sum(p => p.Subtotal);
            lblTotal.Text = $"TOTAL: {total:C2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
