using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cerna_Nelson
{
    class vehiculos_Conexion
    {
            SqlConnection miConexion = new SqlConnection();
            SqlCommand comandosSQL = new SqlCommand();
            SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

            DataSet ds = new DataSet();

            public vehiculos_Conexion()
            {
                String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parque_vehicular_Cerna_Nelson.mdf;Integrated Security=True";
                miConexion.ConnectionString = cadena;
                miConexion.Open();
            }

            public DataSet obtener_datos()
            {
                ds.Clear();
                comandosSQL.Connection = miConexion;

                comandosSQL.CommandText = "select * from tbl_vehiculos";
                miAdaptadorDatos.SelectCommand = comandosSQL;
                miAdaptadorDatos.Fill(ds, "tbl_vehiculos");

                return ds;
            }


            public void mantenimiento_vehiculos(String[] datos, String accion)
            {
                String sql = "";
                if (accion == "nuevo")
                {

                    sql = "INSERT INTO tbl_vehiculos (Marca, Modelo, Year) VALUES(" +

                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'" +
                        ")";

                }

                else if (accion == "modificar")
                {

                    sql = "UPDATE tbl_vehiculos SET " +
                    " Marca             = '" + datos[1] + "'," +
                    " Modelo           = '" + datos[2] + "'," +
                    " Year            = '" + datos[3] + "'" +
                    " WHERE IdVehiculo     = '" + datos[0] + "'";


                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE tbl_vehiculos FROM tbl_vehiculos WHERE IdVehiculo='" + datos[0] + "'";

                }
                procesarSQL(sql);
            }

            void procesarSQL(String sql)
            {
                comandosSQL.Connection = miConexion;
                comandosSQL.CommandText = sql;
                comandosSQL.ExecuteNonQuery();
            }

        }
    }
