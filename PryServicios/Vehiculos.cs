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
    public partial class Vehiculos : Form
    {
        int v_contador = 0;
        public Vehiculos()
        {
            InitializeComponent();

            Vehiculo.A_Anio[0] = 2013;
            Vehiculo.A_Kilometraje[0] = 0;
            Vehiculo.A_Marca[0] = "Audi";
            Vehiculo.A_Modelo[0] = "R8";
            Vehiculo.A_Precio[0] = 250000;
            Vehiculo.A_modena[0] = "Dolares";
            Vehiculo.A_TVehiculo[0] = "Auto";
            Vehiculo.A_ID[0] = 0;
            Vehiculo.A_Condicion[0] = "Nuevo";


            // Vehiculo 1
            Vehiculo.A_Anio[1] = 2014;
            Vehiculo.A_Kilometraje[1] = 0;
            Vehiculo.A_Marca[1] = "BMW";
            Vehiculo.A_Modelo[1] = "X6";
            Vehiculo.A_Precio[1] = 132000;
            Vehiculo.A_modena[1] = "Soles";
            Vehiculo.A_TVehiculo[1] = "Auto";
            Vehiculo.A_ID[1] = 1;
            Vehiculo.A_Condicion[1] = "Nuevo";

            // Vehiculo 2
            Vehiculo.A_Anio[2] = 2011;
            Vehiculo.A_Kilometraje[2] = 0;
            Vehiculo.A_Marca[2] = "Mercedez";
            Vehiculo.A_Modelo[2] = "AMG";
            Vehiculo.A_Precio[2] = 150000;
            Vehiculo.A_modena[2] = "Dolares";
            Vehiculo.A_TVehiculo[2] = "Auto";
            Vehiculo.A_ID[2] = 2;
            Vehiculo.A_Condicion[2] = "Nuevo";

            // Vehiculo 3
            Vehiculo.A_Anio[3] = 2014;
            Vehiculo.A_Kilometraje[3] = 0;
            Vehiculo.A_Marca[3] = "Kia";
            Vehiculo.A_Modelo[3] = "Rio";
            Vehiculo.A_Precio[3] = 14000;
            Vehiculo.A_modena[3] = "Dolares";
            Vehiculo.A_TVehiculo[3] = "Auto";
            Vehiculo.A_ID[3] = 3;
            Vehiculo.A_Condicion[3] = "Nuevo";

            // Vehiculo 4
            Vehiculo.A_Anio[4] = 2011;
            Vehiculo.A_Kilometraje[4] = 50000;
            Vehiculo.A_Marca[4] = "Toyota";
            Vehiculo.A_Modelo[4] = "Yaris";
            Vehiculo.A_Precio[4] = 25000;
            Vehiculo.A_modena[4] = "Soles";
            Vehiculo.A_TVehiculo[4] = "Auto";
            Vehiculo.A_ID[4] = 4;
            Vehiculo.A_Condicion[4] = "Usado";

            // Vehiculo 5
            Vehiculo.A_Anio[5] = 2012;
            Vehiculo.A_Kilometraje[5] = 0;
            Vehiculo.A_Marca[5] = "Honda";
            Vehiculo.A_Modelo[5] = "CBR 250";
            Vehiculo.A_Precio[5] = 14000;
            Vehiculo.A_modena[5] = "Soles";
            Vehiculo.A_TVehiculo[5] = "Moto";
            Vehiculo.A_ID[5] = 5;
            Vehiculo.A_Condicion[5] = "Nuevo";

            // Vehiculo 6
            Vehiculo.A_Anio[6] = 2012;
            Vehiculo.A_Kilometraje[6] = 15000;
            Vehiculo.A_Marca[6] = "Kawasaki";
            Vehiculo.A_Modelo[6] = "Ninja";
            Vehiculo.A_Precio[6] = 11000;
            Vehiculo.A_modena[6] = "Dolares";
            Vehiculo.A_TVehiculo[6] = "Moto";
            Vehiculo.A_ID[6] = 6;
            Vehiculo.A_Condicion[6] = "Usado";

            // Vehiculo 7
            Vehiculo.A_Anio[7] = 2013;
            Vehiculo.A_Kilometraje[7] = 0;
            Vehiculo.A_Marca[7] = "Audi";
            Vehiculo.A_Modelo[7] = "A7";
            Vehiculo.A_Precio[7] = 75000;
            Vehiculo.A_modena[7] = "Dolares";
            Vehiculo.A_TVehiculo[7] = "Auto";
            Vehiculo.A_ID[7] = 7;
            Vehiculo.A_Condicion[7] = "Nuevo";
             
            for (int i = 0; i < Vehiculo.v_contador; i++)
            {
                if (CBTVehiculo.Items.Contains(Vehiculo.A_TVehiculo[i])) {
                    v_contador = 1;
                }
                else CBTVehiculo.Items.Add(Vehiculo.A_TVehiculo[i]);                
                
            }
        }
        private string _user;

        //Metodos GET y SET para Obtener el Usuario
        public string vuser
        {
            get { return _user; }
            set { _user = value; }
        }

         private void Vehiculos_Load(object sender, EventArgs e)
        {
            lblResUsuario.Text = vuser;
        }

         private void CBTVehiculo_SelectedIndexChanged(object sender, EventArgs e)
         {
             

             DGVehiculos.Rows.Clear();
             //Cargar las grilla
             for (int i = 0; i<= Vehiculo.v_contador; i++){
                 if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text){                     
                     DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                         Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                         Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]); }

                 //Cargar las marcas
                 for (int j = 0; j < Vehiculo.v_contador; j++) {
                     if (CBMarca.Items.Contains(Vehiculo.A_Marca[j]))
                     { 
                         v_contador = 1;
                     } 
                     else CBMarca.Items.Add(Vehiculo.A_Marca[j]);  
                 }

                 //Cargar los modelos
                 for (int m = 0; m < Vehiculo.v_contador; m++) { 
                 if(CBModelo.Items.Contains(Vehiculo.A_Modelo[m])){
                 v_contador = 1;
                 }
                 else CBModelo.Items.Add(Vehiculo.A_Modelo[m]);
                 }}

              //Cargar los años 
             for (int d = 0; d < Vehiculo.v_contador; d++){
             if(CBAnio.Items.Contains(Vehiculo.A_Anio[d])){
             v_contador = 1;
             }
             else CBAnio.Items.Add(Vehiculo.A_Anio[d]);
             }

             //Cargar Condicion
             for (int f = 0; f < Vehiculo.v_contador; f++) {
                 if (CBCondicion.Items.Contains(Vehiculo.A_Condicion[f]))
                 {
                     v_contador = 1;
                 }
                 else CBCondicion.Items.Add(Vehiculo.A_Condicion[f]);
             }

              }
                 
         private void CBMarca_SelectedIndexChanged(object sender, EventArgs e)
         {
             //Cargar Modelos
             for (int i = 0; i < Vehiculo.v_contador; i++) {
                 if (CBModelo.Items.Contains(Vehiculo.A_Modelo[i]))
                 {
                     v_contador = 1;
                 }
                 else CBModelo.Items.Add(Vehiculo.A_Modelo[i]);
             }

             //Cargar Año
             for (int j = 0; j < Vehiculo.v_contador; j++) {
                 if (CBAnio.Items.Contains(Vehiculo.A_Anio[j]))
                 {
             v_contador = 1;
             }
             else CBAnio.Items.Add(Vehiculo.A_Anio[j]);
             }
                 //Cargar Condición
             for(int s = 0; s< Vehiculo.v_contador; s++){
             if (CBCondicion.Items.Contains(Vehiculo.A_Condicion[s])){
             v_contador = 1;
             } else CBCondicion.Items.Add(Vehiculo.A_Condicion[s]);
             }

                 DGVehiculos.Rows.Clear();
             //Cargar las grilla
             for (int i = 0; i<= Vehiculo.v_contador; i++){
                 if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text){                     
                     DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                         Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                         Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]); }
             }
         }

         private void btnBuscar_Click(object sender, EventArgs e)
         {

         }

         private void Vehiculos_Load_1(object sender, EventArgs e)
         {
             lblResUsuario.Text = vuser;
         }

         private void CBModelo_SelectedIndexChanged(object sender, EventArgs e)
         {
             //Cargar el Año
             for (int j = 0; j <= Vehiculo.v_contador; j++) {
                 if (CBAnio.Items.Contains(Vehiculo.A_Anio[j]))
                 {
                     v_contador = 1;
                 }
                   
                 else CBAnio.Items.Add(Vehiculo.A_Anio[j]);
             }

             DGVehiculos.Rows.Clear();
             //Cargar las grilla
             for (int i = 0; i <= Vehiculo.v_contador; i++)
             {
                 if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text &&
                     Vehiculo.A_Modelo[i] == CBModelo.Text)
                 {
                     DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                         Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                         Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                 }
             }
         }

         private void CBAnio_SelectedIndexChanged(object sender, EventArgs e)
         {
             DGVehiculos.Rows.Clear();
             //Cargar las grilla
             for (int i = 0; i <= Vehiculo.v_contador; i++)
             {
                 if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text &&
                     Vehiculo.A_Modelo[i] == CBModelo.Text && Vehiculo.A_Anio[i].ToString() == CBAnio.Text)
                 {
                     DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                         Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                         Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                 }
             }
         }

         private void CBCondicion_SelectedIndexChanged(object sender, EventArgs e)
         {
             DGVehiculos.Rows.Clear();
             //Cargar las grilla
             for (int i = 0; i <= Vehiculo.v_contador; i++)
             {
                 if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text &&
                     Vehiculo.A_Modelo[i] == CBModelo.Text && Vehiculo.A_Anio[i].ToString() == CBAnio.Text
                     && Vehiculo.A_Condicion[i] == CBCondicion.Text)
                 {
                     DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                         Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                         Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                 }
             }
         }

         private void txtPInicial_TextChanged(object sender, EventArgs e)
         {
             DGVehiculos.Rows.Clear();
             for (int i = 0; i< Vehiculo.v_contador; i ++){
                 if (Vehiculo.A_Precio[i] >= Int32.Parse(txtPInicial.Text)) { 
                 if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text &&
                     Vehiculo.A_Modelo[i] == CBModelo.Text && Vehiculo.A_Anio[i].ToString() == CBAnio.Text
                     && Vehiculo.A_Condicion[i] == CBCondicion.Text)
                 {
                     DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                         Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                         Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                 }
                 }
         }}

         private void txtPFinal_TextChanged(object sender, EventArgs e)
         {
             DGVehiculos.Rows.Clear();
             for (int i = 0; i < Vehiculo.v_contador; i++)
             {
                 if (Vehiculo.A_Precio[i] <= Int32.Parse(txtPFinal.Text))
                 {
                     if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text &&
                         Vehiculo.A_Modelo[i] == CBModelo.Text && Vehiculo.A_Anio[i].ToString() == CBAnio.Text
                         && Vehiculo.A_Condicion[i] == CBCondicion.Text)
                     {
                         DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                             Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                             Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                     }
                 }
             }
         }

         private void txtKInicial_TextChanged(object sender, EventArgs e)
         {
             DGVehiculos.Rows.Clear();
             for (int i = 0; i < Vehiculo.v_contador; i++)
             {
                 if (Vehiculo.A_Kilometraje[i] >= Int32.Parse(txtKInicial.Text))
                 {
                     if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text &&
                         Vehiculo.A_Modelo[i] == CBModelo.Text && Vehiculo.A_Anio[i].ToString() == CBAnio.Text
                         && Vehiculo.A_Condicion[i] == CBCondicion.Text)
                     {
                         DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                             Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                             Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                     }
                 }
             }
         }

         private void txtKFinal_TextChanged(object sender, EventArgs e)
         {
             DGVehiculos.Rows.Clear();
             for (int i = 0; i < Vehiculo.v_contador; i++)
             {
                 if (Vehiculo.A_Kilometraje[i] <= Int32.Parse(txtKFinal.Text))
                 {
                     if (Vehiculo.A_TVehiculo[i] == CBTVehiculo.Text && Vehiculo.A_Marca[i] == CBMarca.Text &&
                         Vehiculo.A_Modelo[i] == CBModelo.Text && Vehiculo.A_Anio[i].ToString() == CBAnio.Text
                         && Vehiculo.A_Condicion[i] == CBCondicion.Text)
                     {
                         DGVehiculos.Rows.Add(Vehiculo.A_ID[i], Vehiculo.A_TVehiculo[i], Vehiculo.A_Marca[i],
                             Vehiculo.A_Modelo[i], Vehiculo.A_Condicion[i], Vehiculo.A_Precio[i],
                             Vehiculo.A_Anio[i], Vehiculo.A_Kilometraje[i]);
                     }
                 }
             }
         }

         private void btnDetalles_Click(object sender, EventArgs e)
         {
             DetallesVehiculo ObjDetalleVehiculo = new DetallesVehiculo();

             ObjDetalleVehiculo.vuser = lblResUsuario.Text;
             ObjDetalleVehiculo.vID = Int32.Parse(txtId.Text);
             ObjDetalleVehiculo.Show();
         }
        }

       
    }

