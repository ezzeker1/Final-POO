namespace PryServicios
{
    partial class RegistrarMetodoPago
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
            this.GBMetodoPago = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.txtNTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTxtUsuario = new System.Windows.Forms.Label();
            this.GBMetodoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBMetodoPago
            // 
            this.GBMetodoPago.Controls.Add(this.btnRegistrar);
            this.GBMetodoPago.Controls.Add(this.txtTitular);
            this.GBMetodoPago.Controls.Add(this.lblTitular);
            this.GBMetodoPago.Controls.Add(this.txtMes);
            this.GBMetodoPago.Controls.Add(this.txtAnio);
            this.GBMetodoPago.Controls.Add(this.lblMes);
            this.GBMetodoPago.Controls.Add(this.lblAnio);
            this.GBMetodoPago.Controls.Add(this.lblVencimiento);
            this.GBMetodoPago.Controls.Add(this.txtNTarjeta);
            this.GBMetodoPago.Controls.Add(this.lblTarjeta);
            this.GBMetodoPago.Controls.Add(this.CBProveedor);
            this.GBMetodoPago.Controls.Add(this.lblProveedor);
            this.GBMetodoPago.Controls.Add(this.CBTipo);
            this.GBMetodoPago.Controls.Add(this.lblTipo);
            this.GBMetodoPago.Location = new System.Drawing.Point(21, 49);
            this.GBMetodoPago.Name = "GBMetodoPago";
            this.GBMetodoPago.Size = new System.Drawing.Size(320, 382);
            this.GBMetodoPago.TabIndex = 0;
            this.GBMetodoPago.TabStop = false;
            this.GBMetodoPago.Text = "Método de Pago";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(95, 319);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(134, 31);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(23, 276);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(219, 20);
            this.txtTitular.TabIndex = 12;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(15, 237);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(164, 20);
            this.lblTitular.TabIndex = 11;
            this.lblTitular.Text = "Titular de la Tarjeta";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(139, 198);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(35, 20);
            this.txtMes.TabIndex = 10;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(51, 198);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(32, 20);
            this.txtAnio.TabIndex = 9;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(103, 201);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 8;
            this.lblMes.Text = "Mes:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(16, 201);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 7;
            this.lblAnio.Text = "Año:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(12, 163);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(188, 20);
            this.lblVencimiento.TabIndex = 6;
            this.lblVencimiento.Text = "Fecha de Vencimiento";
            // 
            // txtNTarjeta
            // 
            this.txtNTarjeta.Location = new System.Drawing.Point(77, 120);
            this.txtNTarjeta.Name = "txtNTarjeta";
            this.txtNTarjeta.Size = new System.Drawing.Size(121, 20);
            this.txtNTarjeta.TabIndex = 5;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(12, 120);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(58, 13);
            this.lblTarjeta.TabIndex = 4;
            this.lblTarjeta.Text = "N° Tarjeta:";
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(77, 80);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(121, 21);
            this.CBProveedor.TabIndex = 3;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(12, 83);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // CBTipo
            // 
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(77, 40);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(121, 21);
            this.CBTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(40, 43);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(289, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "................";
            // 
            // lblTxtUsuario
            // 
            this.lblTxtUsuario.AutoSize = true;
            this.lblTxtUsuario.Location = new System.Drawing.Point(237, 9);
            this.lblTxtUsuario.Name = "lblTxtUsuario";
            this.lblTxtUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblTxtUsuario.TabIndex = 2;
            this.lblTxtUsuario.Text = "Usuario:";
            // 
            // RegistrarMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 443);
            this.Controls.Add(this.lblTxtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.GBMetodoPago);
            this.Name = "RegistrarMetodoPago";
            this.Text = "Registrar Metodo de Pago";
            this.Load += new System.EventHandler(this.RegistrarMetodoPago_Load);
            this.GBMetodoPago.ResumeLayout(false);
            this.GBMetodoPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBMetodoPago;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.TextBox txtNTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTxtUsuario;
    }
}