using BLL;
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
    public partial class Pago : Form
    {

        ClassLogicaPago logica = new ClassLogicaPago();
        public Pago()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logica.ListarPago(); //carga los datos
            dataGridView1.Refresh();
        }
    }
}
