using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Clientes
    {
        Conexion oconexion = new Conexion();
        public int RegistrarClientes(CE_Clientes eclientes, int IDUsuario)
        {
            oconexion.Conectar();

            try
            {
                // Verificar que el IDUsuario exista en la tabla Usuarios
                string sqlVerificarUsuario = "SELECT COUNT(*) FROM Usuarios WHERE IDUsuario = @IDUsuario";
                using (SqlCommand VerificarUsuario = new SqlCommand(sqlVerificarUsuario, oconexion.Conectar()))
                {
                    VerificarUsuario.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                    int existeUsuario = Convert.ToInt32(VerificarUsuario.ExecuteScalar());

                    if (existeUsuario == 0)
                    {
                        MessageBox.Show("El ID del usuario no existe en la tabla Usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0; // No se registra el proveedor
                    }
                }
                string sql = "insert into Clientes values(  @NombreCliente,@DireccionCliente, @TelefonoCliente, @IDUsuario)";
                SqlCommand InsertarCliente = new SqlCommand(sql, oconexion.Conectar());
                InsertarCliente.Parameters.AddWithValue("@NombreCliente", eclientes.NombreCliente );
                InsertarCliente.Parameters.AddWithValue("@DireccionCliente", eclientes.DireccionCliente);
                InsertarCliente.Parameters.AddWithValue("@TelefonoCliente", eclientes.TelefonoCliente);
                InsertarCliente.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                var resultado = InsertarCliente.ExecuteNonQuery();
                oconexion.Desconectar();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        public DataTable MostrarClientes()
        {
            oconexion.Conectar();
            string query = "select * from  Clientes";
            SqlDataAdapter ObtenerRegistro = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable clientes = new DataTable();
            ObtenerRegistro.Fill(clientes);
            return clientes;
        }

        public int EditarClientes(CE_Clientes eclientes, int IDUsuario)
        {
            oconexion.Conectar();
            string edit = "update Clientes set  NombreCliente=@NombreCliente, DireccionCliente=@DireccionCliente, TelefonoCliente=@TelefonoCliente, IDUsuario=@IDUsuario  where (IDCliente=@IDCliente)";
            SqlCommand EditarCliente = new SqlCommand(edit, oconexion.Conectar());
            EditarCliente.Parameters.AddWithValue("@IDCliente", eclientes.IDCliente);
            EditarCliente.Parameters.AddWithValue("@NombreCliente", eclientes.NombreCliente);
            EditarCliente.Parameters.AddWithValue("@DireccionCliente", eclientes.DireccionCliente);
            EditarCliente.Parameters.AddWithValue("@TelefonoCliente", eclientes.TelefonoCliente);
            EditarCliente.Parameters.AddWithValue("@IDUsuario",IDUsuario);
            var resultado = EditarCliente.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }
    }
}
