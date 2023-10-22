namespace winUI
{
    partial class formMenuCajero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnCerrarS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnVenta);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnProducto);
            this.groupBox1.Controls.Add(this.btnFactura);
            this.groupBox1.Controls.Add(this.btnCerrarS);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(75, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 575);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.Black;
            this.btnVenta.Location = new System.Drawing.Point(144, 203);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(125, 50);
            this.btnVenta.TabIndex = 64;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(306, 506);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 50);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.Black;
            this.btnProducto.Location = new System.Drawing.Point(224, 278);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(125, 50);
            this.btnProducto.TabIndex = 66;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.Black;
            this.btnFactura.Location = new System.Drawing.Point(303, 203);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(125, 50);
            this.btnFactura.TabIndex = 65;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarS.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarS.Location = new System.Drawing.Point(147, 506);
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.Size = new System.Drawing.Size(125, 50);
            this.btnCerrarS.TabIndex = 57;
            this.btnCerrarS.Text = "Cerrar Sesion";
            this.btnCerrarS.UseVisualStyleBackColor = false;
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // formMenuCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winUI.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.groupBox1);
            this.Name = "formMenuCajero";
            this.Text = "formMenuCajero";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnCerrarS;
    }
}