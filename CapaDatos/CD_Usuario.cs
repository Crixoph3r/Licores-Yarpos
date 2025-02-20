using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        Conexion oconexion = new Conexion();


        public int RegistrarUsuario(CE_Usuario eusuario, int idGerente)
        {
            oconexion.Conectar();

            // Encriptación de la contraseña
            string encrip = "";
            byte[] conver = System.Text.Encoding.Unicode.GetBytes(eusuario.Contrasena);
            encrip = Convert.ToBase64String(conver);


            string sql = "insert into Usuarios values (@IDGerente, @NombreUsuario, @Contrasena, @rol )";

            SqlCommand InsertarUsuario = new SqlCommand(sql, oconexion.Conectar());
            InsertarUsuario.Parameters.AddWithValue("@IDGerente", idGerente);  // Aquí pasa el IDGerente
            InsertarUsuario.Parameters.AddWithValue("@NombreUsuario", eusuario.NombreUsuario);
            InsertarUsuario.Parameters.AddWithValue("@Contrasena", encrip);
            InsertarUsuario.Parameters.AddWithValue("@rol", eusuario.rol);
            var resultado = InsertarUsuario.ExecuteNonQuery();
            oconexion.Desconectar();
            return Convert.ToInt32(resultado); 
        }




        public DataTable MostrarUsuario()
        {
            oconexion.Conectar();
            string query = "select * from Usuarios ";
            SqlDataAdapter ObtenerRegistro = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable usuarios = new DataTable();
            ObtenerRegistro.Fill(usuarios);
            return usuarios;
        }



        public int EditarUsuario(CE_Usuario eusuario, int IDGerente)
        {
            oconexion.Conectar();
            // Modificar la consulta SQL para actualizar la contraseña sin encriptarla
            string edit = "UPDATE Usuarios SET IDGerente=@IDGerente, NombreUsuario=@NombreUsuario, Contrasena=@Contrasena, rol=@rol WHERE IDUsuario=@IDUsuario";

            SqlCommand EditarUsuario = new SqlCommand(edit, oconexion.Conectar());
            EditarUsuario.Parameters.AddWithValue("@IDUsuario", eusuario.IDUsuario);
            EditarUsuario.Parameters.AddWithValue("@IDGerente", IDGerente);
            EditarUsuario.Parameters.AddWithValue("@NombreUsuario", eusuario.NombreUsuario);
            EditarUsuario.Parameters.AddWithValue("@Contrasena", eusuario.Contrasena); // Contraseña en texto plano
            EditarUsuario.Parameters.AddWithValue("@rol", eusuario.rol);

            var resultado = EditarUsuario.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }


        public object[] ValidarUsuario(CE_Usuario eusuario)
        {
            string encrip = "";
            byte[] conver = System.Text.Encoding.Unicode.GetBytes(eusuario.Contrasena);
            encrip = Convert.ToBase64String(conver);

            object[] resultado = { 0, 0, "" ,"",""}; // resultado[0] = IDGerente, resultado[1] = IDUsuario, resultado[2] = Rol (string)

            string sql = "SELECT IDUsuario, IDGerente, Rol, NombreUsuario FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";
            SqlCommand BuscarUsuario = new SqlCommand(sql, oconexion.Conectar());
            BuscarUsuario.Parameters.AddWithValue("@NombreUsuario", eusuario.NombreUsuario);
            BuscarUsuario.Parameters.AddWithValue("@Contrasena", encrip);
            SqlDataReader dato = BuscarUsuario.ExecuteReader();

            if (dato.Read())
            {
                resultado[0] = dato.GetInt32(1); // IDGerente
                resultado[1] = dato.GetInt32(0); // IDUsuario
                resultado[2] = dato.GetString(2);
                resultado[3] = dato.GetString(3);


            }
            else
            {
                resultado[0] = 0; // IDGerente no encontrado
                resultado[1] = 0; // IDUsuario no encontrado
                resultado[2] = "";
                resultado[3] = "";


            }

            return resultado;
        }

        
    }
}
