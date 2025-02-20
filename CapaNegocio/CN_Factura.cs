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
    public class CN_Factura
    {
        CD_Factura ofactura = new CD_Factura();

        public int RegistrarFactura(CE_Factura efactura, int IDUsuario)
        {
            return ofactura.RegistrarFactura(efactura, IDUsuario);

        }

        public DataTable MostrarFactura()
        {
         return ofactura.MostrarFacturas();
          
        }

        public int Editaracturas(CE_Factura efactura, int IDUsuario)
        {
            return ofactura.Editaracturas(efactura, IDUsuario);
        }

    }
}
