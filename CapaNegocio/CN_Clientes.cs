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
    public class CN_Clientes
    {
        CD_Clientes oclientes = new CD_Clientes();

        public int RegistrarClientes(CE_Clientes eclientes, int IDUsuario)
        {
           

           return oclientes.RegistrarClientes(eclientes, IDUsuario);
        }

        public DataTable MostrarClientes()
        {
          return  oclientes.MostrarClientes();
        }

        public int EditarClientes(CE_Clientes eclientes, int IDUsuario)
        {
            return oclientes.EditarClientes(eclientes, IDUsuario);
        }
    }
}
