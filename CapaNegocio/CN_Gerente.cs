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
    public class CN_Gerente
    {
        CD_Gerente ogerente = new CD_Gerente();

        public int RegistrarGerente(CE_Gerente egerente)
        {
            return ogerente.RegistrarGerente(egerente);
        }

        public DataTable MostrarRegistros()
        {
            return ogerente.MostrarRegistros();
        }

        public int EditarGerente(CE_Gerente egerente)
        {
            return ogerente.EditarGerente(egerente);
        }


        public string[] RecuperarGerente(CE_Gerente egerente)
        {
            return ogerente.RecuperarGerente(egerente);
        }
    }
}
