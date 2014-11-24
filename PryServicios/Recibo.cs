using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Recibo
    {
        public static int[] A_ID = new int[100];
        public static string[] A_Usuario = new string[100];
        public static double[] A_Subtotal = new double[100];
        public static double[] A_Total = new double[100];
        public static string[] A_Serie = new string[100];
        public static string[] A_Numero = new string[100];
        public static string[] A_FEmision = new string[100];
        public static string[] A_FVencimento = new string[100];
        public static int v_Contador = 0;
        public static int V_IncialSerie = 1;
        public static int V_IncialNumero = 1500;

        public void RegistrarRecibo(int p_id, string p_usuario, string p_subtotal, string p_total) {
                                        A_FEmision[v_Contador] = DateTime.Now.Date.ToShortDateString();
                                        A_FVencimento[v_Contador] = DateTime.Now.Date.ToShortDateString();
                                        A_ID[v_Contador] = p_id;
                                        A_Numero[v_Contador] = (V_IncialNumero + v_Contador + 1).ToString();
                                        A_Serie[v_Contador] = V_IncialSerie.ToString();
                                        A_Subtotal[v_Contador] = Int32.Parse(p_subtotal);
                                        A_Total[v_Contador] = Int32.Parse(p_total);
                                        A_Usuario[v_Contador] = p_usuario;
                                        v_Contador++;
        }
     }
}
