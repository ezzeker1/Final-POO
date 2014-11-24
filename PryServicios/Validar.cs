using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryServicios
{
    class Validar
    {
       public int ValidarSiexisteUsuario(string p_usuario){
           /*
            * 0 = Valor inicial asignado
            * 1 = Si existe el usuario
            * 2 = No existe el usuario
            */

           int v_Resultado = 0;
           for (int i = 0; i <= Usuario.V_Contador; i++)
           {
               if (p_usuario == Usuario.A_Usuario[i])
               {
                   v_Resultado = 1;
                   break;
               }
               else v_Resultado = 2;
           }
           return v_Resultado;
       }

       public int ValidarUsuarioPassword(string p_usuario, string p_password)
       {
           int v_Resultado = 0;
           for (int i = 0; i <= Usuario.V_Contador; i++)
           {
               if (p_usuario == Usuario.A_Usuario[i] && p_password == Usuario.A_Password[i])
               {
                   v_Resultado = 1;
                   break;
               }
               else v_Resultado = 2;
           }
           return v_Resultado;
       }

       //public int ValidarEmail(string p_email){
       //    string  v_caracter = "@", v_letra = "";
       //    int v_contador = 0, v_respuesta = 0, v_longitud = 0;
       //    v_longitud = p_email.Length;
       //    for (int i = 0; i < v_longitud; i++){
       //        v_letra = p_email.IndexOf
       //        v_respuesta = 1;
       //    }
       //        return v_respuesta;
       //}
    }
}
