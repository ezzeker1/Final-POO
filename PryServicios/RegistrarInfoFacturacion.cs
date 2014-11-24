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
    public partial class RegistrarInfoFacturacion : Form
    {
        public RegistrarInfoFacturacion()
        {
            InitializeComponent(); 
        }

        private string _user;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string v_resultado = "";
            int v_predeterminado = 0;
         
            //string p_predeterminado, string p_ntarjeta, string p_pais, string p_departamento, string p_provincia,string p_distrito, string p_direccion)

            v_resultado = InfoFacturacion.ValidarInfoFacturacion(CBPredeterminado.Text, CBNTarjeta.Text, CBPais.Text, CBDepartamento.Text, CBProvincia.Text, CBDistrito.Text,
                txtDireccion.Text);

            if (v_resultado == "0")
            {
                DialogResult D_Resultado = MessageBox.Show("Si esta seguro que la información ingresada es correcta Presione 'SI'",
                    "Mensaje de ServiFull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if ( D_Resultado == DialogResult.Yes)
                {
                    if (CBPredeterminado.Text == "Si")
                    {
                        v_predeterminado = 1;
                    }
                    else if (CBPredeterminado.Text == "No")
                    {
                        v_predeterminado = 2;
                    }

                    InfoFacturacion.A_Departamento[InfoFacturacion.V_Contador] = CBDepartamento.Text;
                    InfoFacturacion.A_Provincia[InfoFacturacion.V_Contador] = CBProvincia.Text;
                    InfoFacturacion.A_Distrito[InfoFacturacion.V_Contador] = CBDistrito.Text;
                    InfoFacturacion.A_Direccion[InfoFacturacion.V_Contador] = txtDireccion.Text;
                    InfoFacturacion.A_NTarjeta[InfoFacturacion.V_Contador] = CBNTarjeta.Text;
                    InfoFacturacion.A_Pais[InfoFacturacion.V_Contador] = CBPais.Text;
                    InfoFacturacion.A_usuario[InfoFacturacion.V_Contador] = lblResUsuario.Text;
                    InfoFacturacion.A_Predeterminado[InfoFacturacion.V_Contador] = v_predeterminado;
                    InfoFacturacion.V_Contador++;
                    this.Close();
                }
                else if(D_Resultado == DialogResult.No) { 
                    MessageBox.Show("No se realizo ninguna acción", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
            }
            }
            else MessageBox.Show(v_resultado,"Mensaje de ServiFull", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void RegistrarInfoFacturacion_Load(object sender, EventArgs e)
        {
            //Cargar el nombre del usuario
            lblResUsuario.Text = vuser;

            //Cargar el combo de Predeterminado
            CBPredeterminado.Items.Add("Si");
            CBPredeterminado.Items.Add("No");

            //Cargar datos para el Combo Pais
            CBPais.Items.Add("Perú");

            //Cargar el combo de Departamentos
            CBDepartamento.Items.Add("Lima");

            //Cargar el combo de Provincia
            CBProvincia.Items.Add("Lima");

            //Cargar el combo de Departamento
            CBDistrito.Items.Add("Lima");

            for (int i = 0; i < Tarjeta.V_Contador; i++) {
                if (lblResUsuario.Text == Tarjeta.A_usuario[i]) {
                    CBNTarjeta.Items.Add(Tarjeta.A_numero[i]);
                }
            }
        }
    }
}
