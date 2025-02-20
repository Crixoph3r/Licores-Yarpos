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
    public class CD_Proveedor
    {
        Conexion oconexion = new Conexion();


        public int RegistrarProveedor(CE_Proveedor eproveedor, int IDUsuario)
        {
            try
            {
                oconexion.Conectar();

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

                // Insertar en la tabla Proveedores
                string sql = "INSERT INTO Proveedores ( NombreProveedor, RTN, TelefonoProveedor, NombreEmpresa, DireccionEmpresa, IDUsuario) " +
                             "VALUES ( @NombreProveedor, @RTN, @TelefonoProveedor, @NombreEmpresa, @DireccionEmpresa, @IDUsuario)";

                using (SqlCommand InsertarProveedor = new SqlCommand(sql, oconexion.Conectar()))
                {
                  
                    InsertarProveedor.Parameters.AddWithValue("@NombreProveedor", eproveedor.NombreProveedor);
                    InsertarProveedor.Parameters.AddWithValue("@RTN", eproveedor.RTN);
                    InsertarProveedor.Parameters.AddWithValue("@TelefonoProveedor", eproveedor.TelefonoProveedor);
                    InsertarProveedor.Parameters.AddWithValue("@NombreEmpresa", eproveedor.NombreEmpresa);
                    InsertarProveedor.Parameters.AddWithValue("@DireccionEmpresa", eproveedor.DireccionEmpresa);
                    InsertarProveedor.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                    int resultado = InsertarProveedor.ExecuteNonQuery();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                oconexion.Desconectar();
            }

        }

        public DataTable MostrarProveedor()
        {
            oconexion.Conectar();
            string query = "select * from Proveedores";
            SqlDataAdapter ObtenerProveeddor = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable Proveedores = new DataTable();
            ObtenerProveeddor.Fill(Proveedores);
            return Proveedores;
        }


        public int EditarProveedor(CE_Proveedor eproveedor, int IDUsuario)
        {
            oconexion.Conectar();
            string sql = "update Proveedores set NombreProveedor =@NombreProveedor, RTN=@RTN, TelefonoProveedor=@TelefonoProveedor, NombreEmpresa=@NombreEmpresa, DireccionEmpresa=@DireccionEmpresa,IDUsuario=@IDUsuario where IDProveedor = @IDProveedor";
            SqlCommand EditarProveedor = new SqlCommand(sql, oconexion.Conectar());
            EditarProveedor.Parameters.AddWithValue("@IDProveedor", eproveedor.IDProveedor);
            EditarProveedor.Parameters.AddWithValue("@NombreProveedor", eproveedor.NombreProveedor);
            EditarProveedor.Parameters.AddWithValue("@RTN", eproveedor.RTN);
            EditarProveedor.Parameters.AddWithValue("@TelefonoProveedor", eproveedor.TelefonoProveedor);
            EditarProveedor.Parameters.AddWithValue("@NombreEmpresa", eproveedor.NombreEmpresa);
            EditarProveedor.Parameters.AddWithValue("@DireccionEmpresa", eproveedor.DireccionEmpresa);
            EditarProveedor.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            var resultado = EditarProveedor.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }
        


    }
}
