using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL; //invocar logica de negocio
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace winUI
{
    public partial class formPersona : Form
    {
        ClassLogicaPersona Logica = new ClassLogicaPersona(); //se crea un objeto 
        public formPersona()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Logica.ListarPersonas(); //carga los datos
            dataGridView1.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnNuevo.Enabled = false;
            btnGrabar.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            respuesta = Logica.NuevaPersona(tbNombre.Text, tbApellido.Text, tbDireccion.Text, int.Parse(tbTelefono.Text), tbCorreo.Text);
            MessageBox.Show(respuesta);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            respuesta = Logica.editarPersona(tbNombre.Text, tbApellido.Text, tbDireccion.Text, int.Parse(tbTelefono.Text), tbCorreo.Text, int.Parse(label1.Text));
            MessageBox.Show(respuesta);
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                this.label4.Visible = true;
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbApellido.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                btnActualizar.Enabled = true;
                btnGrabar.Enabled = false;
                btnNuevo.Enabled = true;
                groupBox1.Enabled = true;
            }
        }
    }
}
