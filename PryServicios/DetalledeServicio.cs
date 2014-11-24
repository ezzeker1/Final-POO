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
    public partial class DetalledeServicio : Form
    {
        public DetalledeServicio()
        {
            InitializeComponent();
        }
        private string _user;
        private int _ID;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }
        public int vID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        private void DetalledeServicio_Load(object sender, EventArgs e)
        {
            lblID.Text = vID.ToString();
            lblID.Hide();
            for (int i = 0; i < Servicio.v_contador; i++ ){
            if (Servicio.A_ID[i] == vID){
                lblResanios.Text = Servicio.A_anios[i].ToString();
                lblReshonorarios.Text = Servicio.A_precio[i].ToString();
                lblResEspecie.Text = Servicio.A_especialidad[i];
                lblresNombre.Text = Servicio.A_nombre[i];
               
            }
            }


                if (vID == 0)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.R8;

                }
                else if (vID == 1)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.bmw6;
                }
                else if (vID == 2)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.Mercedez;
                }
                else if (vID == 3)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.Rio;
                }
                else if (vID == 4)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.Yaris;
                }
                else if (vID == 5)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.CBR;
                }
                else if (vID == 6)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.Ninja;
                }
                else if (vID == 7)
                {
                    PbServicios.Image = PryServicios.Properties.Resources.A7;
                }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int v_conta = -1, v_contador2 = -1;
            string v_detalle = "", v_precio = "";

            for (int d = 0; d <= InfoFacturacion.V_Contador; d++)
            {
                if (InfoFacturacion.A_usuario[d] == lblResUsuario.Text)
                {
                    v_contador2 = 1;
                    break;
                }
                else v_contador2 = 2;
            }

            for (int i = 0; i <= Tarjeta.V_Contador; i++)
            {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text)
                {
                    v_conta = 1;
                    break;
                }
                else v_conta = 2;
            }

            if (v_conta == 1 && v_contador2 == 1)
            {
                for (int i = 0; i < Inmueble.v_contador; i++)
                {
                    if (Servicio.A_ID[i] == Int32.Parse(lblID.Text))
                    {
                        v_detalle = Servicio.A_especialidad[i] + " - " + Servicio.A_anios[i] + " Años de Experiencia";
                        v_precio = Servicio.A_precio[i].ToString();
                    }
                }

                RealizarPago ObjRealizarPago = new RealizarPago();
                ObjRealizarPago.vuser = lblResUsuario.Text;
                ObjRealizarPago.vID = Int32.Parse(lblID.Text);
                ObjRealizarPago.vdetalle = v_detalle;
                ObjRealizarPago.Vprecio = v_precio;
                ObjRealizarPago.Show();

            }
            else if (v_conta == 2)
            {
                DialogResult D_Resultado = MessageBox.Show("No cuenta con Tarjeta registrada en el sistema, desea registrarla?", 
                    "Mensaje de Servifull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (D_Resultado == DialogResult.Yes)
                {
                    RegistrarMetodoPago ObjMetodoPago = new RegistrarMetodoPago();
                    ObjMetodoPago.vuser = lblResUsuario.Text;
                    ObjMetodoPago.Show();
                }
                else if (D_Resultado == DialogResult.No)
                {
                    MessageBox.Show("la compra no procede por falta de información", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (v_contador2 == 2)
            {
                DialogResult D_Resultado = MessageBox.Show("No cuenta con Información de Facturación registrada, desea registrarla?", 
                    "Mensaje de Servifull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (D_Resultado == DialogResult.Yes)
                {
                    RegistrarInfoFacturacion objInfoFactura = new RegistrarInfoFacturacion();
                    objInfoFactura.vuser = lblResUsuario.Text;
                    objInfoFactura.Show();

                }
                else if (D_Resultado == DialogResult.No)
                {
                    MessageBox.Show("la compra no procede por falta de información", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
