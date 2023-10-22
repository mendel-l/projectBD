using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winUI
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            groupBox1.AutoSize = true;
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Location = new Point(
                (ClientSize.Width - groupBox1.Width) / 2,
                (ClientSize.Height - groupBox1.Height) / 2);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            formCrearUsuario newform = new formCrearUsuario();
            newform.Show();
            this.Hide();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            formPersona newform = new formPersona();
            newform.Show();
            this.Hide();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            formRol newform = new formRol();
            newform.Show();
            this.Hide();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            formPago newform = new formPago();
            newform.Show();
            this.Hide();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            formCategoria newform = new formCategoria();
            newform.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            formProveedores newform = new formProveedores();
            newform.Show();
            this.Hide();
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            formEmpleado newform = new formEmpleado();
            newform.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            formCliente newform = new formCliente();
            newform.Show();
            this.Hide();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            formVenta newform = new formVenta();
            newform.Show();
            this.Hide();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            formFactura newform = new formFactura();
            newform.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            formProducto newform = new formProducto();
            newform.Show();
            this.Hide();
        }

        private void btnPedidoP_Click(object sender, EventArgs e)
        {
            formPedido newform = new formPedido();
            newform.Show();
            this.Hide();
        }
    }
}
