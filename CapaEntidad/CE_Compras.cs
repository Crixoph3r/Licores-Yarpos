using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Compras
    {
        public int IDPCompra {  get; set; }
        public DateTime Fecha {  get; set; }
         public int IDProducto {  get; set; }

         public int IDProveedores {  get; set; } 

         public int  Cantidad {  get; set; }

         public decimal Total_pagar {  get; set; }

        public int IDUsuario { get; set; }

    }
}
