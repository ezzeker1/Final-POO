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
    public partial class RealizarPago : Form
    {
        public RealizarPago()
        {
            InitializeComponent();
           
        }
        private string _user;
        private int _ID;
        private string _Detalle;
        private string _Precio;

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
        
        public string Vprecio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        public string vdetalle
        {
            get { return _Detalle; }
            set { _Detalle = value; }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            string v_descripcion = "";

            
                if (vID >= 0 && vID <= 10)
                {
                    for (int i = 0; i < Vehiculo.v_contador; i++ )
                {
                if (Vehiculo.A_ID[i] == vID)
                {
                    v_descripcion = Vehiculo.A_Marca[i] + " - " + Vehiculo.A_Modelo[i] + " - " + Vehiculo.A_Anio[i];
                }
                }

                    if (Int32.Parse(txtMonto.Text) >= Vehiculo.A_Precio[vID])
                    {
                        Adquisiciones ObjAdquisiciones = new Adquisiciones();
                        //(int P_id, string p_TipoAdquisicion, string p_descripcion, int p_precio, DateTime p_fecha, string p_usuario)
                        ObjAdquisiciones.RegistrarAdquisicion(vID, "Vehiculo", v_descripcion, Int32.Parse(lblResValorCompra.Text), DateTime.Now, lblResUsuario.Text);

                        MessageBox.Show("Se adquirio el Item '" + lblitem.Text + "' Por un monto de  USD" + lblResValorCompra.Text);

                        Recibo ObjRecibo = new Recibo();
                        ObjRecibo.RegistrarRecibo(vID, lblResUsuario.Text, lblResValorCompra.Text, lblResValorCompra.Text);

                        this.Close();
                    }
                    else MessageBox.Show("Fondos insuficientes para cubrir el precio del Vehiculo", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (vID >= 20 && vID <= 29)
                {
                    for (int i = 0; i < Servicio.v_contador; i++)
                    {
                        if (Servicio.A_ID[i] == vID)
                        {
                            v_descripcion = Servicio.A_especialidad[i] + " - " + Servicio.A_anios + " Años de Experiencia";
                        }
                    }

                    if (Int32.Parse(txtMonto.Text) >= Servicio.A_precio[vID])
                    {
                        Adquisiciones ObjAdquisiciones = new Adquisiciones();
                        ObjAdquisiciones.RegistrarAdquisicion(vID, "Vehiculo", v_descripcion, Int32.Parse(lblResValorCompra.Text), DateTime.Now, lblResUsuario.Text);

                        MessageBox.Show("Se adquirio el Item '" + lblitem.Text + "' Por un monto de  USD" + lblResValorCompra.Text);

                        Recibo ObjRecibo = new Recibo();
                        ObjRecibo.RegistrarRecibo(vID, lblResUsuario.Text, lblResValorCompra.Text, lblResValorCompra.Text);

                        this.Close();
                    }
                    else MessageBox.Show("Fondos insuficientes para cubrir el precio del Vehiculo", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (vID >= 30 && vID <= 40)
                {
                    for (int i = 0; i < Inmueble.v_contador; i++)
                    {
                        if (Inmueble.A_ID[i] == vID)
                        {
                            v_descripcion = Inmueble.a_Distrito[i] + " - " + Inmueble.A_Tipo[i];
                        }
                    }


                    if (Int32.Parse(txtMonto.Text) >= Inmueble.A_Precio[vID])
                    {
                        Adquisiciones ObjAdquisiciones = new Adquisiciones();
                        ObjAdquisiciones.RegistrarAdquisicion(vID, "Vehiculo", v_descripcion, Int32.Parse(lblResValorCompra.Text), DateTime.Now, lblResUsuario.Text);

                        MessageBox.Show("Se adquirio el Item '" + lblitem.Text + "' Por un monto de  USD" + lblResValorCompra.Text);

                        Recibo ObjRecibo = new Recibo();
                        ObjRecibo.RegistrarRecibo(vID, lblResUsuario.Text, lblResValorCompra.Text, lblResValorCompra.Text);

                        this.Close();
                    }
                    else MessageBox.Show("Fondos insuficientes para cubrir el precio del Vehiculo", "Mensaje de ServiFull", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


        }

        private void GBInfodeCompra_Enter(object sender, EventArgs e)
        {

        }

        private void RealizarPago_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            

            for (int i = 0; i < Tarjeta.V_Contador; i++)
            {
                if (Tarjeta.A_usuario[i] == lblResUsuario.Text)
                {
                    CBTarjetaCredito.Items.Add(Tarjeta.A_numero[i]);
                }
            }

            lblResValorCompra.Text = Vprecio.ToString();  //Vehiculo.A_Precio[vID].ToString();
            lblitem.Text = vdetalle;//Vehiculo.A_Marca[vID].ToString() + " - " + Vehiculo.A_Modelo[vID].ToString() + " - " + Vehiculo.A_Anio[vID].ToString();
          
        }

        private void CBTarjetaCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tarjeta.V_Contador; i++){
                if (CBTarjetaCredito.Text == Tarjeta.A_numero[i]) {
                    lblResNumero.Text = Tarjeta.A_numero[i];
                    lblResTarjeta.Text = Tarjeta.A_Proveedor[i];
                    lblResTipo.Text = Tarjeta.A_Tipo[i];
                    lblResVencimiento.Text = Tarjeta.A_Anio[i].ToString() + "/" + Tarjeta.A_Mes[i].ToString();
                }
        }
        }
    }
}
