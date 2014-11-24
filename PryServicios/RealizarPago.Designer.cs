namespace PryServicios
{
    partial class RealizarPago
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
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblResUsuario = new System.Windows.Forms.Label();
            this.GBMetodoDePago = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.CBTarjetaCredito = new System.Windows.Forms.ComboBox();
            this.lblTarjetaCredito = new System.Windows.Forms.Label();
            this.GBDetalleTarjeta = new System.Windows.Forms.GroupBox();
            this.lblResNumero = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblResVencimiento = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblResTipo = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.lblResTarjeta = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.GBInfodeCompra = new System.Windows.Forms.GroupBox();
            this.lblDCompra = new System.Windows.Forms.Label();
            this.lblResValorCompra = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblitem = new System.Windows.Forms.Label();
            this.GBMetodoDePago.SuspendLayout();
            this.GBDetalleTarjeta.SuspendLayout();
            this.GBInfodeCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCompra.Location = new System.Drawing.Point(228, 336);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(155, 41);
            this.btnConfirmarCompra.TabIndex = 0;
            this.btnConfirmarCompra.Text = "Confirmar Compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(499, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.Location = new System.Drawing.Point(551, 19);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(64, 13);
            this.lblResUsuario.TabIndex = 2;
            this.lblResUsuario.Text = "...................";
            // 
            // GBMetodoDePago
            // 
            this.GBMetodoDePago.Controls.Add(this.txtMonto);
            this.GBMetodoDePago.Controls.Add(this.lblMonto);
            this.GBMetodoDePago.Controls.Add(this.CBTarjetaCredito);
            this.GBMetodoDePago.Controls.Add(this.lblTarjetaCredito);
            this.GBMetodoDePago.Location = new System.Drawing.Point(29, 172);
            this.GBMetodoDePago.Name = "GBMetodoDePago";
            this.GBMetodoDePago.Size = new System.Drawing.Size(282, 123);
            this.GBMetodoDePago.TabIndex = 3;
            this.GBMetodoDePago.TabStop = false;
            this.GBMetodoDePago.Text = "Seleccionar Metodo de Pago";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(106, 70);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(91, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(56, 77);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto:";
            // 
            // CBTarjetaCredito
            // 
            this.CBTarjetaCredito.FormattingEnabled = true;
            this.CBTarjetaCredito.Location = new System.Drawing.Point(106, 30);
            this.CBTarjetaCredito.Name = "CBTarjetaCredito";
            this.CBTarjetaCredito.Size = new System.Drawing.Size(162, 21);
            this.CBTarjetaCredito.TabIndex = 1;
            this.CBTarjetaCredito.SelectedIndexChanged += new System.EventHandler(this.CBTarjetaCredito_SelectedIndexChanged);
            // 
            // lblTarjetaCredito
            // 
            this.lblTarjetaCredito.AutoSize = true;
            this.lblTarjetaCredito.Location = new System.Drawing.Point(6, 38);
            this.lblTarjetaCredito.Name = "lblTarjetaCredito";
            this.lblTarjetaCredito.Size = new System.Drawing.Size(94, 13);
            this.lblTarjetaCredito.TabIndex = 0;
            this.lblTarjetaCredito.Text = "Tarjeta de Crédito:";
            // 
            // GBDetalleTarjeta
            // 
            this.GBDetalleTarjeta.Controls.Add(this.lblResNumero);
            this.GBDetalleTarjeta.Controls.Add(this.lblNumero);
            this.GBDetalleTarjeta.Controls.Add(this.lblResVencimiento);
            this.GBDetalleTarjeta.Controls.Add(this.lblVencimiento);
            this.GBDetalleTarjeta.Controls.Add(this.lblResTipo);
            this.GBDetalleTarjeta.Controls.Add(this.lblTipoTarjeta);
            this.GBDetalleTarjeta.Controls.Add(this.lblResTarjeta);
            this.GBDetalleTarjeta.Controls.Add(this.lblTarjeta);
            this.GBDetalleTarjeta.Location = new System.Drawing.Point(359, 172);
            this.GBDetalleTarjeta.Name = "GBDetalleTarjeta";
            this.GBDetalleTarjeta.Size = new System.Drawing.Size(233, 147);
            this.GBDetalleTarjeta.TabIndex = 4;
            this.GBDetalleTarjeta.TabStop = false;
            this.GBDetalleTarjeta.Text = "Detalle de Tarjeta";
            // 
            // lblResNumero
            // 
            this.lblResNumero.AutoSize = true;
            this.lblResNumero.Location = new System.Drawing.Point(95, 77);
            this.lblResNumero.Name = "lblResNumero";
            this.lblResNumero.Size = new System.Drawing.Size(52, 13);
            this.lblResNumero.TabIndex = 7;
            this.lblResNumero.Text = "...............";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(28, 77);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "N° Tarjeta:";
            // 
            // lblResVencimiento
            // 
            this.lblResVencimiento.AutoSize = true;
            this.lblResVencimiento.Location = new System.Drawing.Point(92, 101);
            this.lblResVencimiento.Name = "lblResVencimiento";
            this.lblResVencimiento.Size = new System.Drawing.Size(52, 13);
            this.lblResVencimiento.TabIndex = 5;
            this.lblResVencimiento.Text = "...............";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(6, 101);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(80, 13);
            this.lblVencimiento.TabIndex = 4;
            this.lblVencimiento.Text = "F. Vencimiento:";
            // 
            // lblResTipo
            // 
            this.lblResTipo.AutoSize = true;
            this.lblResTipo.Location = new System.Drawing.Point(92, 54);
            this.lblResTipo.Name = "lblResTipo";
            this.lblResTipo.Size = new System.Drawing.Size(55, 13);
            this.lblResTipo.TabIndex = 3;
            this.lblResTipo.Text = "................";
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(55, 54);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(31, 13);
            this.lblTipoTarjeta.TabIndex = 2;
            this.lblTipoTarjeta.Text = "Tipo:";
            // 
            // lblResTarjeta
            // 
            this.lblResTarjeta.AutoSize = true;
            this.lblResTarjeta.Location = new System.Drawing.Point(92, 31);
            this.lblResTarjeta.Name = "lblResTarjeta";
            this.lblResTarjeta.Size = new System.Drawing.Size(52, 13);
            this.lblResTarjeta.TabIndex = 1;
            this.lblResTarjeta.Text = "...............";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(43, 30);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(43, 13);
            this.lblTarjeta.TabIndex = 0;
            this.lblTarjeta.Text = "Tarjeta:";
            // 
            // GBInfodeCompra
            // 
            this.GBInfodeCompra.Controls.Add(this.lblDCompra);
            this.GBInfodeCompra.Controls.Add(this.lblResValorCompra);
            this.GBInfodeCompra.Controls.Add(this.lblValorCompra);
            this.GBInfodeCompra.Controls.Add(this.lblitem);
            this.GBInfodeCompra.Location = new System.Drawing.Point(76, 35);
            this.GBInfodeCompra.Name = "GBInfodeCompra";
            this.GBInfodeCompra.Size = new System.Drawing.Size(407, 111);
            this.GBInfodeCompra.TabIndex = 5;
            this.GBInfodeCompra.TabStop = false;
            this.GBInfodeCompra.Text = "Información de la compra";
            this.GBInfodeCompra.Enter += new System.EventHandler(this.GBInfodeCompra_Enter);
            // 
            // lblDCompra
            // 
            this.lblDCompra.AutoSize = true;
            this.lblDCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDCompra.Location = new System.Drawing.Point(33, 35);
            this.lblDCompra.Name = "lblDCompra";
            this.lblDCompra.Size = new System.Drawing.Size(117, 13);
            this.lblDCompra.TabIndex = 6;
            this.lblDCompra.Text = "Datos de la compra";
            // 
            // lblResValorCompra
            // 
            this.lblResValorCompra.AutoSize = true;
            this.lblResValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResValorCompra.Location = new System.Drawing.Point(300, 62);
            this.lblResValorCompra.Name = "lblResValorCompra";
            this.lblResValorCompra.Size = new System.Drawing.Size(60, 24);
            this.lblResValorCompra.TabIndex = 5;
            this.lblResValorCompra.Text = "..........";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(280, 35);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(113, 13);
            this.lblValorCompra.TabIndex = 4;
            this.lblValorCompra.Text = "Valor de la compra";
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitem.Location = new System.Drawing.Point(18, 66);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(149, 20);
            this.lblitem.TabIndex = 0;
            this.lblitem.Text = "............................";
            // 
            // RealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 406);
            this.Controls.Add(this.GBInfodeCompra);
            this.Controls.Add(this.GBDetalleTarjeta);
            this.Controls.Add(this.GBMetodoDePago);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Name = "RealizarPago";
            this.Text = "Metodo de Pago";
            this.Load += new System.EventHandler(this.RealizarPago_Load);
            this.GBMetodoDePago.ResumeLayout(false);
            this.GBMetodoDePago.PerformLayout();
            this.GBDetalleTarjeta.ResumeLayout(false);
            this.GBDetalleTarjeta.PerformLayout();
            this.GBInfodeCompra.ResumeLayout(false);
            this.GBInfodeCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.GroupBox GBMetodoDePago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox CBTarjetaCredito;
        private System.Windows.Forms.Label lblTarjetaCredito;
        private System.Windows.Forms.GroupBox GBDetalleTarjeta;
        private System.Windows.Forms.Label lblResNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblResVencimiento;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblResTipo;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label lblResTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.GroupBox GBInfodeCompra;
        private System.Windows.Forms.Label lblResValorCompra;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Label lblDCompra;
    }
}