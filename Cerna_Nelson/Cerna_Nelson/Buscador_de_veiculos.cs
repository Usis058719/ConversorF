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
    public partial class Buscador_de_veiculos : Form
    {
        vehiculos_Conexion objConexion = new vehiculos_Conexion();
        public int _IDVehiculo;
        public Buscador_de_veiculos()
        {
            InitializeComponent();
        }

        private void Buscador_de_veiculos_Load(object sender, EventArgs e)
        {

            GrdBuscador.DataSource = objConexion.obtener_datos().Tables["tbl_vehiculos"].DefaultView;
        }

       

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBuscador.DataSource;
            bs.Filter = "marca like '%" + valor + "%' or modelo like '%" + valor + "%' or year like '%" + valor + "%'";
            GrdBuscador.DataSource = bs;

        }



       
        private void Txtbuscar_TextChanged_1(object sender, EventArgs e)
        {
            filtrar_datos(Txtbuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GrdBuscador.RowCount > 0)
            {
                _IDVehiculo = int.Parse(GrdBuscador.CurrentRow.Cells["IdVehiculo"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Vehiculos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}