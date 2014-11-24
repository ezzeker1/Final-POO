using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryServicios
{
    public partial class Comprobante : Form
    {
        public Comprobante()
        {
            InitializeComponent();
        }
        private string _user;
        private int _ID;
        private string _tipoadqui;
        private string _Descripcion;
        private string _importe;
        private string _asquisicion;


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

        public string vTipoadqui
        {
            get { return _tipoadqui; }
            set { _tipoadqui = value; }
        }
        
        public string vdescripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string vimporte
        {
            get { return _importe; }
            set { _importe = value; }
        }

        public string vAdquisicion
        {
            get { return _asquisicion; }
            set { _asquisicion = value; }
        }



        private void Comprobante_Load(object sender, EventArgs e)
        {
            for (int d = 0; d < Usuario.V_Contador; d++) {
                if (Usuario.A_Usuario[d] == _user) {
                    lblresUsuario.Text = Usuario.A_Nombres[d] +" "+ Usuario.A_Apellidos[d];
                }
            }

            lblResCantidad.Text = "1";
            lblResDepartamento.Text= vdescripcion;
            lblResimporte.Text = vimporte;
            lblResAdquisicion.Text = vAdquisicion;
           
                for (int j = 0; j < InfoFacturacion.V_Contador; j++)
                {
                    if (InfoFacturacion.A_usuario[j] == _user)
                    {
                        //Datos de Facturacion
                        lblRespais.Text = InfoFacturacion.A_Pais[j];
                        lblResDepartamento.Text = InfoFacturacion.A_Departamento[j];
                        lblResprovincia.Text = InfoFacturacion.A_Provincia[j];
                        lblResDistrito.Text = InfoFacturacion.A_Distrito[j];
                        lblResDireccion.Text = InfoFacturacion.A_Direccion[j];
                    }
                }

            for (int i = 0; i < Recibo.v_Contador; i++) {
                if (Recibo.A_ID[i] == _ID) { 
                                       
                    //Datos del Recibo
                    lblresEmision.Text = Recibo.A_FEmision[i];
                    lblresVencimiento.Text = Recibo.A_FVencimento[i];
                    lblResSerie.Text = Recibo.A_Serie[i];
                    lblresNumero.Text = Recibo.A_Numero[i];
                    lblResSubtotal.Text = "USD " +  Recibo.A_Subtotal[i].ToString();
                    lblResTotal.Text = "USD " + Recibo.A_Total[i].ToString();
                    
                }
            }



        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
           
        }
    }
}
