using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        SqlConnection conecta;

        public SqlConnection Conectar()
        {
            try
            {
                // Ajusta la cadena de conexión para que apunte al archivo .mdf de tu base de datos
                string sql = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LicoreriaYarpos.mdf;Integrated Security=True;";
                conecta = new SqlConnection(sql);
                conecta.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }

            return conecta;
        }

        public void Desconectar()
        {
            conecta.Close();
        }
    }
}
