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
    public partial class Inmuebles : Form
    {
        public Inmuebles()
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

        private void Inmuebles_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
            int v_contador = 0;

            Inmueble objInmueble = new Inmueble();

            objInmueble.RegistrarInmueble(30, "Departamento", 0, 457812, "Si", "Av. salaverry 111", "San isidro","Estreno");
            objInmueble.RegistrarInmueble(31, "Departamento", 0, 850000, "Si", "Jr. Olmos 345", "La Molina","Estreno");
            objInmueble.RegistrarInmueble(32, "Departamento", 5, 150000, "No", "Av. Space 222", "Surco","Antiguo");
            objInmueble.RegistrarInmueble(33, "Oficina", 2, 200000, "Si", "Av. Naranjas 111", "Ate","Antiguo");
            objInmueble.RegistrarInmueble(34, "Casa", 0, 1500000, "Si", "Av. Almendras 111", "Lurin","Estreno");
            objInmueble.RegistrarInmueble(35, "Casa", 4, 457812, "No", "Av. Fresas 111", "Chosica","Antiguo");
            objInmueble.RegistrarInmueble(36, "Terreno", 5, 900000, "No", "Av. Frutales 444", "Lurigancho","Antiguo");
            objInmueble.RegistrarInmueble(37, "Oficina", 5, 800000, "Si", "Av. ASD 321", "San Borja","Antiguo");

            for (int a = 0; a < Inmueble.v_contador; a++ )
                {
                    if (cbInmueble.Items.Contains(Inmueble.A_Tipo[a]))
                    {
                        v_contador = 1;
                    }
                    else cbInmueble.Items.Add(Inmueble.A_Tipo[a]);
                }
                for (int i = 0; i < Inmueble.v_contador; i++)
                {
                    cbDistrito.Items.Add(Inmueble.a_Distrito[i]);
                }
            for (int j = 0; j < Inmueble.v_contador; j++){
                if (cbDistrito.Items.Contains(Inmueble.a_Distrito[j]))
                {
                    v_contador = v_contador + 1;
                }
                else cbDistrito.Items.Add(Inmueble.a_Distrito[j]);
            }
            for (int f = 0; f <Inmueble.v_contador; f++){
            if (cbCochera.Items.Contains(Inmueble.A_cochera[f])){
            
            }
            }
            for (int s = 0; s < Inmueble.v_contador; s++){
                if (cbCondicion.Items.Contains(Inmueble.a_condicion[s]))
                {
                    v_contador = v_contador + 1;
                }
                else cbCondicion.Items.Add(Inmueble.a_condicion[s]);
            }
        }

        private void txtAniosFin_TextChanged(object sender, EventArgs e)
        {
            dginmueble.Rows.Clear();

            for (int i= 0; i < Inmueble.v_contador; i++){
            if (Int32.Parse(txtAniosIni.Text) >= Inmueble.A_Anios[i] && Int32.Parse(txtAniosFin.Text) <= Inmueble.A_Anios[i]){
                dginmueble.Rows.Add(Inmueble.A_ID[i], Inmueble.A_Tipo[i], Inmueble.a_Distrito[i], Inmueble.A_Anios[i], Inmueble.A_Precio[i]);
            }
            }
        }

        private void txtPrecioFinal_TextChanged(object sender, EventArgs e)
        {
            dginmueble.Rows.Clear();

            for (int i = 0; i < Inmueble.v_contador; i++)
            {
                if (Int32.Parse(txtPrecioIni.Text) >= Inmueble.A_Precio[i] && Int32.Parse(txtPrecioFinal.Text) <= Inmueble.A_Precio[i])
                {
                    dginmueble.Rows.Add(Inmueble.A_ID[i], Inmueble.A_Tipo[i], Inmueble.a_Distrito[i], Inmueble.A_Anios[i], Inmueble.A_Precio[i]);
                }
            }
        }

        private void cbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            dginmueble.Rows.Clear();
            for (int i = 0; i < Inmueble.v_contador; i++)
            {
                if (cbCondicion.Text == Inmueble.a_condicion[i])
                {
                    dginmueble.Rows.Add(Inmueble.A_ID[i], Inmueble.A_Tipo[i], Inmueble.a_Distrito[i], Inmueble.A_Anios[i], Inmueble.A_Precio[i]);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DetalledeInmueble objDetaInmueble = new DetalledeInmueble();

            objDetaInmueble.vuser = lblResUsuario.Text;
            objDetaInmueble.vID = Int32.Parse(txtid.Text);
            objDetaInmueble.Show();
        }

        private void cbDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            dginmueble.Rows.Clear();

            for (int i = 0; i < Inmueble.v_contador; i++){
            if (cbDistrito.Text == Inmueble.a_Distrito[i]){
                dginmueble.Rows.Add(Inmueble.A_ID[i], Inmueble.A_Tipo[i], Inmueble.a_Distrito[i], Inmueble.A_Anios[i], Inmueble.A_Precio[i]);
            }
            }
        }

        private void cbInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            dginmueble.Rows.Clear();

            for (int i = 0; i < Inmueble.v_contador; i++)
        {
                if (cbInmueble.Text == Inmueble.A_Tipo[i])
        {
            dginmueble.Rows.Add(Inmueble.A_ID[i], Inmueble.A_Tipo[i], Inmueble.a_Distrito[i], Inmueble.A_Anios[i], Inmueble.A_Precio[i]);
        }
        }
        }
    }
}
