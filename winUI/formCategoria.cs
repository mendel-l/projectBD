using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winUI
{
    public partial class formCategoria : Form
    {
        ClassLogicaCategoria logica = new ClassLogicaCategoria();
        public formCategoria()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            groupBox2.AutoSize = true;
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Location = new Point(
                (ClientSize.Width - groupBox2.Width) / 2,
                (ClientSize.Height - groupBox2.Height) / 2);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logica.ListarCategoria(); //carga los datos
            dataGridView1.Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
            
        {
            int id = Convert.ToInt16(Idcate.Text.ToString());
            MessageBox.Show(logica.editCATEGORIA(tbCategoria.Text.ToString(), tbMarca.Text.ToString(), tbModelo.Text.ToString(),id));
            btnActualizar.Enabled = false;
            groupBox1.Enabled = true;
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = true;
            btnInhabilitar.Enabled = true;
            tbCategoria.Text = "";
            tbMarca.Text = "";
            tbModelo.Text = "";
        }
        public  void DatosActualizar()
        {
            btnActualizar.Enabled = true;
            groupBox1.Enabled = true;
            btnGrabar.Enabled = false;
            btnNuevo.Enabled = false;
            btnInhabilitar.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatosActualizar();
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                Idcate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbCategoria.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbMarca.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbModelo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
          MessageBox.Show(logica.nuevaCategoria(tbCategoria.Text, tbMarca.Text, tbModelo.Text));
            tbCategoria.Text = "";
            tbMarca.Text = "";
            tbModelo.Text = "";
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            btnGrabar.Enabled = true;
            groupBox1.Enabled = true;

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Idcate.Text.ToString());
            MessageBox.Show(logica.Eliminar(tbCategoria.Text,id));
            btnActualizar.Enabled = false;
            groupBox1.Enabled = true;
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = true;
            btnInhabilitar.Enabled = false;
            tbCategoria.Text = "";
            tbMarca.Text = "";
            tbModelo.Text = "";
            
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
