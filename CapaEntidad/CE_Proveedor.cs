using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Proveedor
    {
        public int IDProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string RTN { get; set; }
        public string TelefonoProveedor { get; set; }
        public string NombreEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }

        public int IDUsuario {  get; set; }
    }
}
