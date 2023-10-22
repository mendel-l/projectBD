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
    public partial class formFactura : Form
    {
        public formFactura()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            groupBox1.AutoSize = true;
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Location = new Point(
                (ClientSize.Width - groupBox1.Width) / 2,
                (ClientSize.Height - groupBox1.Height) / 2);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Hide();
        }
    }
}
