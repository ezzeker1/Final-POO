namespace PryServicios
{
    partial class ModificarInfoFacturacion
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
            this.lblResUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.GBInfoFacturacion = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.CBNTarjeta = new System.Windows.Forms.ComboBox();
            this.lblNTarjeta = new System.Windows.Forms.Label();
            this.CBSelecionar = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.CBDistrito = new System.Windows.Forms.ComboBox();
            this.CBProvincia = new System.Windows.Forms.ComboBox();
            this.CBDepartamento = new System.Windows.Forms.ComboBox();
            this.CBPais = new System.Windows.Forms.ComboBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.GBInfoFacturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.Location = new System.Drawing.Point(320, 11);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblResUsuario.TabIndex = 5;
            this.lblResUsuario.Text = "................";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(269, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // GBInfoFacturacion
            // 
            this.GBInfoFacturacion.Controls.Add(this.btnModificar);
            this.GBInfoFacturacion.Controls.Add(this.CBNTarjeta);
            this.GBInfoFacturacion.Controls.Add(this.lblNTarjeta);
            this.GBInfoFacturacion.Controls.Add(this.CBSelecionar);
            this.GBInfoFacturacion.Controls.Add(this.txtDireccion);
            this.GBInfoFacturacion.Controls.Add(this.CBDistrito);
            this.GBInfoFacturacion.Controls.Add(this.CBProvincia);
            this.GBInfoFacturacion.Controls.Add(this.CBDepartamento);
            this.GBInfoFacturacion.Controls.Add(this.CBPais);
            this.GBInfoFacturacion.Controls.Add(this.lblDistrito);
            this.GBInfoFacturacion.Controls.Add(this.lblDepartamento);
            this.GBInfoFacturacion.Controls.Add(this.lblProvincia);
            this.GBInfoFacturacion.Controls.Add(this.lblPais);
            this.GBInfoFacturacion.Controls.Add(this.lblDireccion);
            this.GBInfoFacturacion.Controls.Add(this.lblSeleccionar);
            this.GBInfoFacturacion.Location = new System.Drawing.Point(25, 37);
            this.GBInfoFacturacion.Name = "GBInfoFacturacion";
            this.GBInfoFacturacion.Size = new System.Drawing.Size(350, 326);
            this.GBInfoFacturacion.TabIndex = 3;
            this.GBInfoFacturacion.TabStop = false;
            this.GBInfoFacturacion.Text = "Información de Facturación";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(125, 280);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 30);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // CBNTarjeta
            // 
            this.CBNTarjeta.FormattingEnabled = true;
            this.CBNTarjeta.Location = new System.Drawing.Point(93, 58);
            this.CBNTarjeta.Name = "CBNTarjeta";
            this.CBNTarjeta.Size = new System.Drawing.Size(173, 21);
            this.CBNTarjeta.TabIndex = 27;
            // 
            // lblNTarjeta
            // 
            this.lblNTarjeta.AutoSize = true;
            this.lblNTarjeta.Location = new System.Drawing.Point(31, 61);
            this.lblNTarjeta.Name = "lblNTarjeta";
            this.lblNTarjeta.Size = new System.Drawing.Size(58, 13);
            this.lblNTarjeta.TabIndex = 26;
            this.lblNTarjeta.Text = "N° Tarjeta:";
            // 
            // CBSelecionar
            // 
            this.CBSelecionar.FormattingEnabled = true;
            this.CBSelecionar.Location = new System.Drawing.Point(93, 30);
            this.CBSelecionar.Name = "CBSelecionar";
            this.CBSelecionar.Size = new System.Drawing.Size(120, 21);
            this.CBSelecionar.TabIndex = 25;
            this.CBSelecionar.SelectedIndexChanged += new System.EventHandler(this.CBSelecionar_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(93, 199);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(235, 52);
            this.txtDireccion.TabIndex = 24;
            // 
            // CBDistrito
            // 
            this.CBDistrito.FormattingEnabled = true;
            this.CBDistrito.Location = new System.Drawing.Point(92, 167);
            this.CBDistrito.Name = "CBDistrito";
            this.CBDistrito.Size = new System.Drawing.Size(121, 21);
            this.CBDistrito.TabIndex = 23;
            // 
            // CBProvincia
            // 
            this.CBProvincia.FormattingEnabled = true;
            this.CBProvincia.Location = new System.Drawing.Point(92, 140);
            this.CBProvincia.Name = "CBProvincia";
            this.CBProvincia.Size = new System.Drawing.Size(121, 21);
            this.CBProvincia.TabIndex = 22;
            // 
            // CBDepartamento
            // 
            this.CBDepartamento.FormattingEnabled = true;
            this.CBDepartamento.Location = new System.Drawing.Point(92, 115);
            this.CBDepartamento.Name = "CBDepartamento";
            this.CBDepartamento.Size = new System.Drawing.Size(121, 21);
            this.CBDepartamento.TabIndex = 21;
            // 
            // CBPais
            // 
            this.CBPais.FormattingEnabled = true;
            this.CBPais.Location = new System.Drawing.Point(92, 88);
            this.CBPais.Name = "CBPais";
            this.CBPais.Size = new System.Drawing.Size(121, 21);
            this.CBPais.TabIndex = 20;
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(44, 169);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 19;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(11, 118);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 18;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(32, 142);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 17;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(56, 90);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 16;
            this.lblPais.Text = "Pais:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(31, 199);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(17, 33);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(69, 13);
            this.lblSeleccionar.TabIndex = 0;
            this.lblSeleccionar.Text = "Seleccionar: ";
            // 
            // ModificarInfoFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 382);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.GBInfoFacturacion);
            this.Name = "ModificarInfoFacturacion";
            this.Text = "ModificarInfoFacturacion";
            this.GBInfoFacturacion.ResumeLayout(false);
            this.GBInfoFacturacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox GBInfoFacturacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox CBNTarjeta;
        private System.Windows.Forms.Label lblNTarjeta;
        private System.Windows.Forms.ComboBox CBSelecionar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox CBDistrito;
        private System.Windows.Forms.ComboBox CBProvincia;
        private System.Windows.Forms.ComboBox CBDepartamento;
        private System.Windows.Forms.ComboBox CBPais;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSeleccionar;
    }
}