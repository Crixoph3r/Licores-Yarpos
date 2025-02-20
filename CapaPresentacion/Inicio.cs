using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

       
        CE_Gerente egerente = new CE_Gerente();
        CE_Usuario eusuario = new CE_Usuario();
        
        CN_Gerente ogerente = new CN_Gerente();
        CN_Usuario ousuario = new CN_Usuario();


        private void ContrasenaTXT_TextChanged(object sender, EventArgs e)
        {
            ContrasenaTXT.PasswordChar = '•';
            ContrasenaTXT.ForeColor = Color.Black;
        }
        
        public void Limpia()
        {
            UsuarioTXT.Clear();
            ContrasenaTXT.Clear();
        }

        private int IDUsuario;
        private void IniciarSesionBTN_Click_1(object sender, EventArgs e)
        {
            eusuario.NombreUsuario = UsuarioTXT.Text;
            eusuario.Contrasena = ContrasenaTXT.Text;

            // Validar si los campos están vacíos antes de consultar la base de datos
            if (string.IsNullOrEmpty(UsuarioTXT.Text) || string.IsNullOrEmpty(ContrasenaTXT.Text))
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Consultar la base de datos
            var resultado = ousuario.ValidarUsuario(eusuario);

            if (resultado != null && resultado.Count() > 0) // Asegurar que hay datos
            {
                object objIDGerente = resultado[0];
                object objIDUsuario = resultado[1];
                object objRol = resultado[2];
                object objNomb = resultado[3];

                // Validar que los valores sean correctos
                if (objIDGerente != null && objIDUsuario != null && objRol != null)
                {
                    int IDGerente = Convert.ToInt32(objIDGerente);
                    int IDUsuario = Convert.ToInt32(objIDUsuario);
                    string rol = objRol.ToString();
                    string NombreUsuario = objNomb.ToString();

                    // Validar que el usuario ingresado es el correcto (incluyendo mayúsculas y minúsculas)
                    if (IDGerente > 0 )
                    {
                        bool usuarioValido = string.Equals(UsuarioTXT.Text, NombreUsuario, StringComparison.Ordinal);

                        if (usuarioValido)
                        {
                            // Código para iniciar sesión
                            MenuOpciones menu = new MenuOpciones();
                            menu.SetUsuarioLabel(UsuarioTXT.Text);
                            menu.SetIDUsuario(IDUsuario);
                            menu.SetRolUsuario(rol);
                            menu.Show();
                            Limpia();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CrearCuentaLB_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            var usuariosRegistrados = ousuario.MostrarUsuario();

            if (usuariosRegistrados != null && usuariosRegistrados.Rows.Count > 0)
            {
                // Si hay usuarios registrados, ocultar el label
                CrearCuentaLB.Visible = false;
            }
            else
            {
                // Si no hay usuarios registrados, mostrar el label
                CrearCuentaLB.Visible = true;
            }
        }

        public void OcultarCrearCuentaLB()
        {
            CrearCuentaLB.Visible = false;
        }

        private void TituloRealLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
