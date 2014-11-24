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
    public partial class Servicios : Form
    {
        public Servicios()
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

        private void Servicios_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            Servicio objservicio = new Servicio();

            objservicio.RegistrarServicio(20, "Scarlet Johanson", 28, 1500,"Consultoria de sistema");
            objservicio.RegistrarServicio(21, "Kevin Space", 50, 1500, "Clases de actuacion");
            objservicio.RegistrarServicio(22, "Bryan Ramirez", 22, 1900, "Seguridad de sistemas");
            objservicio.RegistrarServicio(23, "Frank UnderWood", 54, 15000, "Traductor");
            objservicio.RegistrarServicio(24, "Guido Diaz", 28, 1800, "Contador");
            objservicio.RegistrarServicio(25, "Sasha Grey", 28, 1700, "Especialista en office");
            objservicio.RegistrarServicio(26, "Erick Pardave", 25, 2500, "Especialista en base de datos");
            objservicio.RegistrarServicio(27, "Juan Calderon", 26, 3500, "Expositor");

            for (int i = 0; i < Servicio.v_contador; i++) {
                cbTipo.Items.Add(Servicio.A_especialidad[i]);
            }

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            DetalledeServicio objDetalleServicio = new DetalledeServicio();
            objDetalleServicio.vID = Int32.Parse(txtId.Text);
            objDetalleServicio.vuser = lblResUsuario.Text;
            objDetalleServicio.Show();
           
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGServicio.Rows.Clear();
            for (int i = 0; i < Servicio.v_contador; i++) {
                if (Servicio.A_especialidad[i] == cbTipo.Text){
                DGServicio.Rows.Add(Servicio.A_ID[i], Servicio.A_especialidad[i], Servicio.A_precio[i],Servicio.A_anios[i]);
                }
            }
        }

        private void txtPrecioFin_TextChanged(object sender, EventArgs e)
        {
            DGServicio.Rows.Clear();

            for (int i = 0; i < Servicio.v_contador; i++){
                if (cbTipo.Text == Servicio.A_especialidad[i]) { 
                if (Int32.Parse(txtPrecioIni.Text) >= Servicio.A_precio[i] && Int32.Parse(txtPrecioFin.Text) <= Servicio.A_precio[i]) {
                    DGServicio.Rows.Add(Servicio.A_ID[i], Servicio.A_especialidad[i], Servicio.A_precio[i], Servicio.A_anios[i]);
                }}
        }
            }

        private void txtaniosfin_TextChanged(object sender, EventArgs e)
        {
            DGServicio.Rows.Clear();

            for (int i = 0; i < Servicio.v_contador; i++)
            {
                if (cbTipo.Text == Servicio.A_especialidad[i] && Int32.Parse(txtPrecioIni.Text) >= Servicio.A_precio[i] && Int32.Parse(txtPrecioFin.Text) <= Servicio.A_precio[i])
                {
                    if (Int32.Parse(txtAniosini.Text) >= Servicio.A_anios[i] && Int32.Parse(txtPrecioFin.Text) <= Servicio.A_anios[i])
                    {
                        DGServicio.Rows.Add(Servicio.A_ID[i], Servicio.A_especialidad[i], Servicio.A_precio[i], Servicio.A_anios[i]);
                    }
                }
            }
        }
    }
}
