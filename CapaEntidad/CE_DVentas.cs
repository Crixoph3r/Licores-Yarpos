using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_DVentas
    {
       public int IDDetalleVenta { get; set; }


       public int IDFactura { get; set; }
       public int IDProducto { get; set; }

       public int Cantidad { get; set; }

       public decimal Precio { get; set; }

       public int IDUsuario { get; set; }

    }
}
