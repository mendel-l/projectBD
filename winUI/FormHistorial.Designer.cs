namespace winUI
{
    partial class FormHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListar = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnListarPer = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(297, 25);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(165, 40);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar Facturas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(363, 496);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(186, 40);
            this.btnFactura.TabIndex = 22;
            this.btnFactura.Text = "Generar Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnListarPer
            // 
            this.btnListarPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPer.Location = new System.Drawing.Point(484, 25);
            this.btnListarPer.Name = "btnListarPer";
            this.btnListarPer.Size = new System.Drawing.Size(165, 40);
            this.btnListarPer.TabIndex = 23;
            this.btnListarPer.Text = "Listar Personas";
            this.btnListarPer.UseVisualStyleBackColor = true;
            this.btnListarPer.Click += new System.EventHandler(this.btnListarPer_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(104, 96);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 350);
            this.reportViewer1.TabIndex = 24;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(842, 509);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(130, 40);
            this.btnRegresar.TabIndex = 30;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 509);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 40);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnListarPer);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnListar);
            this.Name = "FormHistorial";
            this.Text = "FormHistorial";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnListarPer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
    }
}