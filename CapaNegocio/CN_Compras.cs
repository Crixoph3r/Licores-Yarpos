using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compras
    {
        CD_Compras ocompras = new CD_Compras();

        public int RegistrarCompras(CE_Compras ecompra, int IDUsuario)
        {
            return ocompras.RegistrarCompras(ecompra, IDUsuario );
        }

        public DataTable MostrarCompras()
        {
            return ocompras.MostrarCompras();
        }

        public int EditarCompras(CE_Compras ecompra, int IDUsuario)
        {
            return ocompras.EditarCompras(ecompra, IDUsuario);
        }

    }
}
