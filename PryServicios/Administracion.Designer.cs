namespace PryServicios
{
    partial class Administracion
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
            this.btnListar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBUsuario = new System.Windows.Forms.GroupBox();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.GBAdministrativo = new System.Windows.Forms.GroupBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GBUsuario.SuspendLayout();
            this.GBAdministrativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(33, 239);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6});
            this.dataGridView1.Location = new System.Drawing.Point(21, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // c1
            // 
            this.c1.HeaderText = "Nombres";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "Apellidos";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "Telefono";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "Email";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "Usuario";
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.HeaderText = "Password";
            this.c6.Name = "c6";
            // 
            // GBUsuario
            // 
            this.GBUsuario.Controls.Add(this.btnCrear);
            this.GBUsuario.Location = new System.Drawing.Point(21, 22);
            this.GBUsuario.Name = "GBUsuario";
            this.GBUsuario.Size = new System.Drawing.Size(300, 177);
            this.GBUsuario.TabIndex = 2;
            this.GBUsuario.TabStop = false;
            this.GBUsuario.Text = "Acciones para los Usuarios";
            // 
            // btnPermisos
            // 
            this.btnPermisos.Location = new System.Drawing.Point(115, 28);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(114, 23);
            this.btnPermisos.TabIndex = 0;
            this.btnPermisos.Text = "Modificar Permisos";
            this.btnPermisos.UseVisualStyleBackColor = true;
            // 
            // GBAdministrativo
            // 
            this.GBAdministrativo.Controls.Add(this.btnPermisos);
            this.GBAdministrativo.Controls.Add(this.btnLog);
            this.GBAdministrativo.Location = new System.Drawing.Point(414, 22);
            this.GBAdministrativo.Name = "GBAdministrativo";
            this.GBAdministrativo.Size = new System.Drawing.Size(253, 177);
            this.GBAdministrativo.TabIndex = 3;
            this.GBAdministrativo.TabStop = false;
            this.GBAdministrativo.Text = "Funciones Administrativas";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(16, 28);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 27);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 491);
            this.Controls.Add(this.GBAdministrativo);
            this.Controls.Add(this.GBUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListar);
            this.Name = "Administracion";
            this.Text = "Administracion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GBUsuario.ResumeLayout(false);
            this.GBAdministrativo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.GroupBox GBUsuario;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.GroupBox GBAdministrativo;
        private System.Windows.Forms.Button btnLog;
    }
}