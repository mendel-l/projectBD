using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        public bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            string enteredPasswordHash = HashPassword(enteredPassword);
            return enteredPasswordHash == storedHashedPassword;
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convierte los bytes hash en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
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
    }
}
