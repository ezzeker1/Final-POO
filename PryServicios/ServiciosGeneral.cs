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
    public partial class ServiciosGeneral : Form
    {
        public ServiciosGeneral()
        {
            InitializeComponent();
        }

        private string _user;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser{
            get { return _user;}
            set { _user = value;}
        }

        

        private void PBVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos ObjVehiculos = new Vehiculos();
            ObjVehiculos.vuser = lblResUsuario.Text;
            ObjVehiculos.Show();
        }

        private void PBInmuebles_Click(object sender, EventArgs e)
        {
            Inmuebles ObjInmuebles = new Inmuebles();
            ObjInmuebles.vuser = lblResUsuario.Text;
            ObjInmuebles.Show();
        }

        private void PBServicios_Click(object sender, EventArgs e)
        {
            Servicios ObjServicios = new Servicios();
            ObjServicios.vuser = lblResUsuario.Text;
            ObjServicios.Show();
        }

        private void ServiciosGeneral_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            PerfilUsuario ObjPerfil = new PerfilUsuario();
            ObjPerfil.vuser = lblResUsuario.Text;
            ObjPerfil.Show();
        } 
    }
}
