using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace CapaPresentacion
{
    public partial class Registro : Form
    {
        Conexion oconexion = new Conexion();
        CE_Gerente egerente = new CE_Gerente();
        CN_Gerente ogerente = new CN_Gerente();

        CE_Usuario eusuario = new CE_Usuario();
        CN_Usuario ousuario = new CN_Usuario();

        private int IDUsuario;
        private string UsuarioLB;

        public Registro()
        {
            InitializeComponent();
        }

        private void RegistrarseBTN_Click(object sender, EventArgs e)
        {
            RegistrarseBTN_Click(sender, e, FechaNacimientoPICK);
        }

        public bool ExisteUsuario(string nombreUsuario)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool ExisteGerente(string rtn)
        {
            string query = "SELECT COUNT(*) FROM Registros WHERE RTN = @RTN";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@RTN", rtn);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool Existetelefono(string TelefonoGerente)
        {
            string query = "SELECT COUNT(*) FROM Registros WHERE TelefonoGerente = @TelefonoGerente";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@TelefonoGerente", TelefonoGerente);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void RegistrarseBTN_Click(object sender, EventArgs e, DateTimePicker fechaNacimientoPICK)
        {

            egerente.NombreGerente = NombreTXT.Text;
            eusuario.NombreUsuario = CrearNombreUsuTXT.Text;
            egerente.Fecha_Nacimiento = fechaNacimientoPICK.Value;
            egerente.TelefonoGerente = TelefonoTXT.Text;
            egerente.Genero = GeneroCOMBO.Text;
            egerente.RTN = RTNTXT.Text;
            eusuario.rol = RolCOMBO.Text;
            eusuario.Contrasena = CrearContraTXT.Text;

           

            if (NombreTXT.Text == "" || CrearNombreUsuTXT.Text == "" || TelefonoTXT.Text == "" || GeneroCOMBO.Text == "" || RTNTXT.Text == "" || RolCOMBO.Text == "" || CrearContraTXT.Text == "" || VerificarContraTXT.Text == "")
            {
                MessageBox.Show("Por favor ingrese los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verificar si el usuario ya existe
                if (ExisteUsuario(eusuario.NombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario ya está en uso. Intente con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el gerente ya existe
                if (ExisteGerente(egerente.RTN))
                {
                    MessageBox.Show("El RTN ya está registrado. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Verificar si el gerente ya existe
                if (Existetelefono(egerente.TelefonoGerente))
                {
                    MessageBox.Show("El telefono ya está registrado. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (eusuario.Contrasena != VerificarContraTXT.Text)
                {
                    MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int idGerente = ogerente.RegistrarGerente(egerente);
                    if (idGerente > 0)
                    {
                        if (ousuario.RegistrarUsuario(eusuario, idGerente) > 0)
                        {
                            MessageBox.Show("Dato Almacenado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gerente(); 
                            limpiar();
                            Inicio inicio = Application.OpenForms["Inicio"] as Inicio;
                            if (inicio != null)
                            {
                                inicio.OcultarCrearCuentaLB();
                               
                            }
                            limpiar();
                            inicio.Show();
                            // Cerrar el formulario de registro
                            this.Hide();

                        
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dato no Almacenado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        public void gerente()

        {
            DataTable dt = new DataTable();
            string query = @"
            SELECT 
            Registros.IDGerente,
            Registros.NombreGerente,
            Registros.Fecha_Nacimiento,
            Registros.RTN,
            Registros.TelefonoGerente,
            Registros.Genero,
            Usuarios.IDUsuario,
            Usuarios.NombreUsuario,
            Usuarios.Contrasena,  -- Asegúrate de que esta columna esté incluida
            Usuarios.rol
             FROM 
            Registros
          INNER JOIN 
            Usuarios ON Registros.IDGerente = Usuarios.IDGerente;";

            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            DgvRegistro.DataSource = dt;
            DgvRegistro.Columns["Contrasena"].Visible = false; // Ocultar la columna de la contraseña
        }

        public void limpiar()
        {
            NombreTXT.Clear();
            CrearNombreUsuTXT.Clear();
            TelefonoTXT.Clear();
            RTNTXT.Clear();
            CrearContraTXT.Clear();
           
        }


        public void Registro_Load(object sender, EventArgs e)
        {
            var usuariosRegistrados = ousuario.MostrarUsuario();


            if (usuariosRegistrados != null && usuariosRegistrados.Rows.Count > 0)
            {
                RolCOMBO.Items.Add("Gerente");
                RolCOMBO.Items.Add("Empleado");
                
            } else
            {
                 RolCOMBO.Items.Add("Gerente");

            }
            RolCOMBO.DropDownStyle = ComboBoxStyle.DropDownList;
            GeneroCOMBO.Items.Add("Masculino");
            GeneroCOMBO.Items.Add("Femenino");
            GeneroCOMBO.DropDownStyle = ComboBoxStyle.DropDownList;


            gerente();
           
            DgvRegistro.Columns["Contrasena"].Visible = false;
        }

        public void SetUsuarioLabel(string nombreUsuario)
        {
            UsuarioLB = nombreUsuario;

        }


      

     

        private void TelefonoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                int limite = 8;
                if (TelefonoTXT.SelectionStart >= limite)
                {
                    e.Handled = true; // Bloquea la entrada de nuevos caracteres más allá del límite
                }
            }
        }

        private void RTNTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void SalirBTN_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();
            menu.SetIDUsuario(IDUsuario);
            menu.SetUsuarioLabel(UsuarioLB);
            menu.Show();
            this.Hide();
        }

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            NombreTXT.Text = "";
            CrearNombreUsuTXT.Text = "";
            TelefonoTXT.Text = "";
            GeneroCOMBO.SelectedIndex = -1;
            RTNTXT.Text = "";
            RolCOMBO.SelectedIndex = -1;
            CrearContraTXT.Text = "";
            VerificarContraTXT.Text = "";
         
        }

        private void SalirBTN_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void DgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombreTXT.Text = DgvRegistro.CurrentRow.Cells[1].Value.ToString();
            FechaNacimientoPICK.Value = Convert.ToDateTime(DgvRegistro.CurrentRow.Cells[2].Value);
            TelefonoTXT.Text = DgvRegistro.CurrentRow.Cells[4].Value.ToString();
            RTNTXT.Text = DgvRegistro.CurrentRow.Cells[3].Value.ToString();
            GeneroCOMBO.Text = DgvRegistro.CurrentRow.Cells[5].Value.ToString();

            CrearNombreUsuTXT.Text = DgvRegistro.CurrentRow.Cells[7].Value.ToString();
          
            RolCOMBO.Text = DgvRegistro.CurrentRow.Cells[9].Value.ToString();

        }


    }
}
