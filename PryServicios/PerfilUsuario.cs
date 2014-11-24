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
    public partial class PerfilUsuario : Form
    {
        public PerfilUsuario()
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

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            int v_posicion = 0;
       
            v_posicion = Usuario.PosicionUsuario(lblResUsuario.Text);


            //Cargar el ComboBox de la tarjeta
            for (int i = 0; i <= Tarjeta.V_Contador; i++)
            {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text) {
                    CBSeleccion.Items.Add(Tarjeta.A_numero[i]);
                }
            }

            //Cargar El comboBox de la información de Facturación
            for (int i = 0; i <= InfoFacturacion.V_Contador; i++)
            {
                int v_f_contador = 1;

                if (InfoFacturacion.A_usuario[i] == lblResUsuario.Text)
                {
                    if (InfoFacturacion.A_Predeterminado[i] == 1){
                    CBFSeleccionar.Items.Add("Principal");
                    }
                    else if (InfoFacturacion.A_Predeterminado[i] == 2){
                        CBFSeleccionar.Items.Add("Alternativa " + v_f_contador);
                    }
                }
            }

            //Cargar los datos del Usuario
                if (v_posicion > -1)
                {
                    lblResDUsuario.Text = Usuario.A_Usuario[v_posicion];
                    lblResNombres.Text = Usuario.A_Nombres[v_posicion];
                    lblResApellidos.Text = Usuario.A_Apellidos[v_posicion];
                    lblResTelefono.Text = Usuario.A_Telefono[v_posicion];
                    lblResEmail.Text = Usuario.A_Email[v_posicion];
                    lblResPregunta.Text = Usuario.A_PreguntaSecreta[v_posicion];
                    lblResEdad.Text = Usuario.A_Edad[v_posicion].ToString();
                }

            //Cargar las adquisiciones del Usuario
                for (int j = 0; j < Adquisiciones.v_contador; j++) {
                    if (lblResUsuario.Text == Adquisiciones.A_Usuario[j]) {
                        DGAdquisiciones.Rows.Add(Adquisiciones.A_ID[j], Adquisiciones.A_Tipoadquisicion[j], Adquisiciones.A_Descripcion[j], Adquisiciones.A_Precio[j], Adquisiciones.A_Fecha[j]);
                    }
                }

          }

        private void CBSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            for (int i = 0; i <= Tarjeta.V_Contador; i++) {
                if (CBSeleccion.Text == Tarjeta.A_numero[i])
                {
                    lblResTitular.Text = Tarjeta.A_Titular[i];
                    lblResVencimiento.Text = Tarjeta.A_Mes[i] + "/" + Tarjeta.A_Anio[i];
                    lblResproveedor.Text = Tarjeta.A_Proveedor[i];
                    lblResTipo.Text = Tarjeta.A_Tipo[i];
                }
            }

        }

        private void btnMUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario ObjModificarUsuario = new ModificarUsuario();
            ObjModificarUsuario.vuser = lblResUsuario.Text;
            ObjModificarUsuario.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarMetodoPago ObjMetodoPago = new RegistrarMetodoPago();
            ObjMetodoPago.vuser = lblResUsuario.Text;
            ObjMetodoPago.Show();
        }

        private void btnMPago_Click(object sender, EventArgs e)
        {
            ModificarMetodoPago ObjMMetodoPago = new ModificarMetodoPago();
            ObjMMetodoPago.vuser = lblResUsuario.Text;
            ObjMMetodoPago.Show();
        }

        private void btnFRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarInfoFacturacion OBjInfoFacturacion = new RegistrarInfoFacturacion();
            OBjInfoFacturacion.vuser = lblResUsuario.Text;
            OBjInfoFacturacion.Show();
        }

        private void CBFSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
           string v_extraer = "";
           int v_l_contador = 0;

           v_l_contador = CBFSeleccionar.Text.Length;
           if (v_l_contador > 11) {
               v_extraer = CBFSeleccionar.Text.Substring(0, 11);
           }

            for (int i = 0; i <= InfoFacturacion.V_Contador; i++)
            {
                if (CBFSeleccionar.Text == "Principal" && InfoFacturacion.A_usuario[i] == lblResUsuario.Text)
                {
                    lblResPais.Text = InfoFacturacion.A_Pais[i];
                    lblResDepartamento.Text = InfoFacturacion.A_Departamento[i];
                    lblResProvincia.Text = InfoFacturacion.A_Provincia[i];
                    lblResdistrito.Text = InfoFacturacion.A_Distrito[i];
                    lblResDireccion.Text = InfoFacturacion.A_Direccion[i];   
                }
                else if (v_extraer == "Alternativa" && InfoFacturacion.A_usuario[i] == lblResUsuario.Text)
                {

                }
            }
        }

        private void btnFModificar_Click(object sender, EventArgs e)
        {
            ModificarInfoFacturacion ObjModificarInfoFacturacion = new ModificarInfoFacturacion();
            ObjModificarInfoFacturacion.Show();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            string v_descripcion = "", v_importe = "", v_adquisicion = "";

            for (int j = 0; j < Adquisiciones.v_contador; j++ )
                {
                    if (Adquisiciones.A_ID[j] == Int32.Parse(txtNIdProducto.Text))
                {
                    v_descripcion = Adquisiciones.A_Descripcion[j];
                    v_importe = Adquisiciones.A_Precio[j].ToString();
                        if (Adquisiciones.A_ID[j] >= 0 && Adquisiciones.A_ID[j] <= 10){
                            v_adquisicion = "vehiculo";
                        }
                        else if (Adquisiciones.A_ID[j] >= 20 && Adquisiciones.A_ID[j] <= 29)
                        {
                            v_adquisicion = "Servicio";
                        }
                        else if (Adquisiciones.A_ID[j] >= 30 && Adquisiciones.A_ID[j] <= 42)
                        {
                            v_adquisicion = "Inmueble";
                        }
                }
                }

            for (int i = 0; i < Recibo.v_Contador; i++)
                {
                    if (Recibo.A_ID[i] == Int32.Parse(txtNIdProducto.Text))
                    {
                        Comprobante objComprobante = new Comprobante();
                        objComprobante.vuser = lblResUsuario.Text;
                        objComprobante.vID = Int32.Parse(txtNIdProducto.Text);
                        objComprobante.vdescripcion = v_descripcion;
                        objComprobante.vimporte = v_importe;
                        objComprobante.vAdquisicion = v_adquisicion;
                        objComprobante.Show();
                    }
                }
        }

    }
}
