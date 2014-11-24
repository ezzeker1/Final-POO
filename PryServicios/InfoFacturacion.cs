using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class InfoFacturacion
    {
        public static string[] A_usuario = new string[100];
        public static int[] A_Predeterminado = new int[100]; /*1 = Predeterminado 
                                                              *2 = Alternativa 
                                                              */
        public static string[] A_NTarjeta = new string[100];
        public static string[] A_Pais = new string[100];
        public static string[] A_Departamento = new string[100];
        public static string[] A_Provincia = new string[100];
        public static string[] A_Distrito = new string[100];
        public static string[] A_Direccion = new string[100];
        public static int V_Contador = 0;

        public static string ValidarInfoFacturacion(string p_predeterminado, string p_ntarjeta, string p_pais, string p_departamento, string p_provincia,string p_distrito, string p_direccion)
        {
            //Declaración de Variables para el botón
            int V_C_Predeterminado = 0,
                V_C_NTarjeta = 0,
                v_C_Pais = 0,
                V_C_Departamento = 0,
                V_C_Provincia = 0,
                V_C_Distrito = 0,
                V_C_Direccion = 0;
            string v_mensaje = "0";

            V_C_Predeterminado = p_predeterminado.Length;
            V_C_NTarjeta = p_ntarjeta.Length;
            v_C_Pais = p_pais.Length;
            V_C_Departamento = p_departamento.Length;
            V_C_Provincia = p_provincia.Length;
            V_C_Distrito = p_distrito.Length;
            V_C_Direccion = p_direccion.Length;

            if (V_C_Predeterminado == 0) {
                v_mensaje = "Debe Seleccionar si la información es predeterminado o alternativa";
            }
            else if(V_C_NTarjeta == 0)
            {
                v_mensaje = "Debe Seleccionar una tarjeta para que se registre su información de Facturación";
             }
            else if(v_C_Pais == 0)
            {
                v_mensaje = "Debe Seleccionar un Pais para que se registre su información de Facturación";
            }
            else if(V_C_Departamento == 0)
            {
                v_mensaje = "Debe Seleccionar un Departamento para que se registre su información de Facturación";
            }
            else if(V_C_Provincia == 0)
            {
                v_mensaje = "Debe Seleccionar una Provincia para que se registre su información de Facturación";
            }    
            else if(V_C_Distrito == 0)
            {
                v_mensaje = "Debe Seleccionar un distrito para que se registre su información de Facturación";
            }
            else if(V_C_Direccion == 0)
            {
                v_mensaje = "Debe Completar su Dirección para finalizar el registro de us información de Facturación";
            }    
                return v_mensaje;
        }

    }
}
