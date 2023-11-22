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

namespace winUI
{
    public partial class FormHistorial : Form
    {
        ClassLogicaFactura Logica = new ClassLogicaFactura(); //se crea un objeto 
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Logica.ListarPretasmos(); //carga los datos
            dataGridView1.Refresh();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
