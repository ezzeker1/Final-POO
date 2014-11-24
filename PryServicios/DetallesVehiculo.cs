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
    public partial class DetallesVehiculo : Form
    {
        public DetallesVehiculo()
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

            for (int i = 0; i <= Tarjeta.V_Contador; i++) {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text)
                {
                    v_conta = 1;

                    break;
                }
                else v_conta = 2;
            }

            if (v_conta == 1 && v_contador2 == 1)
            {
                for (int i = 0; i < Vehiculo.v_contador; i ++)
                { 
                if (Vehiculo.A_ID[i] == Int32.Parse(lblID.Text))
                {
                    v_detalle = Vehiculo.A_Marca[vID].ToString() + " - " + Vehiculo.A_Modelo[vID].ToString() + " - " + Vehiculo.A_Anio[vID].ToString();
                    v_precio = Vehiculo.A_Precio[vID].ToString();
                }
                }

                RealizarPago ObjRealizarPago = new RealizarPago();
                ObjRealizarPago.vuser = lblResUsuario.Text;
                ObjRealizarPago.vID = Int32.Parse(lblID.Text);
                ObjRealizarPago.vdetalle = v_detalle;
                ObjRealizarPago.Vprecio = v_precio;
                ObjRealizarPago.Show();
                
            }
            else if (v_conta == 2) {
                DialogResult D_Resultado = MessageBox.Show("No cuenta con Tarjeta registrada en el sistema, desea registrarla?", "Mensaje de Servifull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (D_Resultado == DialogResult.Yes) {
                    RegistrarMetodoPago ObjMetodoPago = new RegistrarMetodoPago();
                    ObjMetodoPago.vuser = lblResUsuario.Text;
                    ObjMetodoPago.Show();
                }
                else if (D_Resultado == DialogResult.No) {
                    MessageBox.Show("la compra no procede por falta de información", "Mensaje de Servifull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (v_contador2 == 2)
            {
                DialogResult D_Resultado = MessageBox.Show("No cuenta con Información de Facturación registrada, desea registrarla?", "Mensaje de Servifull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

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
            //else if (v_conta == 3)
            //{
            //    RealizarPago ObjRealizarPago = new RealizarPago();
            //    ObjRealizarPago.vuser = lblResUsuario.Text;
            //    ObjRealizarPago.vID = Int32.Parse(lblID.Text);
            //    ObjRealizarPago.Show();

            //}
        }

        private void DetallesVehiculo_Load(object sender, EventArgs e)
        {
            lblID.Hide();
            lblResUsuario.Text = vuser;
            lblID.Text = vID.ToString();
            lblResCondicion.Text = Vehiculo.A_Condicion[_ID];
            lblResKilometraje.Text = Vehiculo.A_Kilometraje[_ID].ToString();
            lblresMarca.Text = Vehiculo.A_Marca[_ID];
            lblResprecio.Text = Vehiculo.A_Precio[_ID].ToString();
            blResModelo.Text = Vehiculo.A_Modelo[_ID];
            
            if (vID == 0)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.R8;

            }
            else if (vID == 1)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.bmw6;
            }
            else if (vID == 2)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.Mercedez;
            }
            else if (vID == 3)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.Rio;
            }
            else if (vID == 4)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.Yaris;
            }
            else if (vID == 5)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.CBR;
            }
            else if (vID == 6)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.Ninja;
            }
            else if (vID == 7)
            {
                PbVehiculos.Image = PryServicios.Properties.Resources.A7;
            }
        }
    }
}
