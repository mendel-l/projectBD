using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Text;

using BLL;
namespace winUI
{
    public partial class Form1 : Form
    {
        ClassLogicaUsuario autentication = new ClassLogicaUsuario(); //se crea un objeto 
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            groupBox1.AutoSize = true;
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Location = new Point(
                (ClientSize.Width - groupBox1.Width) / 2,
                (ClientSize.Height - groupBox1.Height) / 2);
        }

        private bool dragging = false;
        private bool showPassword = false;
        private Point dragStart;

        private void btnInSesion_Click(object sender, EventArgs e)
        {
            string usuario = tbUser.Text;
            string password = tbPass.Text;

            string verify = autentication.VerifyPassword(usuario, password);
            if (verify != "Invalido")
            {

                MessageBox.Show("Usuario verificado", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formMenu form = new formMenu();
                form.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("Tu usuario o contraseña no coincide intentalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUser.Text = "";
            tbPass.Text = "";
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (showPassword)
            {
                tbPass.PasswordChar = '*'; // Ocultar contraseña
                showPassword = false;
            }
            else
            {
                tbPass.PasswordChar = '\0'; // Mostrar contraseña
                showPassword = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //eliminar este boton despues de las pruebas
        private void btn_Click(object sender, EventArgs e)
        {
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStart = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(e.Location);
                Location = new Point(currentPoint.X - dragStart.X, currentPoint.Y - dragStart.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
