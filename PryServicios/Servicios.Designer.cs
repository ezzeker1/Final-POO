namespace PryServicios
{
    partial class Servicios
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
            this.DGServicio = new System.Windows.Forms.DataGridView();
            this.GBDatosdeServicio = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioIni = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.GBDetallePersona = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaniosfin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAniosini = new System.Windows.Forms.TextBox();
            this.lbAnios = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblResUsuario = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGServicio)).BeginInit();
            this.GBDatosdeServicio.SuspendLayout();
            this.GBDetallePersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGServicio
            // 
            this.DGServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c5,
            this.c2,
            this.c3,
            this.c4});
            this.DGServicio.Location = new System.Drawing.Point(90, 313);
            this.DGServicio.Name = "DGServicio";
            this.DGServicio.Size = new System.Drawing.Size(644, 150);
            this.DGServicio.TabIndex = 1;
            // 
            // GBDatosdeServicio
            // 
            this.GBDatosdeServicio.Controls.Add(this.label2);
            this.GBDatosdeServicio.Controls.Add(this.txtPrecioFin);
            this.GBDatosdeServicio.Controls.Add(this.label1);
            this.GBDatosdeServicio.Controls.Add(this.txtPrecioIni);
            this.GBDatosdeServicio.Controls.Add(this.lblPrecio);
            this.GBDatosdeServicio.Controls.Add(this.cbTipo);
            this.GBDatosdeServicio.Controls.Add(this.lblTipo);
            this.GBDatosdeServicio.Location = new System.Drawing.Point(33, 85);
            this.GBDatosdeServicio.Name = "GBDatosdeServicio";
            this.GBDatosdeServicio.Size = new System.Drawing.Size(234, 172);
            this.GBDatosdeServicio.TabIndex = 2;
            this.GBDatosdeServicio.TabStop = false;
            this.GBDatosdeServicio.Text = "Datos de Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A";
            // 
            // txtPrecioFin
            // 
            this.txtPrecioFin.Location = new System.Drawing.Point(143, 112);
            this.txtPrecioFin.Name = "txtPrecioFin";
            this.txtPrecioFin.Size = new System.Drawing.Size(44, 20);
            this.txtPrecioFin.TabIndex = 5;
            this.txtPrecioFin.TextChanged += new System.EventHandler(this.txtPrecioFin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DE";
            // 
            // txtPrecioIni
            // 
            this.txtPrecioIni.Location = new System.Drawing.Point(48, 112);
            this.txtPrecioIni.Name = "txtPrecioIni";
            this.txtPrecioIni.Size = new System.Drawing.Size(44, 20);
            this.txtPrecioIni.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 86);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Honorarios:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(66, 35);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(32, 38);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // GBDetallePersona
            // 
            this.GBDetallePersona.Controls.Add(this.label4);
            this.GBDetallePersona.Controls.Add(this.txtaniosfin);
            this.GBDetallePersona.Controls.Add(this.label5);
            this.GBDetallePersona.Controls.Add(this.txtAniosini);
            this.GBDetallePersona.Controls.Add(this.lbAnios);
            this.GBDetallePersona.Location = new System.Drawing.Point(291, 85);
            this.GBDetallePersona.Name = "GBDetallePersona";
            this.GBDetallePersona.Size = new System.Drawing.Size(212, 172);
            this.GBDetallePersona.TabIndex = 3;
            this.GBDetallePersona.TabStop = false;
            this.GBDetallePersona.Text = "Detalles de la persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "A";
            // 
            // txtaniosfin
            // 
            this.txtaniosfin.Location = new System.Drawing.Point(157, 61);
            this.txtaniosfin.Name = "txtaniosfin";
            this.txtaniosfin.Size = new System.Drawing.Size(44, 20);
            this.txtaniosfin.TabIndex = 9;
            this.txtaniosfin.TextChanged += new System.EventHandler(this.txtaniosfin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DE";
            // 
            // txtAniosini
            // 
            this.txtAniosini.Location = new System.Drawing.Point(62, 61);
            this.txtAniosini.Name = "txtAniosini";
            this.txtAniosini.Size = new System.Drawing.Size(44, 20);
            this.txtAniosini.TabIndex = 7;
            // 
            // lbAnios
            // 
            this.lbAnios.AutoSize = true;
            this.lbAnios.Location = new System.Drawing.Point(21, 38);
            this.lbAnios.Name = "lbAnios";
            this.lbAnios.Size = new System.Drawing.Size(107, 13);
            this.lbAnios.TabIndex = 0;
            this.lbAnios.Text = "Años de Experiencia:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(744, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.Location = new System.Drawing.Point(796, 9);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(37, 13);
            this.lblResUsuario.TabIndex = 5;
            this.lblResUsuario.Text = "..........";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(524, 291);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(74, 13);
            this.lblServicio.TabIndex = 6;
            this.lblServicio.Text = "ID de Servicio";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(604, 284);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(51, 20);
            this.txtId.TabIndex = 7;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(661, 284);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(55, 23);
            this.btnIr.TabIndex = 8;
            this.btnIr.Text = "IR";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione un servicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryServicios.Properties.Resources.Services;
            this.pictureBox1.Location = new System.Drawing.Point(524, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // c1
            // 
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            // 
            // c5
            // 
            this.c5.FillWeight = 200F;
            this.c5.HeaderText = "Nombre";
            this.c5.Name = "c5";
            this.c5.Width = 200;
            // 
            // c2
            // 
            this.c2.HeaderText = "Tipo";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "Honorarios";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "Experiencia";
            this.c4.Name = "c4";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.GBDetallePersona);
            this.Controls.Add(this.GBDatosdeServicio);
            this.Controls.Add(this.DGServicio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGServicio)).EndInit();
            this.GBDatosdeServicio.ResumeLayout(false);
            this.GBDatosdeServicio.PerformLayout();
            this.GBDetallePersona.ResumeLayout(false);
            this.GBDetallePersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGServicio;
        private System.Windows.Forms.GroupBox GBDatosdeServicio;
        private System.Windows.Forms.GroupBox GBDetallePersona;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioIni;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaniosfin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAniosini;
        private System.Windows.Forms.Label lbAnios;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
    }
}