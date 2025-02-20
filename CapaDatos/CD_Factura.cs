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
    public class CD_Factura
    {
        Conexion oconexion = new Conexion();
        public int RegistrarFactura(CE_Factura efactura, int IDUsuario)
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
                string sql = "insert into Facturas values( @IDFactura, @IDCliente, @Fecha, @Total_pagar, @IDUsuario)";
                SqlCommand InsertarFactura = new SqlCommand(sql, oconexion.Conectar());
                InsertarFactura.Parameters.AddWithValue("@IDFactura", efactura.IDFactura);
                InsertarFactura.Parameters.AddWithValue("@IDCliente", efactura.IDCliente);
                InsertarFactura.Parameters.AddWithValue("@Fecha", efactura.Fecha);
                InsertarFactura.Parameters.AddWithValue("@Total_pagar", efactura.Total_pagar);
                InsertarFactura.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                var resultado = InsertarFactura.ExecuteNonQuery();
                oconexion.Desconectar();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public DataTable MostrarFacturas()
        {
            oconexion.Conectar();
            string query = "select * from  Facturas";
            SqlDataAdapter ObtenerRegistro = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable facturas = new DataTable();
            ObtenerRegistro.Fill(facturas);
            return facturas;
        }

        public int Editaracturas(CE_Factura efactura, int IDUsuario)
        {
            oconexion.Conectar();
            string edit = "update Facturas set  IDCliente=@IDCliente, Fecha=@Fecha, Total_pagar=@Total_pagar,  IDUsuario=@IDUsuario  where (IDFactura=@IDFactura)";
            SqlCommand EditarFactura = new SqlCommand(edit, oconexion.Conectar());
            EditarFactura.Parameters.AddWithValue("@IDFactura", efactura.IDFactura);
            EditarFactura.Parameters.AddWithValue("@IDCliente", efactura.IDCliente);
            EditarFactura.Parameters.AddWithValue("@Fecha", efactura.Fecha);
            EditarFactura.Parameters.AddWithValue("@Total_pagar", efactura.Total_pagar);
            EditarFactura.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            var resultado = EditarFactura.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }
    }

}

