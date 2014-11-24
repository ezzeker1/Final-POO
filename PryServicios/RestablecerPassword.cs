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
    public partial class RestablecerPassword : Form
    {
        public RestablecerPassword()
        {
            InitializeComponent();
            btnRestablecer.Hide();
            lblNuevaPass.Hide();
            lblReingresarPass.Hide();
            txtNuevaPass.Hide();
            txtReingresarNuevaPass.Hide();
        }

        int v_ubicacion = 0;

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string v_respuesta = "";
            int v_edad = 0;

            v_respuesta = txtRespuestaSecreta.Text;
            v_edad = Int32.Parse(txtEdad.Text);

           if (txtReingresarNuevaPass.Text == txtNuevaPass.Text)
           {
               DialogResult D_Resultado = MessageBox.Show("Esta seguro que desea moficiar la contraseña?", "Mensaje de ServiFull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
               if (D_Resultado == DialogResult.Yes){
               Usuario.A_Password[v_ubicacion] = txtNuevaPass.Text;
               MessageBox.Show("Se modifico la contraseña Correctamente", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
               }
               else if ( D_Resultado == DialogResult.No)
               {
                   MessageBox.Show("No se realizo ningun cambio", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
           }
           else
           {
               MessageBox.Show("Las contraseñas ingresadas no coinciden", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           }
            
        }

        private void txtReingresarNuevaPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNuevaPass_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevaPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReingresarPass_Click(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            Validar ObjValidar = new Validar();

            string v_respuesta = "", v_usuario = "";
            int v_edad = 0, v_resultado = 0,
                v_C_usuario = 0;

            v_respuesta = txtRespuestaSecreta.Text.ToLower();
            v_edad = Int32.Parse(txtEdad.Text);
            v_usuario = txtUsuario.Text.ToLower();

            v_C_usuario = ObjValidar.ValidarSiexisteUsuario(v_usuario);

            if (v_C_usuario == 1) 
            { 
            for (int i = 0; i < Usuario.V_Contador; i++)
            {
                if (v_respuesta == Usuario.A_PreguntaSecreta[i] && v_edad == Usuario.A_Edad[i] && v_usuario == Usuario.A_Usuario[i])
                {
                    lblNuevaPass.Show();
                    lblReingresarPass.Show();
                    txtNuevaPass.Show();
                    txtReingresarNuevaPass.Show();
                    btnRestablecer.Show();
                    v_resultado = 1;
                    v_ubicacion = i;
                    break;
                }
                else {
                    v_resultado = 2;
                }
            }
            if (v_resultado == 2) {
                MessageBox.Show("Los datos ingresados no coinciden con ninguno almacenado en el sistema", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            }
            else if (v_C_usuario == 2) 
            {
                MessageBox.Show("El usuario ingresado no existe en el sistema", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
