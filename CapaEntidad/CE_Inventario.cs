using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Inventario
    {
       public int  IDInventario {  get; set; }
       public int IDProducto {  get; set; }

       public int  CantidadInicial { get; set; }

        public int CantidadIEntrante {  get; set; }
   
        public int CantidadSaliente {  get; set; }
        public int ajuste {  get; set; }
        public int Existencia { get; set; }

        public int stock_minimo {  get; set; }

        public int stock_seguridad {  get; set; }

	     public int IDUsuario { get; set; }
    }
}
