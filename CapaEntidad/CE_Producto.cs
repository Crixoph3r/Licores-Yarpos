using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Producto
    {

        public int  IDProducto {  get; set; }
         public string NombreProducto {  get; set; }
	     public string Tipo {  get; set; }

         public decimal Precio {  get; set; }
         public string Estado {  get; set; }

        public int IDUsuario { get; set; }
      

    }
}
