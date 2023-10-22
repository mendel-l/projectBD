namespace winUI
{
    partial class formCategoria
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Idcate = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.Marca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(864, 604);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(130, 40);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 604);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 40);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Idcate);
            this.groupBox1.Controls.Add(this.Modelo);
            this.groupBox1.Controls.Add(this.tbModelo);
            this.groupBox1.Controls.Add(this.Marca);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.Categoria);
            this.groupBox1.Controls.Add(this.tbCategoria);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(253, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 197);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // Idcate
            // 
            this.Idcate.AutoSize = true;
            this.Idcate.Location = new System.Drawing.Point(427, 101);
            this.Idcate.Name = "Idcate";
            this.Idcate.Size = new System.Drawing.Size(35, 13);
            this.Idcate.TabIndex = 12;
            this.Idcate.Text = "label1";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelo.Location = new System.Drawing.Point(68, 96);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(67, 20);
            this.Modelo.TabIndex = 7;
            this.Modelo.Text = "Modelo";
            // 
            // tbModelo
            // 
            this.tbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModelo.Location = new System.Drawing.Point(167, 93);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(223, 26);
            this.tbModelo.TabIndex = 6;
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.Location = new System.Drawing.Point(68, 64);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(58, 20);
            this.Marca.TabIndex = 5;
            this.Marca.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarca.Location = new System.Drawing.Point(167, 61);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(223, 26);
            this.tbMarca.TabIndex = 4;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.Location = new System.Drawing.Point(68, 32);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(87, 20);
            this.Categoria.TabIndex = 3;
            this.Categoria.Text = "Categoria";
            // 
            // tbCategoria
            // 
            this.tbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoria.Location = new System.Drawing.Point(167, 29);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(223, 26);
            this.tbCategoria.TabIndex = 2;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(705, 249);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(115, 40);
            this.btnInhabilitar.TabIndex = 24;
            this.btnInhabilitar.Text = "Eliminar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(441, 249);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 40);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(310, 249);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(115, 40);
            this.btnGrabar.TabIndex = 22;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(179, 249);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 40);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 215);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(573, 249);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(115, 40);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnRegresar);
            this.groupBox2.Controls.Add(this.btnListar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnInhabilitar);
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Location = new System.Drawing.Point(115, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 650);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // formCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winUI.Properties.Resources.imagen_fondo_pantalla_fondo_abstracto_azul_acero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.groupBox2);
            this.Name = "formCategoria";
            this.Text = "formCategoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Idcate;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}