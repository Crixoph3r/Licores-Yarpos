using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Clientes
    {
      public int   IDCliente {  get; set; }
      public string NombreCliente {  get; set; }

        public string  DireccionCliente {  get; set; }
        public string TelefonoCliente {  get; set; }
	    
        public int IDUsuario {  get; set; }
    }
}
