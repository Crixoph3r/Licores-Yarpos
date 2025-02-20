using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Proveedor
    {
        CD_Proveedor oproveedor = new CD_Proveedor();

        public int RegistrarProveedor(CE_Proveedor eproveedor, int IDUsuario)
        {
            return oproveedor.RegistrarProveedor(eproveedor, IDUsuario);
        }

        public DataTable MostrarProveedor()
        {
            oproveedor.MostrarProveedor();
            return oproveedor.MostrarProveedor();
        }


        public int EditarProveedor(CE_Proveedor eproveedor, int IDUsuario)
        {
            return oproveedor.EditarProveedor(eproveedor, IDUsuario);
        }

    }
}
