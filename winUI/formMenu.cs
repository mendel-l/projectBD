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
            //cambiar el nombre del forma al cual se va a direccionar
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            //cambiar el nombre del forma al cual se va a direccionar
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            //cambiar el nombre del forma al cual se va a direccionar
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //cambiar el nombre del forma al cual se va a direccionar
            formMenu newform = new formMenu();
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
    }
}
