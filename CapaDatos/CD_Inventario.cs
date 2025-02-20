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
    public class CD_Inventario
    {
        Conexion oconexion = new Conexion();
        public int RegistrarInventario(CE_Inventario einventario, int IDUsuario)
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
                string sql = "insert into Inventarios values(  @IDProducto, @CantidadInicial, @CantidadIEntrante, @CantidadSaliente, @ajuste, @Existencia, @stock_minimo, @stock_seguridad,@IDUsuario)";
                SqlCommand InsertarInventario = new SqlCommand(sql, oconexion.Conectar());
                InsertarInventario.Parameters.AddWithValue("@IDProducto", einventario.IDProducto);
                InsertarInventario.Parameters.AddWithValue("@CantidadInicial", einventario.CantidadInicial);
                InsertarInventario.Parameters.AddWithValue("@CantidadIEntrante", einventario.CantidadIEntrante);
                InsertarInventario.Parameters.AddWithValue("@CantidadSaliente", einventario.CantidadSaliente);
                InsertarInventario.Parameters.AddWithValue("@ajuste", einventario.ajuste);
                InsertarInventario.Parameters.AddWithValue("@Existencia", einventario.Existencia);
                InsertarInventario.Parameters.AddWithValue("@stock_minimo", einventario.stock_minimo);
                InsertarInventario.Parameters.AddWithValue("@stock_seguridad", einventario.stock_seguridad);
                InsertarInventario.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                var resultado = InsertarInventario.ExecuteNonQuery();
                oconexion.Desconectar();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        public DataTable MostrarInventario()
        {
            oconexion.Conectar();
            string query = "select * from Inventarios";
            SqlDataAdapter ObtenerRegistro = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable Inventario = new DataTable();
            ObtenerRegistro.Fill(Inventario);
            return Inventario;
        }

        public int EditarInventario(CE_Inventario einventario, int IDUsuario)
        {
            oconexion.Conectar();
            string sql = "UPDATE Inventarios SET ajuste = @ajuste, stock_minimo = @stock_minimo, stock_seguridad = @stock_seguridad, IDUsuario = @IDUsuario WHERE IDInventario = @IDInventario";

            SqlCommand EditarInventario = new SqlCommand(sql, oconexion.Conectar());
            EditarInventario.Parameters.AddWithValue("@IDInventario", einventario.IDInventario);  // Mantén el IDInventario igual
            EditarInventario.Parameters.AddWithValue("@ajuste", einventario.ajuste);
            EditarInventario.Parameters.AddWithValue("@stock_minimo", einventario.stock_minimo);
            EditarInventario.Parameters.AddWithValue("@stock_seguridad", einventario.stock_seguridad);
            EditarInventario.Parameters.AddWithValue("@IDUsuario", IDUsuario);

            // Ejecuta el comando de actualización
            int resultado = EditarInventario.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }
        
    }
}
