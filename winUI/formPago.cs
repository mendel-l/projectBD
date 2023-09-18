﻿using BLL;
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
    public partial class formPago : Form
    {

        ClassLogicaPago Logica = new ClassLogicaPago();
        public formPago()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnNuevo.Enabled = false;
            btnGrabar.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Logica.ListarPago(); //carga los datos
            dataGridView1.Refresh();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            respuesta = Logica.NewPago(cbTipoPago.Text);
            MessageBox.Show(respuesta);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            string respuesta = "";
            respuesta = Logica.editPago(cbTipoPago.Text, int.Parse(label1.Text));
            MessageBox.Show(respuesta);
            
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            formMenu newform = new formMenu();
            newform.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                this.label1.Visible = true;
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbTipoPago.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                btnActualizar.Enabled = true;
                btnGrabar.Enabled = false;
                btnNuevo.Enabled = true;
                groupBox1.Enabled = true;
            }
        }
    }
}