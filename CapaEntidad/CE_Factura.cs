using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Factura
    {
      public int  IDFactura { get; set; }
      public int IDCliente {  get; set; }
      public DateTime Fecha {  get; set; }

      public decimal Total_pagar {  get; set; }

	   public int IDUsuario {  get; set; }

    }
}
