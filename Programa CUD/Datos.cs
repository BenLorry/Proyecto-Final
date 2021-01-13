using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using Npgsql;


namespace Programa_CUD
{
    public class Datos
    {
        public static string cadenaConexion = "Server = localhost\\SQLEXPRESS; Database = AgenciaInteligencia; Trusted_Connection = True;";

        public static string cadenaConexion1 = "Server =localhost ;Database=SQLAgenciaInteligencia;Uid=root;Pwd=123456789;";

        public static string cadenaConexion2 = @"Server=localhost;Port=5432;User Id=postgres;Password=123456789;Database=AgenciaInteligenciaPG;";
        public static void AgrearDataTable(DataSet ds, string consulta, string nombreTabla)
        {
            SqlDataAdapter da = new SqlDataAdapter(consulta, cadenaConexion);
            da.Fill(ds, nombreTabla);
        }

        public static void AgrearDataTable1(DataSet ds, string consulta, string nombreTabla)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, cadenaConexion1);
            da.Fill(ds, nombreTabla);
        }
        public static void AgrearDataTable2(DataSet ds, string consulta, string nombreTabla)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, cadenaConexion2);
            da.Fill(ds, nombreTabla);
        }
    }
}
