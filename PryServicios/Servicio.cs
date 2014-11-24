using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Servicio
    {
        public static int v_contador = 0;
        public static int[] A_ID = new int[100];
        public static string[] A_nombre = new string[100];
        public static int[] A_anios = new int[100];
        public static int[] A_precio = new int[100];
        public static string[] A_especialidad = new string[100];

        public void RegistrarServicio(int p_id, string p_nombre,int p_anios, int p_precio, string p_especialidad) {

            A_ID[v_contador] = p_id;
            A_nombre[v_contador] = p_nombre;
            A_anios[v_contador] = p_anios;
            A_precio[v_contador] = p_precio;
            A_especialidad[v_contador] = p_especialidad;
            v_contador++;

        }
    }
}
