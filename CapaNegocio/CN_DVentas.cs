using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CN_DVentas
    {
        CD_Dventas odventas = new CD_Dventas();

        public int RegistrarDventas(CE_DVentas edventas, int IDUsuario)
        {

            return odventas.RegistrarDventas(edventas, IDUsuario);

        }


        public DataTable MostrarDVenta()
        {
            return odventas.MostrarDVenta();
        }


        public int EditarDVenta(CE_DVentas edventa, int IDUsuario)
        {
            return odventas.EditarDVenta(edventa, IDUsuario);
        }
    }
}
