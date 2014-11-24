using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Tarjeta
    {
        public static string[] A_numero = new string[100];
        public static string[] A_Anio = new string[100];
        public static string[] A_Mes = new string[100];
        public static string[] A_Titular = new string[100];
        public static string[] A_Proveedor = new string[100];
        public static string[] A_Tipo = new string[100];
        public static string[] A_usuario = new string[100];
        public static int V_Contador = 0;

        public static string ValidarNTarjeta(string p_ntarjeta, string p_proveedor) {
            string v_resultado = "0";
            int V_extraccion = 0;

            if (p_ntarjeta.Length == 16)
            {
                V_extraccion = Int32.Parse(p_ntarjeta.Substring(0, 1));

                if (p_proveedor == "Visa" && V_extraccion != 4)
                {
                    v_resultado = "Las Tarjetas Visa Deben de Comenzar con 4";
                }
                else if (p_proveedor == "MasterCard")
                {
                    int v_contador2 = 5, v_numero1 = 50;
                    V_extraccion = Int32.Parse(p_ntarjeta.Substring(0, 2));

                    for (int i = 1; i <= v_contador2; i++)
                    {
                        v_numero1 = v_numero1 + 1;
                        if (V_extraccion != v_numero1)
                        {
                            v_resultado = "Las Tarjetas MasterCard Deben de comenzar con 51 a 55";
                        }
                        else if (V_extraccion == v_numero1) {
                            break;
                        }
                    }
                }
                else 
                    if (p_proveedor == "American Express")
                {
                    int v_contador2 = 2, v_numero2 = 34;
                    V_extraccion = Int32.Parse(p_ntarjeta.Substring(0, 2));

                    for (int i = 1; i <= v_contador2; i++)
                    {
                        if (V_extraccion != v_numero2)
                        {
                            v_resultado = "Las Tarjetas American Express Deben de comenzar con 34 o 37";
                            v_numero2 = v_numero2 + 3;
                        }
                        else if (V_extraccion == v_numero2) {
                            break;
                        }
                        
                    }
                }
            }
            else v_resultado = "La tarjeta debe de tener 16 digitos para que sea valida";
  
            return v_resultado;
        }
    }
}
