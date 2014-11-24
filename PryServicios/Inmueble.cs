using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Inmueble
    {
        public static int[] A_ID = new int[100];
        public static string[] A_Tipo = new string[100];
        public static int[] A_Anios = new int[100];
        public static int[] A_Precio = new int[100];
        public static string[] A_cochera = new string[100];
        public static string[] a_Direccion = new string[100];
        public static string[] a_Distrito = new string[100];
        public static string[] a_condicion = new string[100];
        public static int v_contador = 0;

        public void RegistrarInmueble(int p_id, string p_tipo, int p_anios, int p_precio, string p_cochera, string p_direccion, string p_distrito, string p_condicion) {

            A_ID[v_contador] = p_id;
            A_Tipo[v_contador] = p_tipo;
            A_Anios[v_contador] = p_anios;
            A_Precio[v_contador] = p_precio;
            A_cochera[v_contador] = p_cochera;
            a_Distrito[v_contador] = p_distrito;
            a_Direccion[v_contador] = p_direccion;
            a_condicion[v_contador] = p_condicion;
            v_contador++;
        }

    }
}
