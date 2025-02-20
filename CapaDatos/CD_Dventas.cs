using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Dventas
    {
        Conexion oconexion = new Conexion();


        public int RegistrarDventas(CE_DVentas edventas, int IDUsuario)
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
                string sql = "INSERT INTO DetalleVenta VALUES (  @IDFactura, @IDProducto, @Cantidad, @Precio, @IDUsuario)";

                using (SqlCommand InsertarDVentas = new SqlCommand(sql, oconexion.Conectar()))
                {

                    InsertarDVentas.Parameters.AddWithValue("@IDFactura", edventas.IDFactura);
                    InsertarDVentas.Parameters.AddWithValue("@IDProducto", edventas.IDProducto);
                    InsertarDVentas.Parameters.AddWithValue("@Cantidad", edventas.Cantidad);
                    InsertarDVentas.Parameters.AddWithValue("@Precio",edventas.Precio);                   
                    InsertarDVentas.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                    int resultado = InsertarDVentas.ExecuteNonQuery();
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

        public DataTable MostrarDVenta()
        {
            oconexion.Conectar();
            string query = "select * from DetalleVenta";
            SqlDataAdapter ObtenerDVenta = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable Ventas = new DataTable();
            ObtenerDVenta.Fill(Ventas);
            return Ventas;
        }


        public int EditarDVenta(CE_DVentas edventa, int IDUsuario)
        {
            oconexion.Conectar();
            string sql = "update DetalleVenta set IDFactura=@IDFactura, IDProducto=@IDProducto, Cantidad=@Cantidad, Precio=@Precio, IDUsuario=@IDUsuario where IDDetalleVenta = @IDDetalleVenta";
            SqlCommand EditarDVenta = new SqlCommand(sql, oconexion.Conectar());
            EditarDVenta.Parameters.AddWithValue("@IDDetalleVenta", edventa.IDDetalleVenta);
            EditarDVenta.Parameters.AddWithValue("@IDFactura", edventa.IDFactura);
            EditarDVenta.Parameters.AddWithValue("@IDProducto", edventa.IDProducto);
            EditarDVenta.Parameters.AddWithValue("@Cantidad", edventa.Cantidad);
            EditarDVenta.Parameters.AddWithValue("@Precio", edventa.Precio);
            EditarDVenta.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            var resultado = EditarDVenta.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }
    }
}
