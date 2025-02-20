using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        CD_Usuario ousuario = new CD_Usuario();


        public int RegistrarUsuario(CE_Usuario eusuario, int idGerente)
        {
            try
            {
                // Asegúrate de que ousuario esté inicializado
                if (ousuario == null)
                {
                    throw new InvalidOperationException("El objeto ousuario no ha sido inicializado.");
                }

                // Llama al método RegistrarUsuario y devuelve el resultado
                return ousuario.RegistrarUsuario(eusuario, idGerente);
            }
            catch (Exception ex)
            {
                // Maneja la excepción (puedes loguearla, relanzarla, etc.)
                Console.WriteLine("Error al registrar el usuario: " + ex.Message);
                throw; // Relanza la excepción si es necesario
            }
        }

        public DataTable MostrarUsuario()
        {
            return ousuario.MostrarUsuario();

        }

        public int EditarUsuario(CE_Usuario eusuario, int IDGerente)
        {
            return ousuario.EditarUsuario(eusuario, IDGerente);
        }


        public object[] ValidarUsuario(CE_Usuario eusuario)
        {
            return ousuario.ValidarUsuario(eusuario);
        }

    }
}
