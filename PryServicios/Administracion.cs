using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryServicios
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Usuario objUsuarios = new Usuario();
            dataGridView1.Rows.Clear();
            for (int i=0;i< Usuario.V_Contador; i++){
            dataGridView1.Rows.Add(Usuario.A_Nombres[i], Usuario.A_Apellidos[i], 
                                   Usuario.A_Telefono[i],Usuario.A_Email[i], 
                                   Usuario.A_Usuario[i], Usuario.A_Password[i]);
            }
        }
    }
}
