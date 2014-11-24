using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Adquisiciones
    {
        public static int[]      A_ID              = new int[100];
        public static string[]   A_Tipoadquisicion = new string[100];
        public static string[]   A_Descripcion     = new string[100];
        public static int[]      A_Precio          = new int[100];
        public static DateTime[] A_Fecha           = new DateTime[100];
        public static string[]   A_Usuario         = new string[100];
        public static int        v_contador        = 0;

        public void RegistrarAdquisicion(int P_id, string p_TipoAdquisicion, string p_descripcion, int p_precio, DateTime p_fecha, string p_usuario) {
            A_ID[v_contador] = P_id;
            A_Tipoadquisicion[v_contador] = p_TipoAdquisicion;
            A_Descripcion[v_contador] = p_descripcion;
            A_Precio[v_contador] = p_precio;
            A_Fecha[v_contador] = p_fecha;
            A_Usuario[v_contador] = p_usuario;
            v_contador++;
                    
        }
    }
}
