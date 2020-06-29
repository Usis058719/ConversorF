using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerna_Nelson
{
   
public partial class Vehiculos : Form
{

    vehiculos_Conexion objConexion = new vehiculos_Conexion ();
    int posicion = 0;
    string accion = "nuevo";
    DataTable tbl = new DataTable();


    public Vehiculos()
    {
        InitializeComponent();
    }


    void actualizarDs()
    {
        tbl = objConexion.obtener_datos().Tables["tbl_vehiculos"];
        tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdVehiculo"] };
    }

    void mostrarDatos()
    {
        try
        {
            lblIDVehiculo .Text = tbl.Rows[posicion].ItemArray[0].ToString();
            TxtMarca .Text = tbl.Rows[posicion].ItemArray[1].ToString();
            TxtModelo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
            TxtYear.Text = tbl.Rows[posicion].ItemArray[3].ToString();

            lblRegistro.Text = (posicion + 1) + " de " + tbl.Rows.Count;
        }
        catch (Exception ex)
        {
            MessageBox.Show("No hay Datos que mostrar", "Vehiculos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_cajas();
        }
    }

    void limpiar_cajas()
    {
        TxtMarca.Text = "";
        TxtModelo.Text = "";
        TxtYear.Text = "";

    }
    void controles(Boolean valor)
    {
        PnlNavegacion .Enabled = valor;
        BtnEliminar.Enabled = valor;
        BtnBuscar.Enabled = valor;
    }

   


   
   
   

   

   

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            if (BtnNuevo.Text == "Nuevo")
            {//boton de nuevo
                BtnNuevo.Text = "Guardar";
                BtnModificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {
                    lblIDVehiculo.Text,
                   TxtMarca.Text,
                    TxtModelo.Text,
                    TxtYear.Text

                };
                objConexion.mantenimiento_vehiculos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                BtnNuevo.Text = "Nuevo";
                BtnModificar.Text = "Modificar";
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + TxtMarca.Text, "Registro de Vehiculos",
        MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblIDVehiculo.Text };
                objConexion.mantenimiento_vehiculos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            if (BtnModificar.Text == "Modificar")
            {//boton de modificar
                BtnNuevo.Text = "Guardar";
                BtnModificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                BtnNuevo.Text = "Guardar";
                BtnModificar.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                BtnNuevo.Text = "Nuevo";
                BtnModificar.Text = "Modificar";
            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            Buscador_de_veiculos buscarProducto = new Buscador_de_veiculos();
            buscarProducto.ShowDialog();

            if (buscarProducto._IDVehiculo > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(buscarProducto._IDVehiculo));
                mostrarDatos();
            }
        }

        private void BtnPrimero_Click_1(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void BtnAnterior_Click_1(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Vehiculo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSiguiente_Click_1(object sender, EventArgs e)
        {

            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Persona Entrevistada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUltimo_Click_1(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
    }  
    }

