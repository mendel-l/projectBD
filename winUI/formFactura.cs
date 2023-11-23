using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
//para la factura
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
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
            btnAnularFac.Enabled = false;
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
            btnFactura.Enabled = true;
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtner ids de la tabla gridview
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string idPersona = selectedRow.Cells[3].Value.ToString();
                string idVenta = selectedRow.Cells[4].Value.ToString();
                string idPago = selectedRow.Cells[5].Value.ToString();

                // Obtener datos de query y pasarselos a los parametros
                DataTable dataTable = Logica.obtenerClienteNom(Convert.ToInt16(idPersona));
                string NombreCliente = dataTable.Rows[0]["nombre"].ToString();

                DataTable dataTable2 = Logica.obtenerTpago(Convert.ToInt16(idPago));
                string FormaPago = dataTable2.Rows[0]["tipoPago"].ToString();

                DataTable dataTable3 = Logica.obtenerCantidadV(Convert.ToInt16(idVenta));
                string CVentas = dataTable3.Rows[0]["Cantidad"].ToString();

                DataTable dataTable4 = Logica.obtenerVtotal(Convert.ToInt16(idVenta));
                string Tventas = dataTable4.Rows[0]["Total"].ToString();

                // Mandar parametros al array
                Factura factura = new Factura();
                factura.Cliente = "Nombre del cliente"+ idPersona; // Esto puede obtenerse de otro lugar
                factura.Fecha = DateTime.Now;
                factura.Detalles.Add(new DetalleFactura(NombreCliente, CVentas, Tventas, FormaPago));

                
                // Crear el documento PDF
                Document doc = new Document();

                //cambiar la ruta de donde se quere el archivo PDF-----------------------------------------------
                string fileName = "C:\\Users\\m3mes\\OneDrive\\Documents\\BaseDatos\\projectBD\\FacturasFactura.pdf";

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                    doc.Open();

                  
                    Paragraph paragraph = new Paragraph();
                    paragraph.Add("Factura\n\n");
                    paragraph.Add("Fecha de Factura: " + factura.Fecha.ToString() + "\n");
                    paragraph.Add("\nDetalles:\n");

                    foreach (DetalleFactura detalle in factura.Detalles)
                    {
                        paragraph.Add("Nombre Cliente: "+detalle.Nombre + "\nCantidad: " + detalle.Cantidad + "\nMonto total: " + detalle.Monto + "\nTipo de pago: " + detalle.TipoPag);
                    }

                    doc.Add(paragraph);
                }
                finally
                {
                    doc.Close();
                }

                // Abre el archivo PDF
                System.Diagnostics.Process.Start(fileName);
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de generar la factura.");
            }    
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
                btnAnularFac.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHistorial newform = new FormHistorial();
            newform.Show();
            this.Hide();
        }

        private void btnAnularFac_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener ids de la tabla gridview
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string idPersona = selectedRow.Cells[3].Value.ToString();
                string idVenta = selectedRow.Cells[4].Value.ToString();
                string idPago = selectedRow.Cells[5].Value.ToString();

                // Obtener datos de query y pasarselos a los parametros
                DataTable dataTable = Logica.obtenerClienteNom(Convert.ToInt16(idPersona));
                string NombreCliente = dataTable.Rows[0]["nombre"].ToString();

                DataTable dataTable2 = Logica.obtenerTpago(Convert.ToInt16(idPago));
                string FormaPago = dataTable2.Rows[0]["tipoPago"].ToString();

                DataTable dataTable3 = Logica.obtenerCantidadV(Convert.ToInt16(idVenta));
                string CVentas = dataTable3.Rows[0]["Cantidad"].ToString();

                DataTable dataTable4 = Logica.obtenerVtotal(Convert.ToInt16(idVenta));
                string Tventas = dataTable4.Rows[0]["Total"].ToString();

                // Mostrar la información en el listBox1
                listBox1.Items.Clear();
                listBox1.Items.Add("Factura Anulada");
                listBox1.Items.Add($"Nombre Cliente: {NombreCliente}");
                listBox1.Items.Add($"Cantidad: 0");
                listBox1.Items.Add($"Monto total: 0");
                listBox1.Items.Add($"Tipo de pago: Anulado");
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de anular la factura.");
            }

        }

        private void formFactura_Load(object sender, EventArgs e)
        {
            btnAnularFac.Enabled = false;
        }
    }
}
