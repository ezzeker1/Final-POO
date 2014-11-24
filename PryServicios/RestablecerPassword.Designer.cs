namespace PryServicios
{
    partial class RestablecerPassword
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
            this.GBRestablecerPass = new System.Windows.Forms.GroupBox();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblReingresarPass = new System.Windows.Forms.Label();
            this.txtReingresarNuevaPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNuevaPass = new System.Windows.Forms.Label();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.txtRespuestaSecreta = new System.Windows.Forms.TextBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.lblUsario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.GBRestablecerPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBRestablecerPass
            // 
            this.GBRestablecerPass.Controls.Add(this.txtUsuario);
            this.GBRestablecerPass.Controls.Add(this.lblUsario);
            this.GBRestablecerPass.Controls.Add(this.BtnValidar);
            this.GBRestablecerPass.Controls.Add(this.lblEdad);
            this.GBRestablecerPass.Controls.Add(this.txtEdad);
            this.GBRestablecerPass.Controls.Add(this.lblReingresarPass);
            this.GBRestablecerPass.Controls.Add(this.txtReingresarNuevaPass);
            this.GBRestablecerPass.Controls.Add(this.label1);
            this.GBRestablecerPass.Controls.Add(this.lblNuevaPass);
            this.GBRestablecerPass.Controls.Add(this.txtNuevaPass);
            this.GBRestablecerPass.Controls.Add(this.txtRespuestaSecreta);
            this.GBRestablecerPass.Controls.Add(this.btnRestablecer);
            this.GBRestablecerPass.Location = new System.Drawing.Point(23, 21);
            this.GBRestablecerPass.Name = "GBRestablecerPass";
            this.GBRestablecerPass.Size = new System.Drawing.Size(364, 450);
            this.GBRestablecerPass.TabIndex = 0;
            this.GBRestablecerPass.TabStop = false;
            this.GBRestablecerPass.Text = "Pregunta Secreta";
            // 
            // BtnValidar
            // 
            this.BtnValidar.Location = new System.Drawing.Point(116, 191);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(115, 31);
            this.BtnValidar.TabIndex = 11;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(14, 142);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(134, 18);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Ingrese Su edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(154, 143);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(171, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // lblReingresarPass
            // 
            this.lblReingresarPass.AutoSize = true;
            this.lblReingresarPass.Location = new System.Drawing.Point(26, 376);
            this.lblReingresarPass.Name = "lblReingresarPass";
            this.lblReingresarPass.Size = new System.Drawing.Size(153, 13);
            this.lblReingresarPass.TabIndex = 8;
            this.lblReingresarPass.Text = "Reingresar Nueva Contraseña:";
            this.lblReingresarPass.Click += new System.EventHandler(this.lblReingresarPass_Click);
            // 
            // txtReingresarNuevaPass
            // 
            this.txtReingresarNuevaPass.Location = new System.Drawing.Point(185, 369);
            this.txtReingresarNuevaPass.Name = "txtReingresarNuevaPass";
            this.txtReingresarNuevaPass.Size = new System.Drawing.Size(100, 20);
            this.txtReingresarNuevaPass.TabIndex = 7;
            this.txtReingresarNuevaPass.TextChanged += new System.EventHandler(this.txtReingresarNuevaPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cual es el nombre de tu primera mascota?";
            // 
            // lblNuevaPass
            // 
            this.lblNuevaPass.AutoSize = true;
            this.lblNuevaPass.Location = new System.Drawing.Point(79, 345);
            this.lblNuevaPass.Name = "lblNuevaPass";
            this.lblNuevaPass.Size = new System.Drawing.Size(99, 13);
            this.lblNuevaPass.TabIndex = 5;
            this.lblNuevaPass.Text = "Nueva Contraseña:";
            this.lblNuevaPass.Click += new System.EventHandler(this.lblNuevaPass_Click);
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Location = new System.Drawing.Point(185, 338);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaPass.TabIndex = 4;
            this.txtNuevaPass.TextChanged += new System.EventHandler(this.txtNuevaPass_TextChanged);
            // 
            // txtRespuestaSecreta
            // 
            this.txtRespuestaSecreta.Location = new System.Drawing.Point(17, 96);
            this.txtRespuestaSecreta.Name = "txtRespuestaSecreta";
            this.txtRespuestaSecreta.Size = new System.Drawing.Size(161, 20);
            this.txtRespuestaSecreta.TabIndex = 2;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(137, 411);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(94, 29);
            this.btnRestablecer.TabIndex = 0;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // lblUsario
            // 
            this.lblUsario.AutoSize = true;
            this.lblUsario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsario.Location = new System.Drawing.Point(15, 27);
            this.lblUsario.Name = "lblUsario";
            this.lblUsario.Size = new System.Drawing.Size(72, 18);
            this.lblUsario.TabIndex = 12;
            this.lblUsario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(93, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // RestablecerPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 483);
            this.Controls.Add(this.GBRestablecerPass);
            this.Name = "RestablecerPassword";
            this.Text = "RestablecerPassword";
            this.GBRestablecerPass.ResumeLayout(false);
            this.GBRestablecerPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBRestablecerPass;
        private System.Windows.Forms.Label lblNuevaPass;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.TextBox txtRespuestaSecreta;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReingresarPass;
        private System.Windows.Forms.TextBox txtReingresarNuevaPass;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsario;
    }
}