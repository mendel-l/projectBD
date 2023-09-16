namespace winUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnShowPass;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserError = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            btnShowPass = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowPass
            // 
            btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            btnShowPass.Location = new System.Drawing.Point(307, 221);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new System.Drawing.Size(31, 26);
            btnShowPass.TabIndex = 22;
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnInSesion);
            this.groupBox1.Controls.Add(btnShowPass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPassError);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUserError);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(120, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 330);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::winUI.Properties.Resources._6073874;
            this.pictureBox1.Location = new System.Drawing.Point(120, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(201, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInSesion
            // 
            this.btnInSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnInSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSesion.ForeColor = System.Drawing.Color.Black;
            this.btnInSesion.Location = new System.Drawing.Point(95, 266);
            this.btnInSesion.Name = "btnInSesion";
            this.btnInSesion.Size = new System.Drawing.Size(100, 40);
            this.btnInSesion.TabIndex = 3;
            this.btnInSesion.Text = "Ingresar";
            this.btnInSesion.UseVisualStyleBackColor = false;
            this.btnInSesion.Click += new System.EventHandler(this.btnInSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblPassError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassError.Location = new System.Drawing.Point(173, 249);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(22, 13);
            this.lblPassError.TabIndex = 21;
            this.lblPassError.Text = ".....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // lblUserError
            // 
            this.lblUserError.AutoSize = true;
            this.lblUserError.BackColor = System.Drawing.Color.Transparent;
            this.lblUserError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserError.Location = new System.Drawing.Point(173, 204);
            this.lblUserError.Name = "lblUserError";
            this.lblUserError.Size = new System.Drawing.Size(22, 13);
            this.lblUserError.TabIndex = 20;
            this.lblUserError.Text = ".....";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(152, 221);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(149, 26);
            this.tbPass.TabIndex = 7;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(152, 175);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(149, 26);
            this.tbUser.TabIndex = 8;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(540, 412);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(82, 37);
            this.btn.TabIndex = 26;
            this.btn.Text = "...";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 37);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winUI.Properties.Resources.d8c5b314_2d31_41d0_b7e4_cf121ff6dacd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserError;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnSalir;
    }
}

