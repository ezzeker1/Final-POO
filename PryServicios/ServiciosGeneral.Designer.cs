namespace PryServicios
{
    partial class ServiciosGeneral
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblResUsuario = new System.Windows.Forms.Label();
            this.PBServicios = new System.Windows.Forms.PictureBox();
            this.PBInmuebles = new System.Windows.Forms.PictureBox();
            this.PBVehiculos = new System.Windows.Forms.PictureBox();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.lblInmuebles = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBBuscar = new System.Windows.Forms.GroupBox();
            this.GBUsuario = new System.Windows.Forms.GroupBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVehiculos)).BeginInit();
            this.GBBuscar.SuspendLayout();
            this.GBUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(518, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResUsuario.Location = new System.Drawing.Point(570, 9);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblResUsuario.TabIndex = 2;
            this.lblResUsuario.Text = "...............";
            // 
            // PBServicios
            // 
            this.PBServicios.Image = global::PryServicios.Properties.Resources.servicios;
            this.PBServicios.Location = new System.Drawing.Point(398, 56);
            this.PBServicios.Name = "PBServicios";
            this.PBServicios.Size = new System.Drawing.Size(183, 153);
            this.PBServicios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBServicios.TabIndex = 5;
            this.PBServicios.TabStop = false;
            this.PBServicios.Click += new System.EventHandler(this.PBServicios_Click);
            // 
            // PBInmuebles
            // 
            this.PBInmuebles.Image = global::PryServicios.Properties.Resources.Inmuebles;
            this.PBInmuebles.Location = new System.Drawing.Point(212, 56);
            this.PBInmuebles.Name = "PBInmuebles";
            this.PBInmuebles.Size = new System.Drawing.Size(153, 153);
            this.PBInmuebles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBInmuebles.TabIndex = 4;
            this.PBInmuebles.TabStop = false;
            this.PBInmuebles.Click += new System.EventHandler(this.PBInmuebles_Click);
            // 
            // PBVehiculos
            // 
            this.PBVehiculos.Image = global::PryServicios.Properties.Resources.carros;
            this.PBVehiculos.Location = new System.Drawing.Point(16, 56);
            this.PBVehiculos.Name = "PBVehiculos";
            this.PBVehiculos.Size = new System.Drawing.Size(172, 153);
            this.PBVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBVehiculos.TabIndex = 3;
            this.PBVehiculos.TabStop = false;
            this.PBVehiculos.Click += new System.EventHandler(this.PBVehiculos_Click);
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.Location = new System.Drawing.Point(12, 33);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(87, 20);
            this.lblVehiculos.TabIndex = 6;
            this.lblVehiculos.Text = "Vehiculos";
            // 
            // lblInmuebles
            // 
            this.lblInmuebles.AutoSize = true;
            this.lblInmuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInmuebles.Location = new System.Drawing.Point(208, 33);
            this.lblInmuebles.Name = "lblInmuebles";
            this.lblInmuebles.Size = new System.Drawing.Size(92, 20);
            this.lblInmuebles.TabIndex = 7;
            this.lblInmuebles.Text = "Inmuebles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Servicios Profesionales";
            // 
            // GBBuscar
            // 
            this.GBBuscar.Controls.Add(this.label4);
            this.GBBuscar.Controls.Add(this.PBVehiculos);
            this.GBBuscar.Controls.Add(this.lblInmuebles);
            this.GBBuscar.Controls.Add(this.PBInmuebles);
            this.GBBuscar.Controls.Add(this.lblVehiculos);
            this.GBBuscar.Controls.Add(this.PBServicios);
            this.GBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBBuscar.Location = new System.Drawing.Point(21, 39);
            this.GBBuscar.Name = "GBBuscar";
            this.GBBuscar.Size = new System.Drawing.Size(601, 232);
            this.GBBuscar.TabIndex = 9;
            this.GBBuscar.TabStop = false;
            this.GBBuscar.Text = "Que desea Buscar?";
            // 
            // GBUsuario
            // 
            this.GBUsuario.Controls.Add(this.btnPerfil);
            this.GBUsuario.Location = new System.Drawing.Point(420, 309);
            this.GBUsuario.Name = "GBUsuario";
            this.GBUsuario.Size = new System.Drawing.Size(202, 103);
            this.GBUsuario.TabIndex = 10;
            this.GBUsuario.TabStop = false;
            this.GBUsuario.Text = "Opciones para El usuario";
            // 
            // btnPerfil
            // 
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPerfil.Location = new System.Drawing.Point(25, 34);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(144, 41);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.Text = "Ingresar a mi Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // ServiciosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 425);
            this.Controls.Add(this.GBUsuario);
            this.Controls.Add(this.GBBuscar);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.lblUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "ServiciosGeneral";
            this.Text = "ServiciosGeneral";
            this.Load += new System.EventHandler(this.ServiciosGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVehiculos)).EndInit();
            this.GBBuscar.ResumeLayout(false);
            this.GBBuscar.PerformLayout();
            this.GBUsuario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.PictureBox PBVehiculos;
        private System.Windows.Forms.PictureBox PBInmuebles;
        private System.Windows.Forms.PictureBox PBServicios;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label lblInmuebles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GBBuscar;
        private System.Windows.Forms.GroupBox GBUsuario;
        private System.Windows.Forms.Button btnPerfil;
    }
}