namespace PryServicios
{
    partial class Inmuebles
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
            this.GBUbicacion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCochera = new System.Windows.Forms.ComboBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.cbInmueble = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.txtPrecioIni = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.GBCondicionInmueble = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAniosFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAniosIni = new System.Windows.Forms.TextBox();
            this.lblAnios = new System.Windows.Forms.Label();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.dginmueble = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblResUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBUbicacion.SuspendLayout();
            this.GBCondicionInmueble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginmueble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBUbicacion
            // 
            this.GBUbicacion.Controls.Add(this.label5);
            this.GBUbicacion.Controls.Add(this.cbCochera);
            this.GBUbicacion.Controls.Add(this.txtPrecioFinal);
            this.GBUbicacion.Controls.Add(this.cbInmueble);
            this.GBUbicacion.Controls.Add(this.label6);
            this.GBUbicacion.Controls.Add(this.cbDistrito);
            this.GBUbicacion.Controls.Add(this.txtPrecioIni);
            this.GBUbicacion.Controls.Add(this.lblPrecio);
            this.GBUbicacion.Controls.Add(this.label3);
            this.GBUbicacion.Controls.Add(this.label2);
            this.GBUbicacion.Controls.Add(this.lblDistrito);
            this.GBUbicacion.Location = new System.Drawing.Point(12, 63);
            this.GBUbicacion.Name = "GBUbicacion";
            this.GBUbicacion.Size = new System.Drawing.Size(253, 245);
            this.GBUbicacion.TabIndex = 0;
            this.GBUbicacion.TabStop = false;
            this.GBUbicacion.Text = "Datos del inmueble";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "A";
            // 
            // cbCochera
            // 
            this.cbCochera.FormattingEnabled = true;
            this.cbCochera.Location = new System.Drawing.Point(100, 98);
            this.cbCochera.Name = "cbCochera";
            this.cbCochera.Size = new System.Drawing.Size(121, 21);
            this.cbCochera.TabIndex = 5;
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(175, 174);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(43, 20);
            this.txtPrecioFinal.TabIndex = 16;
            this.txtPrecioFinal.TextChanged += new System.EventHandler(this.txtPrecioFinal_TextChanged);
            // 
            // cbInmueble
            // 
            this.cbInmueble.FormattingEnabled = true;
            this.cbInmueble.Location = new System.Drawing.Point(100, 24);
            this.cbInmueble.Name = "cbInmueble";
            this.cbInmueble.Size = new System.Drawing.Size(121, 21);
            this.cbInmueble.TabIndex = 4;
            this.cbInmueble.SelectedIndexChanged += new System.EventHandler(this.cbInmueble_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "de";
            // 
            // cbDistrito
            // 
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Location = new System.Drawing.Point(100, 58);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(121, 21);
            this.cbDistrito.TabIndex = 3;
            this.cbDistrito.SelectedIndexChanged += new System.EventHandler(this.cbDistrito_SelectedIndexChanged);
            // 
            // txtPrecioIni
            // 
            this.txtPrecioIni.Location = new System.Drawing.Point(81, 175);
            this.txtPrecioIni.Name = "txtPrecioIni";
            this.txtPrecioIni.Size = new System.Drawing.Size(43, 20);
            this.txtPrecioIni.TabIndex = 14;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 152);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(92, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Rango de Precios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Con Cochera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de inmueble";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(52, 66);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(39, 13);
            this.lblDistrito.TabIndex = 0;
            this.lblDistrito.Text = "Distrito";
            // 
            // GBCondicionInmueble
            // 
            this.GBCondicionInmueble.Controls.Add(this.label4);
            this.GBCondicionInmueble.Controls.Add(this.txtAniosFin);
            this.GBCondicionInmueble.Controls.Add(this.label1);
            this.GBCondicionInmueble.Controls.Add(this.txtAniosIni);
            this.GBCondicionInmueble.Controls.Add(this.lblAnios);
            this.GBCondicionInmueble.Controls.Add(this.cbCondicion);
            this.GBCondicionInmueble.Controls.Add(this.lblCondicion);
            this.GBCondicionInmueble.Location = new System.Drawing.Point(298, 63);
            this.GBCondicionInmueble.Name = "GBCondicionInmueble";
            this.GBCondicionInmueble.Size = new System.Drawing.Size(244, 245);
            this.GBCondicionInmueble.TabIndex = 1;
            this.GBCondicionInmueble.TabStop = false;
            this.GBCondicionInmueble.Text = "Condicion del inmueble";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "A";
            // 
            // txtAniosFin
            // 
            this.txtAniosFin.Location = new System.Drawing.Point(174, 98);
            this.txtAniosFin.Name = "txtAniosFin";
            this.txtAniosFin.Size = new System.Drawing.Size(43, 20);
            this.txtAniosFin.TabIndex = 11;
            this.txtAniosFin.TextChanged += new System.EventHandler(this.txtAniosFin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "de";
            // 
            // txtAniosIni
            // 
            this.txtAniosIni.Location = new System.Drawing.Point(80, 99);
            this.txtAniosIni.Name = "txtAniosIni";
            this.txtAniosIni.Size = new System.Drawing.Size(43, 20);
            this.txtAniosIni.TabIndex = 9;
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Location = new System.Drawing.Point(6, 76);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(103, 13);
            this.lblAnios.TabIndex = 8;
            this.lblAnios.Text = "Años de Antiguedad";
            // 
            // cbCondicion
            // 
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Location = new System.Drawing.Point(115, 36);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(121, 21);
            this.cbCondicion.TabIndex = 7;
            this.cbCondicion.SelectedIndexChanged += new System.EventHandler(this.cbCondicion_SelectedIndexChanged);
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(55, 39);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 6;
            this.lblCondicion.Text = "Condicion";
            // 
            // dginmueble
            // 
            this.dginmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginmueble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5});
            this.dginmueble.Location = new System.Drawing.Point(53, 369);
            this.dginmueble.Name = "dginmueble";
            this.dginmueble.Size = new System.Drawing.Size(632, 150);
            this.dginmueble.TabIndex = 3;
            // 
            // c1
            // 
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "Tipo de Inmueble";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "Distrito";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "Cochera";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "Precio";
            this.c5.Name = "c5";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(685, 325);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 38);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Ver detalle";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(630, 335);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(49, 20);
            this.txtid.TabIndex = 5;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(780, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 13);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblResUsuario
            // 
            this.lblResUsuario.AutoSize = true;
            this.lblResUsuario.Location = new System.Drawing.Point(831, 9);
            this.lblResUsuario.Name = "lblResUsuario";
            this.lblResUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblResUsuario.TabIndex = 7;
            this.lblResUsuario.Text = ".............";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seleccion de Inmueble";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryServicios.Properties.Resources.depa;
            this.pictureBox1.Location = new System.Drawing.Point(556, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Inmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 535);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblResUsuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dginmueble);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBCondicionInmueble);
            this.Controls.Add(this.GBUbicacion);
            this.Name = "Inmuebles";
            this.Text = "Inmuebles";
            this.Load += new System.EventHandler(this.Inmuebles_Load);
            this.GBUbicacion.ResumeLayout(false);
            this.GBUbicacion.PerformLayout();
            this.GBCondicionInmueble.ResumeLayout(false);
            this.GBCondicionInmueble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginmueble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBUbicacion;
        private System.Windows.Forms.GroupBox GBCondicionInmueble;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dginmueble;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCochera;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.ComboBox cbInmueble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.TextBox txtPrecioIni;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAniosFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAniosIni;
        private System.Windows.Forms.Label lblAnios;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblResUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
    }
}