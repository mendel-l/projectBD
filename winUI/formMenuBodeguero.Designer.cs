namespace winUI
{
    partial class formMenuBodeguero
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
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
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
            this.btnPedidoP.Location = new System.Drawing.Point(310, 309);
            this.btnPedidoP.Name = "btnPedidoP";
            this.btnPedidoP.Size = new System.Drawing.Size(125, 50);
            this.btnPedidoP.TabIndex = 53;
            this.btnPedidoP.Text = "Pedido";
            this.btnPedidoP.UseVisualStyleBackColor = false;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.Black;
            this.btnProducto.Location = new System.Drawing.Point(310, 247);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(125, 50);
            this.btnProducto.TabIndex = 52;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.Black;
            this.btnFactura.Location = new System.Drawing.Point(151, 309);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(125, 50);
            this.btnFactura.TabIndex = 51;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.Black;
            this.btnVenta.Location = new System.Drawing.Point(151, 247);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(125, 50);
            this.btnVenta.TabIndex = 50;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(310, 508);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 50);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnProveedores.Location = new System.Drawing.Point(235, 130);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(125, 50);
            this.btnProveedores.TabIndex = 46;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarS.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarS.Location = new System.Drawing.Point(151, 508);
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.Size = new System.Drawing.Size(125, 50);
            this.btnCerrarS.TabIndex = 43;
            this.btnCerrarS.Text = "Cerrar Sesion";
            this.btnCerrarS.UseVisualStyleBackColor = false;
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnProveedores);
            this.groupBox1.Controls.Add(this.btnVenta);
            this.groupBox1.Controls.Add(this.btnPedidoP);
            this.groupBox1.Controls.Add(this.btnFactura);
            this.groupBox1.Controls.Add(this.btnCerrarS);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnProducto);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(75, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 575);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // formMenuBodeguero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winUI.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.groupBox1);
            this.Name = "formMenuBodeguero";
            this.Text = "formMenuBodeguero";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedidoP;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCerrarS;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}