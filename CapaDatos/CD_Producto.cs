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
    public class CD_Producto
    {
        Conexion oconexion = new Conexion();


        public int RegistrarProducto(CE_Producto eproducto, int IDUsuario)
        {
            oconexion.Conectar();
            try
            {
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
                string sql = "insert into Productos values(@NombreProducto,@Tipo, @Precio, @Estado,@IDUsuario)";
                SqlCommand InsertarProducto = new SqlCommand(sql, oconexion.Conectar());
              
                InsertarProducto.Parameters.AddWithValue("@NombreProducto", eproducto.NombreProducto);
                InsertarProducto.Parameters.AddWithValue("@Tipo", eproducto.Tipo);
                InsertarProducto.Parameters.AddWithValue("@Precio", eproducto.Precio);
                InsertarProducto.Parameters.AddWithValue("@Estado", eproducto.Estado);
                InsertarProducto.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                var resultado = InsertarProducto.ExecuteNonQuery();
                oconexion.Desconectar();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return 0;
            }
           
        }

        public DataTable MostrarProductos()
        {
            oconexion.Conectar();
            string query = "select * from Productos";
            SqlDataAdapter ObtenerRegistro = new SqlDataAdapter(query, oconexion.Conectar());
            DataTable productos = new DataTable();
            ObtenerRegistro.Fill(productos);
            return productos;
        }

        public int EditarProducto(CE_Producto eproducto, int IDUsuario)
        {
            oconexion.Conectar();
            string edit = "update Productos set  NombreProducto=@NombreProducto, Tipo=@Tipo, Precio=@Precio, Estado=@Estado, IDUsuario=@IDUsuario where (IDProducto=@IDProducto)";
            SqlCommand EditarProducto = new SqlCommand(edit, oconexion.Conectar());
            EditarProducto.Parameters.AddWithValue("@IDProducto", eproducto.IDProducto);
            EditarProducto.Parameters.AddWithValue("@NombreProducto", eproducto.NombreProducto);
            EditarProducto.Parameters.AddWithValue("@Tipo", eproducto.Tipo);
            EditarProducto.Parameters.AddWithValue("@Precio", eproducto.Precio);
            EditarProducto.Parameters.AddWithValue("@Estado", eproducto.Estado);
            EditarProducto.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            var resultado = EditarProducto.ExecuteNonQuery();
            oconexion.Desconectar();
            return resultado;
        }

    }
}
