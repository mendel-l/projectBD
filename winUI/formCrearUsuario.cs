using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
namespace winUI
{
    public partial class formCrearUsuario : Form
    {
        ClassLogicaUsuario autentication = new ClassLogicaUsuario(); //se crea un objeto 
        public formCrearUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            string Usuario = tbNameUser.Text;
            string Contras = tbPass.Text;
            string cContra = tbConfPass.Text;
            string idpersona = tbIDp.Text;
            string idrol = tbIDr.Text;

            int IDROL = 0;
            int IDP = 0;

            int.TryParse(idpersona, out IDP);
            int.TryParse(idrol, out IDROL);

            if (Contras==cContra) {
                string USRcreado = autentication.crearUsuario(Usuario, Contras, IDP, IDROL);
                if (USRcreado.Contains("Existe"))
                {

                    MessageBox.Show("Este usuario ya esta registrado!!!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limp();
                }
                else
                {
                    MessageBox.Show(USRcreado, "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limp();
                }
            }
            else
            {

                MessageBox.Show("Las contraseñas no coinciden!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void limp()
        {
            tbNameUser.Text = "";
            tbPass.Text = "";
            tbConfPass.Text = "";
            tbIDp.Text = "";
            tbIDr.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           limp();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }
    }
}
