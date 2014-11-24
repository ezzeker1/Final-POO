namespace PryServicios
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.lblResablecerPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCrearUsuario = new System.Windows.Forms.Label();
            this.btnCrearusuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(139, 175);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(129, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(191, 172);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(191, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(177, 242);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 27);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(341, 326);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(131, 23);
            this.btnRestablecer.TabIndex = 6;
            this.btnRestablecer.Text = "Restablecer password";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // lblResablecerPass
            // 
            this.lblResablecerPass.AutoSize = true;
            this.lblResablecerPass.Location = new System.Drawing.Point(221, 331);
            this.lblResablecerPass.Name = "lblResablecerPass";
            this.lblResablecerPass.Size = new System.Drawing.Size(114, 13);
            this.lblResablecerPass.TabIndex = 7;
            this.lblResablecerPass.Text = "Olvido su Contraseña?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Copyright 2014";
            // 
            // lblCrearUsuario
            // 
            this.lblCrearUsuario.AutoSize = true;
            this.lblCrearUsuario.Location = new System.Drawing.Point(246, 296);
            this.lblCrearUsuario.Name = "lblCrearUsuario";
            this.lblCrearUsuario.Size = new System.Drawing.Size(122, 13);
            this.lblCrearUsuario.TabIndex = 9;
            this.lblCrearUsuario.Text = "Nuevo en la aplicación?";
            // 
            // btnCrearusuario
            // 
            this.btnCrearusuario.Location = new System.Drawing.Point(374, 291);
            this.btnCrearusuario.Name = "btnCrearusuario";
            this.btnCrearusuario.Size = new System.Drawing.Size(98, 23);
            this.btnCrearusuario.TabIndex = 10;
            this.btnCrearusuario.Text = "Crear Usuario";
            this.btnCrearusuario.UseVisualStyleBackColor = true;
            this.btnCrearusuario.Click += new System.EventHandler(this.btnCrearusuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryServicios.Properties.Resources.Logo_app;
            this.pictureBox1.Location = new System.Drawing.Point(109, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 384);
            this.Controls.Add(this.btnCrearusuario);
            this.Controls.Add(this.lblCrearUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResablecerPass);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label lblResablecerPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCrearUsuario;
        private System.Windows.Forms.Button btnCrearusuario;
    }
}

