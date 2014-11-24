using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Usuario
    {
        public static string[] A_Usuario = new string[100];
        public static string[] A_Nombres = new string[100];
        public static string[] A_Apellidos = new string[100];
        public static string[] A_Password = new string[100];
        public static string[] A_Email = new string[100];
        public static string[] A_Telefono = new string[100];
        public static int[] A_Edad = new int[100];
        public static string[] A_PreguntaSecreta = new string[100];
        public static int[] A_Permisos = new int[100];
        public static int V_Contador = 1;

        /*
         * Permisos en la aplicacion:
         * Administrador: 1 
         * Usuario : 2 
         * Proveedor: 3
         */

        public int ObtenerPermisos(string p_usuario) {
            int v_resultado = 0;

            for (int i = 0; i < V_Contador; i++ ){
            if (p_usuario == A_Usuario[i]){
                v_resultado = A_Permisos[i];
            }
            }
                return v_resultado;
        }

        public static int PosicionUsuario(string p_usuario) {
            int v_posicion = -1;

            for (int i = 0; i <= Usuario.V_Contador; i++)
            {
                if (p_usuario == Usuario.A_Usuario[i]) {
                    v_posicion = i;
                }
            }
                return v_posicion;
        }

    }
}
