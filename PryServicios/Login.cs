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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //========================================================================================================
            //============================== Cargar al usuario admin en el sistema ===================================
            //========================================================================================================
            Usuario.A_Usuario[0] = "admin";
            Usuario.A_Password[0] = "pass";
            Usuario.A_Permisos[0] = 2;
            Usuario.A_Nombres[0] = "Bryan Omar";
            Usuario.A_Apellidos[0] = "Ramirez Chavez";
            Usuario.A_Telefono[0] = "989773746";
            Usuario.A_Email[0] = "bryan@ezzeker.com";
            //========================================================================================================
        }

        Usuario ObjUsuario = new Usuario();
        Validar ObjValidar = new Validar();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            RegistroUsuario  ObjRegistrarUsuario = new RegistroUsuario();  //Crear Objeto para Manipular datos ese Form
            Administracion   ObjAdministracion   = new Administracion();   //Crear Objeto para Manipular datos ese Form
            ServiciosGeneral ObjServicioGeneral  = new ServiciosGeneral(); //Crear Objeto para Manipular datos ese Form
            
            string v_usuario = "";  //Variable que va a almacenar al usuario ingresado
            int v_resultado1 = 0,  //Determina si el usuario existe(1) o no(2), 
                v_resultado2 = 0,  /*Almacenara los permisos del usuario seleccionado
                                    * Administrador = 1
                                    * Usuario = 2
                                    */
                v_Cpassword = 0, //almacena la cantidad de caracteres de la contraseña
                v_CUsuario = 0;  //Almacena la cantidad de caracteres del usuario

            v_Cpassword = txtPassword.TextLength; //Asignación de Valores
            v_CUsuario = txtUsuario.TextLength; //Asignación de Valores

            if (v_CUsuario == 0){ // 0 = No se ha ingresado un usuario
                MessageBox.Show("Debe completar el campo de Usuario", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (v_Cpassword == 0){ // 0 = no se ha escrito la contraseña
                MessageBox.Show("Debe completar el campo de Contraseña", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (v_CUsuario > 0 && v_Cpassword > 0)
            { // Se escribieron contraseña y password

                v_usuario = txtUsuario.Text.ToLower();  //Pasar a Minusculas el Usuario
                ObjServicioGeneral.vuser = txtUsuario.Text; //Enviar el usuario a el Form ServicioGeneral
                v_resultado1 = ObjValidar.ValidarUsuarioPassword(v_usuario, txtPassword.Text); //ASigna el valor
                v_resultado2 = ObjUsuario.ObtenerPermisos(v_usuario); //Asigna e valor
                
                if (v_resultado1 == 1) // 1 = Existe el usuario
                {
                    if (v_resultado2 == 1) { // 1 = el usuario es Administrador
                        ObjAdministracion.Show(); // Abre el form de Administración
                    }
                    else if (v_resultado2 == 2) { // 2 = El usuario tiene Permisos de Usuario 
                        ObjServicioGeneral.Show();
                    }
                }
                else{   // No existe el usuario
                    MessageBox.Show("El usuario O password ingresado no es correcto", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Administracion ObjAdministracion = new Administracion(); //instanciar el Form

            ObjAdministracion.Show(); //Ingresar al Form
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPassword ObjRestablecer = new RestablecerPassword();  //instanciar el Form
            ObjRestablecer.Show(); // Ingresar al Form
        }

        private void btnCrearusuario_Click(object sender, EventArgs e)
        {
            RegistroUsuario ObjRegistroU = new RegistroUsuario();  //instanciar el Form
             
            ObjRegistroU.Show(); //Ingresar al Form
        }
    }
}
