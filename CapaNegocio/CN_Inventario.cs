using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Inventario
    {
        CD_Inventario oinventario = new CD_Inventario();

        public int RegistrarInventario(CE_Inventario einventario, int IDUsuario)
        {
            return oinventario.RegistrarInventario(einventario, IDUsuario);
        }

        public DataTable MostrarInventario()
        {
           return oinventario.MostrarInventario();
        }

        public int EditarInventario(CE_Inventario einventario, int IDUsuario)
        {
            return oinventario.EditarInventario(einventario,IDUsuario);
        }
    }
}
