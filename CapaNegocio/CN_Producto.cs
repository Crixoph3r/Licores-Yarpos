using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public  class CN_Producto
    {

        Conexion oconexion = new Conexion();
        CD_Producto oproducto = new CD_Producto();

        public int RegistrarProducto(CE_Producto eproducto, int IDUsuario)
        {
            return oproducto.RegistrarProducto(eproducto, IDUsuario);
        }

        public DataTable MostrarProductos()
        {
            return oproducto.MostrarProductos();
        }

        public int EditarProducto(CE_Producto eproducto, int IDUsuario)
        {
            return oproducto.EditarProducto(eproducto, IDUsuario);
        }

        public string ObtenerEstadoProducto(int idProducto)
        {
            string estado = "";
            using (oconexion.Conectar())
            {
                oconexion.Conectar();
                string query = "SELECT Estado FROM Productos WHERE IDProducto = @IDProducto";
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@IDProducto", idProducto);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    estado = reader["Estado"].ToString();
                }
            }
            return estado;
        }

    }
}
