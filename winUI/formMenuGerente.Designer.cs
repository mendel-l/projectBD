namespace winUI
{
    partial class formMenuGerente
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
            this.btnPedidoP = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPedidoP
            // 
            this.btnPedidoP.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoP.ForeColor = System.Drawing.Color.Black;
            this.btnPedidoP.Location = new System.Drawing.Point(307, 178);
            this.btnPedidoP.Name = "btnPedidoP";
            this.btnPedidoP.Size = new System.Drawing.Size(125, 50);
            this.btnPedidoP.TabIndex = 71;
            this.btnPedidoP.Text = "Pedido";
            this.btnPedidoP.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Black;
            this.btnReporte.Location = new System.Drawing.Point(148, 178);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(125, 50);
            this.btnReporte.TabIndex = 70;
            this.btnReporte.Text = "Ver Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(307, 344);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 50);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarS.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarS.Location = new System.Drawing.Point(148, 344);
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.Size = new System.Drawing.Size(125, 50);
            this.btnCerrarS.TabIndex = 68;
            this.btnCerrarS.Text = "Cerrar Sesion";
            this.btnCerrarS.UseVisualStyleBackColor = false;
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.btnPedidoP);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnCerrarS);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(75, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 575);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // formMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winUI.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.groupBox1);
            this.Name = "formMenuGerente";
            this.Text = "formMenuGerente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedidoP;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarS;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}