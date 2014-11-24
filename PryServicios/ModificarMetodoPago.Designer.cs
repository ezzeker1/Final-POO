namespace PryServicios
{
    partial class ModificarMetodoPago
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
            this.GBMetodoPago = new System.Windows.Forms.GroupBox();
            this.CBNTarjeta = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtResTitular = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtResMes = new System.Windows.Forms.TextBox();
            this.txtResAnio = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.GBMetodoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.Location = new System.Drawing.Point(335, 9);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblResUsuario.TabIndex = 3;
            this.lblResUsuario.Text = "................";
            // 
            // GBMetodoPago
            // 
            this.GBMetodoPago.Controls.Add(this.CBNTarjeta);
            this.GBMetodoPago.Controls.Add(this.btnGuardar);
            this.GBMetodoPago.Controls.Add(this.txtResTitular);
            this.GBMetodoPago.Controls.Add(this.lblTitular);
            this.GBMetodoPago.Controls.Add(this.txtResMes);
            this.GBMetodoPago.Controls.Add(this.txtResAnio);
            this.GBMetodoPago.Controls.Add(this.lblMes);
            this.GBMetodoPago.Controls.Add(this.lblAnio);
            this.GBMetodoPago.Controls.Add(this.lblVencimiento);
            this.GBMetodoPago.Controls.Add(this.lblTarjeta);
            this.GBMetodoPago.Controls.Add(this.CBProveedor);
            this.GBMetodoPago.Controls.Add(this.lblProveedor);
            this.GBMetodoPago.Controls.Add(this.CBTipo);
            this.GBMetodoPago.Controls.Add(this.lblTipo);
            this.GBMetodoPago.Location = new System.Drawing.Point(29, 36);
            this.GBMetodoPago.Name = "GBMetodoPago";
            this.GBMetodoPago.Size = new System.Drawing.Size(361, 391);
            this.GBMetodoPago.TabIndex = 2;
            this.GBMetodoPago.TabStop = false;
            this.GBMetodoPago.Text = "Método de Pago";
            this.GBMetodoPago.Enter += new System.EventHandler(this.GBMetodoPago_Enter);
            // 
            // CBNTarjeta
            // 
            this.CBNTarjeta.FormattingEnabled = true;
            this.CBNTarjeta.Location = new System.Drawing.Point(84, 32);
            this.CBNTarjeta.Name = "CBNTarjeta";
            this.CBNTarjeta.Size = new System.Drawing.Size(192, 21);
            this.CBNTarjeta.TabIndex = 14;
            this.CBNTarjeta.SelectedIndexChanged += new System.EventHandler(this.CBNTarjeta_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(104, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 31);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtResTitular
            // 
            this.txtResTitular.Location = new System.Drawing.Point(17, 286);
            this.txtResTitular.Name = "txtResTitular";
            this.txtResTitular.Size = new System.Drawing.Size(219, 20);
            this.txtResTitular.TabIndex = 12;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(9, 247);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(164, 20);
            this.lblTitular.TabIndex = 11;
            this.lblTitular.Text = "Titular de la Tarjeta";
            // 
            // txtResMes
            // 
            this.txtResMes.Location = new System.Drawing.Point(137, 194);
            this.txtResMes.Name = "txtResMes";
            this.txtResMes.Size = new System.Drawing.Size(35, 20);
            this.txtResMes.TabIndex = 10;
            // 
            // txtResAnio
            // 
            this.txtResAnio.Location = new System.Drawing.Point(49, 194);
            this.txtResAnio.Name = "txtResAnio";
            this.txtResAnio.Size = new System.Drawing.Size(32, 20);
            this.txtResAnio.TabIndex = 9;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(101, 197);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 8;
            this.lblMes.Text = "Mes:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(14, 197);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 7;
            this.lblAnio.Text = "Año:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(10, 158);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(188, 20);
            this.lblVencimiento.TabIndex = 6;
            this.lblVencimiento.Text = "Fecha de Vencimiento";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(19, 32);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(58, 13);
            this.lblTarjeta.TabIndex = 4;
            this.lblTarjeta.Text = "N° Tarjeta:";
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(84, 110);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(121, 21);
            this.CBProveedor.TabIndex = 3;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(19, 113);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // CBTipo
            // 
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(84, 70);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(121, 21);
            this.CBTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(47, 73);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(283, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // ModificarMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 442);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.GBMetodoPago);
            this.Name = "ModificarMetodoPago";
            this.Text = "Modificar Metodo de Pago";
            this.Load += new System.EventHandler(this.ModificarMetodoPago_Load);
            this.GBMetodoPago.ResumeLayout(false);
            this.GBMetodoPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.GroupBox GBMetodoPago;
        private System.Windows.Forms.ComboBox CBNTarjeta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtResTitular;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtResMes;
        private System.Windows.Forms.TextBox txtResAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUsuario;
    }
}