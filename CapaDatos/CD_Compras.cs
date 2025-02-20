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
    public  class CD_Compras
    {
        Conexion oconexion = new Conexion();
        public int RegistrarCompras(CE_Compras ecompras, int IDUsuario)
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
                string sql = "insert into Compras values(  @Fecha,@IDProducto, @IDProveedores, @Cantidad, @Total_pagar,@IDUsuario)";
                SqlCommand InsertarCompra = new SqlCommand(sql, oconexion.Conectar());
                InsertarCompra.Parameters.AddWithValue("@Fecha", ecompras.Fecha);
                InsertarCompra.Parameters.AddWithValue("@IDProducto", ecompras.IDProducto);
                InsertarCompra.Parameters.AddWithValue("@IDProveedores", ecompras.IDProveedores);
                InsertarCompra.Parameters.AddWithValue("@Cantidad", ecompras.Cantidad);
                InsertarCompra.Parameters.AddWithValue("@Total_pagar", ecompras.Total_pagar);
                InsertarCompra.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                var resultado = InsertarCompra.ExecuteNonQuery();
                oconexion.Desconectar();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        public DataTable MostrarCompras()
        {
            oconexion.Conectar();
            string query = "select * from Compras";
            SqlDataAdapter ObtenerRegistro = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable compras = new DataTable();
            ObtenerRegistro.Fill(compras);
            return compras;
        }

        public int EditarCompras(CE_Compras ecompras, int IDUsuario)
        {
            oconexion.Conectar();
            string edit = "update Compras set  Fecha=@Fecha, IDProducto=@IDProducto, IDProveedores=@IDProveedores, Cantidad=@Cantidad,Total_pagar=@Total_pagar,IDUsuario=@IDUsuario  where (IDPCompra=@IDPCompra)";
            SqlCommand EditarCompra = new SqlCommand(edit, oconexion.Conectar());
            EditarCompra.Parameters.AddWithValue("@IDPCompra", ecompras.IDPCompra);
            EditarCompra.Parameters.AddWithValue("@Fecha", ecompras.Fecha);
            EditarCompra.Parameters.AddWithValue("@IDProducto", ecompras.IDProducto);
            EditarCompra.Parameters.AddWithValue("@IDProveedores", ecompras.IDProveedores);
            EditarCompra.Parameters.AddWithValue("@Cantidad", ecompras.Cantidad);
            EditarCompra.Parameters.AddWithValue("@Total_pagar", ecompras.Total_pagar);
            EditarCompra.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            var resultado = EditarCompra.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }

    }
}

