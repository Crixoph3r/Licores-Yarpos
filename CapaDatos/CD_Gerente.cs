using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Gerente
    {
        Conexion oconexion = new Conexion();

        public int RegistrarGerente(CE_Gerente egerente)
        {
            

            oconexion.Conectar();

            // Declarar la variable de tabla y realizar la inserción en una sola consulta
            string sql = @"
        DECLARE @TempTable TABLE (IDGerente INT); -- Declarar la variable de tabla

        INSERT INTO Registros (NombreGerente, Fecha_Nacimiento, RTN, TelefonoGerente, Genero)
        OUTPUT inserted.IDGerente INTO @TempTable -- Almacenar el IDGerente en la tabla temporal
        VALUES (@NombreGerente, @Fecha_Nacimiento, @RTN, @TelefonoGerente, @Genero);

        SELECT IDGerente FROM @TempTable; -- Obtener el IDGerente desde la tabla temporal
    ";

            SqlCommand InsertarGerente = new SqlCommand(sql, oconexion.Conectar());
            InsertarGerente.Parameters.AddWithValue("@NombreGerente", egerente.NombreGerente);
            InsertarGerente.Parameters.AddWithValue("@Fecha_Nacimiento", egerente.Fecha_Nacimiento);
            InsertarGerente.Parameters.AddWithValue("@RTN", egerente.RTN);
            InsertarGerente.Parameters.AddWithValue("@TelefonoGerente", egerente.TelefonoGerente);
            InsertarGerente.Parameters.AddWithValue("@Genero", egerente.Genero);

            // Ejecutar la consulta y obtener el IDGerente
            var result = InsertarGerente.ExecuteScalar();
            oconexion.Desconectar();

            return Convert.ToInt32(result);  // Devuelve el IDGerente insertado
        }

       
        public DataTable MostrarRegistros()
        {
            oconexion.Conectar();
            string query = "select * from Registros";
            SqlDataAdapter ObtenerRegistro = new SqlDataAdapter(query,oconexion.Conectar());
            DataTable gerentes = new DataTable();
            ObtenerRegistro.Fill(gerentes);
            return gerentes;
        }

public int EditarGerente(CE_Gerente egerente)
        {
            oconexion.Conectar();
            string edit = "update Registros set NombreGerente=@NombreGerente, Fecha_Nacimiento=@Fecha_Nacimiento, RTN=@RTN, TelefonoGerente=@TelefonoGerente, Genero=@Genero where (IDGerente=@IDGerente)";
            SqlCommand EditarGerente = new SqlCommand(edit, oconexion.Conectar());
            EditarGerente.Parameters.AddWithValue("@IDGerente", egerente.IDGerente);
            EditarGerente.Parameters.AddWithValue("@NombreGerente", egerente.NombreGerente);
            EditarGerente.Parameters.AddWithValue("@Fecha_Nacimiento", egerente.Fecha_Nacimiento);
            EditarGerente.Parameters.AddWithValue("@RTN", egerente.RTN);
            EditarGerente.Parameters.AddWithValue("@TelefonoGerente", egerente.TelefonoGerente);
            EditarGerente.Parameters.AddWithValue("@Genero", egerente.Genero);
            var resultado = EditarGerente.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }


        public string[] RecuperarGerente(CE_Gerente egerente)
        {
            string[] resultado = { "", "" };
            string sql = "select * from Registros where IDGerente=@IDGerente";
            SqlCommand BuscarGerente = new SqlCommand(sql, oconexion.Conectar());
            BuscarGerente.Parameters.AddWithValue("@IDGerente", egerente.IDGerente);
            SqlDataReader dato = BuscarGerente.ExecuteReader();
            if (dato.Read())
            {
                resultado[0] = dato.GetString(1); // NombreGerente
                resultado[1] = dato.GetString(2); // Fecha_Nacimiento
            }
            return resultado;
        }
    }
}
