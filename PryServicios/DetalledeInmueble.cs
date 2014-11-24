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
    public partial class DetalledeInmueble : Form
    {
        public DetalledeInmueble()
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

        private void DetalledeInmueble_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            lblID.Text = vID.ToString();

            for (int i = 0; i < Inmueble.v_contador; i++ )
            { 
            if(Inmueble.A_ID[i] == Int32.Parse(lblID.Text))
            {
                lblResCondicion.Text = Inmueble.a_condicion[i];
                lblRescochera.Text = Inmueble.A_cochera[i];
                lblResDireccion.Text = Inmueble.a_Direccion[i];
                lblresDistrito.Text = Inmueble.a_Distrito[i];
                lblResprecio.Text = Inmueble.A_Precio[i].ToString();
            }
            }

                if (vID == 0)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.Inmuebles;

                }
                else if (vID == 1)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.inmueble1;
                }
                else if (vID == 2)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.inmueble2;
                }
                else if (vID == 3)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.inmueble3;
                }
                else if (vID == 4)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.inmueble4;
                }
                else if (vID == 5)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.inmueble5;
                }
                else if (vID == 6)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.inmueble6;
                }
                else if (vID == 7)
                {
                    Pbinmueble.Image = PryServicios.Properties.Resources.inmueble7;
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
                if(Inmueble.A_ID[i] == Int32.Parse(lblID.Text))
                {
                    v_detalle = Inmueble.A_Tipo[i] + " - " + Inmueble.a_Distrito[i];
                    v_precio = Inmueble.A_Precio[i].ToString();
                }
                }
                RealizarPago ObjRealizarPago = new RealizarPago();
                ObjRealizarPago.vuser = lblResUsuario.Text;
                ObjRealizarPago.vID = Int32.Parse(lblID.Text);
                ObjRealizarPago.Vprecio = v_precio;
                ObjRealizarPago.vdetalle = v_detalle;
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
