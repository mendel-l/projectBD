using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winUI
{
    public partial class formFactura : Form
    {
        ClassLogicaFactura Logica = new ClassLogicaFactura(); //se crea un objeto 
        public formFactura()
        {

            InitializeComponent();



            FormBorderStyle = FormBorderStyle.Sizable;
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
            groupBox2.Enabled = true;
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {


            string respuesta = "";
            respuesta = Logica.nuevaFactura(Convert.ToInt16(tbNoFactura.Text.ToString()), dateTimePicker1.Text.ToString(), Convert.ToInt16(cbIdCli.Text.ToString()), Convert.ToInt16(cbIdVen.Text.ToString()), Convert.ToInt16(cbIdPago.Text.ToString()));
            MessageBox.Show(respuesta);
           
            btnNuevo.Enabled = true;
            groupBox2.Enabled = false;
            btnGrabar.Enabled = false;
            refrs();
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(label1.Text, out int resultado))
            {
                string respuesta = "";
                respuesta = Logica.editFactura(Convert.ToInt16(tbNoFactura.Text.ToString()), dateTimePicker1.Text.ToString(), Convert.ToInt16(cbIdCli.Text.ToString()), Convert.ToInt16(cbIdVen.Text.ToString()), Convert.ToInt16(cbIdPago.Text.ToString()), Convert.ToInt16(label1.Text.ToString()));
                MessageBox.Show(respuesta);
                btnNuevo.Enabled = true;
                groupBox2.Enabled = false;
                refrs();
                limpiar();

            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            refrs();
            cbIdCli.DataSource = Logica.listarIDCli();
            cbIdCli.DisplayMember = "IDclientes";

            cbIdVen.DataSource = Logica.listaridV();
            cbIdVen.DisplayMember = "IDventa";

            cbIdPago.DataSource = Logica.listaridP();
            cbIdPago.DisplayMember = "⁯IDpago";
        }
        public void limpiar()
        {
            tbNoFactura.Text = "";
            dateTimePicker1.Text = "";
            cbIdCli.Text = "";
            cbIdVen.Text = "";
            cbIdPago.Text = "";
            label1.Text = "";
        }
        public void refrs(){
            dataGridView1.DataSource = Logica.listAllF(); //carga los datos
            dataGridView1.Refresh();
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
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }

        private void cbIdCli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                this.label4.Visible = true;
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbNoFactura.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbIdCli.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbIdVen.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbIdPago.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                btnNuevo.Enabled = false;
                btnActualizar.Enabled = true;
                groupBox2.Enabled = true;


            }
        }
    }
}
