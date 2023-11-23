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


using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Reporting.WinForms;

namespace winUI
{
    public partial class FormHistorial : Form
    {
        ClassLogicaPersona LogicaPersona = new ClassLogicaPersona(); //se crea un objeto 
        ClassLogicaFactura LogicaFactura = new ClassLogicaFactura(); //se crea un objeto 
        ClassLogicaProveedor LogicaProveedor = new ClassLogicaProveedor(); //se crea un objeto 
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //formFactura
            ClassLogicaFactura LogicaFactura = new ClassLogicaFactura();
            var data = LogicaFactura.ListarPretasmos();

            ReportDataSource Reporte;
            Reporte = new ReportDataSource("DataSetFacturaListar", data);

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = @"winUI.Reportes.ReportFactura.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(Reporte);
            this.reportViewer1.RefreshReport();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
        }
        private void btnListarPer_Click(object sender, EventArgs e)
        {
            ClassLogicaPersona LogicaPersona = new ClassLogicaPersona();
            var data = LogicaPersona.ListarPersonas();

            ReportDataSource Reporte;
            Reporte = new ReportDataSource("DataSet1", data);

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = @"winUI.Reportes.ReportPersona.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(Reporte);
            this.reportViewer1.RefreshReport();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formFactura newform = new formFactura();
            newform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassLogicaProveedor LogicaProveedor = new ClassLogicaProveedor();
            var data = LogicaProveedor.ListarProveedores();

            ReportDataSource Reporte;
            Reporte = new ReportDataSource("DataSetProveedorListar", data);

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = @"winUI.Reportes.ReportProveedor.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(Reporte);
            this.reportViewer1.RefreshReport();
        }
    }
}
