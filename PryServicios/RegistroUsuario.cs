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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //================================================================================
            //========================== Declaración de Variables ============================
            //================================================================================
            string v_usuario = "";
            int v_resultado = 0, v_tusuario = 2,
                v_C_Usuario = 0,
                v_C_Nombre = 0,
                v_C_Apellido = 0,
                v_C_Email = 0,
                v_C_Telefono = 0,
                v_C_Password = 0,
                v_C_Respuesta = 0,
                v_C_Edad = 0;
          
            //================================================================================
            //========================== Asignación de Variables =============================
            //================================================================================
            v_C_Usuario = txtUsuairo.TextLength;
            v_C_Nombre = txtNombres.TextLength;
            v_C_Apellido = txtApellidos.TextLength;
            v_C_Telefono = txtTelefonos.TextLength;
            v_C_Email = txtEmail.TextLength;
            v_C_Password = txtPassword.TextLength;
            v_C_Edad = txtEdad.TextLength;
            v_C_Respuesta = txtRespuesta.TextLength;


            //================================================================================
            //=============================== Validaciones ===================================
            //================================================================================

            if (v_C_Usuario == 0) {
                MessageBox.Show("Es Obligatorio Completar el usuario para seguir con el registro", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (v_C_Nombre == 0) {
                MessageBox.Show("Debe ingresar su nombre para proceder con el registro", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (v_C_Apellido == 0) {
                MessageBox.Show("Debe completar su apellido para proceder con el registro", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (v_C_Telefono == 0) {
                MessageBox.Show("Es obligatorio que ingrese su Teléfono para seguir con el registro", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (v_C_Email == 0) {
                MessageBox.Show("Es obligatorio ingresar el Email para seguir con el registro", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (v_C_Password == 0) {
                MessageBox.Show("Es obligatorio ingresar una contraseña para proceder", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (v_C_Edad == 0) {
                MessageBox.Show("Debe ingresar su Edad para proceder con el registro", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (v_C_Respuesta == 0)
            {
                MessageBox.Show("Debe responder a la pregunta secreta para finalizar el registro", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                 // Si paso las Valicaciones anteriores Comienza el proceso de Registro
                v_usuario = txtUsuairo.Text.ToLower();

                for (int i = 0; i < Usuario.V_Contador; i++) //Este For Recorre el Arreglo de Usuarios tomando como limite el contador de la clase Usuarios
                {
                    if (Usuario.A_Usuario[i] == v_usuario) //Busca Si ya existe en el sistema el usuario que se ha ingresado
                    {
                        v_resultado = 1;
                    }
                    else v_resultado = 2;
                }
                if (v_resultado == 2)  //Si el usuario no existe, ingresa.....
                {
                    DialogResult D_Resultado = MessageBox.Show("Se va a crear el Usuario " + v_usuario + " Esta seguro que los datos ingresados son los correctos?", 
                                                               "Mensaje de ServiFull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (D_Resultado == DialogResult.Yes)
                    {
                        Usuario.A_Usuario[Usuario.V_Contador] = txtUsuairo.Text.ToLower();
                        Usuario.A_Password[Usuario.V_Contador] = txtPassword.Text;
                        Usuario.A_Nombres[Usuario.V_Contador] = txtNombres.Text.ToLower();
                        Usuario.A_Apellidos[Usuario.V_Contador] = txtApellidos.Text.ToLower();
                        Usuario.A_Telefono[Usuario.V_Contador] = txtTelefonos.Text;
                        Usuario.A_Edad[Usuario.V_Contador] = Int32.Parse(txtEdad.Text);
                        Usuario.A_PreguntaSecreta[Usuario.V_Contador] = txtRespuesta.Text.ToLower();
                        Usuario.A_Email[Usuario.V_Contador] = txtEmail.Text.ToLower();
                        Usuario.A_Permisos[Usuario.V_Contador] = v_tusuario;
                        Usuario.V_Contador++;

                        MessageBox.Show("Se registro Correcta el usuario " + v_usuario + " En el sistema",
                                        "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (D_Resultado == DialogResult.No) {
                        MessageBox.Show("No se realizo ninguna acción", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else  //Si el usuario Si existe Me muestra el siguiente mensaje.
                {
                    MessageBox.Show("El usuario " + v_usuario + " Ya se encuentra registrado en el sitema, ingrese uno diferente",
                                    "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
